using IPA.Utilities.Async;
using PartyPanelShared;
using PartyPanelShared.Models;
using Polyglot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using UnityEngine;
using Logger = PartyPanelShared.Logger;
using Timer = System.Timers.Timer;

namespace PartyPanel
{
    class ThreadTester : MonoBehaviour
    {
        Thread mainThread;
        void Start()
        {
            mainThread = Thread.CurrentThread;
        }
        public bool TestThread(Thread thread)
        {
            return mainThread.Equals(thread);
        }
    }
    class Client
    {
        private Network.Client client;
        private Timer heartbeatTimer = new Timer();
        private ThreadTester threadTester;

        public void Start()
        {
            heartbeatTimer.Interval = 10000;
            heartbeatTimer.Elapsed += HeartbeatTimer_Elapsed;
            heartbeatTimer.Start();
            threadTester = new GameObject("ThreadTester").AddComponent<ThreadTester>();
        }

        private void HeartbeatTimer_Elapsed(object _, ElapsedEventArgs __)
        {
            try
            {
                var command = new Command();
                command.commandType = Command.CommandType.Heartbeat;
                client.Send(new Packet(command).ToBytes());
            }
            catch (Exception e)
            {
                Logger.Debug("HEARTBEAT FAILED");

                ConnectToServer();
            }
        }

        private void ConnectToServer()
        {
            
            try
            {
                client = new Network.Client(10155);
                client.PacketRecieved += Client_PacketRecieved;
                client.ServerDisconnected += Client_ServerDisconnected;
                client.Start();

                //Send the server the master list if we can
                if (Plugin.masterLevelList != null)
                {
                    HMMainThreadDispatcher.instance.Enqueue(new Action(() => { SendSongList(Plugin.masterLevelList).ConfigureAwait(false); }));
                }
            
            }
            catch (Exception e)
            {
                Logger.Debug(e.ToString());
            }
        }

        private void Client_ServerDisconnected()
        {
            Logger.Debug("Server disconnected!");
        }

        public async Task SendSongList(List<IPreviewBeatmapLevel> levels)
        {
            //Check if we are connected
            if (client != null && client.Connected)
            {
                //Make Packet List
                var subpacketList = new List<PreviewBeatmapLevel>();

                //Iterate Over Levels
                for (int i = 0; i < levels.Count; i++)
                {
                    //Convert to Packet type and add to list
                    subpacketList.Add(await ConvertToPacketType(levels[i]));
                }

                //Make SongList
                var songList = new SongList();

                //Set Levels
                songList.Levels = subpacketList.ToArray();

                //Send the list over the Network
                client.Send(new Packet(songList).ToBytes());
            }
            else Logger.Debug("Skipped sending songs because there is no server connected");
        }

        public async Task<PreviewBeatmapLevel> ConvertToPacketType(IPreviewBeatmapLevel x)
        { 
            //Test Thread
            Logger.Debug("Is Main Thread: " + threadTester.TestThread(Thread.CurrentThread).ToString());

            //Make packet level
            var level = new PreviewBeatmapLevel();

            //Set Parameters;
            level.LevelId = x.levelID;
            level.Name = x.songName;
            level.SubName = x.songSubName;
            level.Author = x.songAuthorName;
            level.BPM = x.beatsPerMinute;
            level.Duration = x.previewDuration;
            level.diffs = x.previewDifficultyBeatmapSets.Select((PreviewDifficultyBeatmapSet set) => { return set.beatmapCharacteristic.serializedName; }).ToArray();
            //Get Level Sprite
            Sprite sprite = await x.GetCoverImageAsync(CancellationToken.None);

            //Get Texture
            Texture2D texture = sprite.texture;
            if(!texture.isReadable)
            {
                texture.filterMode = FilterMode.Point;

                //Get Temporary RenderTexture
                RenderTexture rt = RenderTexture.GetTemporary(texture.width, texture.height);
                rt.filterMode = FilterMode.Point;

                //Set RenderTexture as Active
                RenderTexture.active = rt;

                //Blit Texture to RenderTexture
                Graphics.Blit(texture, rt);

                //Make New Texture
                Texture2D img2 = new Texture2D(texture.width, texture.height);

                //Read Pixels from RenderTexture
                img2.ReadPixels(new Rect(0, 0, texture.width, texture.height), 0, 0);

                //Apply Pixels
                img2.Apply();
                texture = img2;
                //Reset Active RenderTexure
                RenderTexture.ReleaseTemporary(rt);
                RenderTexture.active = null;
            }

            //Encode to PNG and set packet cover
            level.cover = texture.EncodeToPNG();

            Logger.Info("Got Cover for" + x.songName);
            return level;
        }
        private void Client_PacketRecieved(Packet packet)
        {
            if (packet.Type == PacketType.PlaySong)
            {
                PlaySong playSong = packet.SpecificPacket as PlaySong;

                var desiredLevel = Plugin.masterLevelList.First(x => x.levelID == playSong.levelId);
                var desiredCharacteristic = desiredLevel.previewDifficultyBeatmapSets.GetBeatmapCharacteristics().First(x => x.serializedName == "Standard") ;
                BeatmapDifficulty desiredDifficulty;
                playSong.difficulty.BeatmapDifficultyFromSerializedName(out desiredDifficulty);


                SaberUtilities.PlaySong(desiredLevel, desiredCharacteristic, desiredDifficulty, playSong);
            }
            else if (packet.Type == PacketType.LoadSong)
            {
                LoadSong loadSong = packet.SpecificPacket as LoadSong;

                Action<IBeatmapLevel> SongLoaded = (loadedLevel) =>
                {
                    var loadedSong = new LoadedSong();
                    var beatmapLevel = new PreviewBeatmapLevel();
                    

                    beatmapLevel.LevelId = loadedLevel.levelID;
                    beatmapLevel.Name = loadedLevel.songName;

                    loadedSong.level = beatmapLevel;

                    client.Send(new Packet(loadedSong).ToBytes());
                };

                LoadSong(loadSong.levelId, SongLoaded);
            }
            else if (packet.Type == PacketType.Command)
            {
                Command command = packet.SpecificPacket as Command;
                if (command.commandType == Command.CommandType.ReturnToMenu)
                {
                    SaberUtilities.ReturnToMenu();
                }
            }
        }

        private async void LoadSong(string levelId, Action<IBeatmapLevel> loadedCallback)
        {
            IPreviewBeatmapLevel level = Plugin.masterLevelList.Where(x => x.levelID == levelId).First();

            //Load IBeatmapLevel
            if (level is PreviewBeatmapLevelSO || level is CustomPreviewBeatmapLevel)
            {
                if (level is PreviewBeatmapLevelSO)
                {
                    if (!await SaberUtilities.HasDLCLevel(level.levelID)) return; //In the case of unowned DLC, just bail out and do nothing
                }

                var map = ((CustomPreviewBeatmapLevel)level).standardLevelInfoSaveData.difficultyBeatmapSets.First().difficultyBeatmaps.First();

                var result = await SaberUtilities.GetLevelFromPreview(level);
                if (result != null && !(result?.isError == true))
                {
                    loadedCallback(result?.beatmapLevel);
                }
            }
            else if (level is BeatmapLevelSO)
            {
                loadedCallback(level as IBeatmapLevel);
            }
        }
    }
}
