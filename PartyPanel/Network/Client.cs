using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using PartyPanelShared;

namespace PartyPanel.Network
{
    public class ClientPlayer
    {
        public Socket workSocket = null;
        public const int BufferSize = 1024;
        public byte[] buffer = new byte[BufferSize];
        public List<byte> accumulatedBytes = new List<byte>();
    }

    public class Client
    {
        public event Action<Packet> PacketRecieved;
        public event Action ServerDisconnected;

        // The port number for the remote device.  
        private int port;
        private ClientPlayer player;

        private static ManualResetEvent connectDone = new ManualResetEvent(false);

        private HttpListener _listener;
        private CancellationTokenSource _cancellationToken;
        private string _pageData;
        private readonly SemaphoreSlim _requestLock = new SemaphoreSlim(1, 1);

        public bool Connected
        {
            get
            {
                return player?.workSocket?.Connected ?? false;
            }
        }

        public Client(int port)
        {
            this.port = port;
        }

        public void Start()
        {
            if (_pageData == null)
            {
                var reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("PartyPanel.index.html"));
                _pageData = reader.ReadToEnd();
            }

            if (_listener != null)
            {
                return;
            }

            _cancellationToken = new CancellationTokenSource();
            _listener = new HttpListener { Prefixes = { $"http://localhost:50101/" } };
            _listener.Start();


            Task.Run(async () =>
            {
                while (true)
                {
                    try
                    {
                        var httpListenerContext = await _listener.GetContextAsync().ConfigureAwait(false);
                        await OnContext(httpListenerContext).ConfigureAwait(false);
                    }
                    catch (Exception e)
                    {
                    }
                }

                // ReSharper disable once FunctionNeverReturns
            }).ConfigureAwait(false);
        }
        public async void Send(byte[] data)
        {

        }
        private async Task OnContext(HttpListenerContext ctx)
        {
            await _requestLock.WaitAsync();
            try
            {
                var request = ctx.Request;
                var response = ctx.Response;

                if (request.HttpMethod == "POST" && request.Url.AbsolutePath == "/song")
                {
                    var reader = new StreamReader(request.InputStream, request.ContentEncoding);
                    var postStr = await reader.ReadToEndAsync().ConfigureAwait(false);
                    Console.WriteLine(postStr);
                }
                else
                {
                    /*var settingsJson = _settings.GetSettingsAsJson();
					settingsJson["twitch_oauth_token"] = new JSONString(_authManager.Credentials.Twitch_OAuthToken);
					settingsJson["twitch_channels"] = new JSONArray(_authManager.Credentials.Twitch_Channels);*/

                    var pageBuilder = new StringBuilder(_pageData);

                    var data = Encoding.UTF8.GetBytes(pageBuilder.ToString());
                    response.ContentType = "text/html";
                    response.ContentEncoding = Encoding.UTF8;
                    response.ContentLength64 = data.LongLength;
                    await response.OutputStream.WriteAsync(data, 0, data.Length);
                }

                response.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
            }
        }
    }
}
