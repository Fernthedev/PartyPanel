using IPA.Utilities.Async;
using Newtonsoft.Json;
using PartyPanelShared;
using PartyPanelShared.Models;
using Polyglot;
using System;
using System.Collections.Generic;
using System.IO;
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
                Logger.Debug("Start");
                //Send the server the master list if we can
                if (Plugin.masterLevelList != null)
                {
                    Logger.Debug("X");
                    HMMainThreadDispatcher.instance.Enqueue(new Action(async () =>
                    {
                        var songs = await GetSongList(Plugin.masterLevelList);
                        var unused = Task.Run(() =>
                        {
                            SendSongList(songs).ConfigureAwait(false);
                        });

                    }));
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

        private List<PreviewBeatmapLevel> subpacketList = new List<PreviewBeatmapLevel>();


        public async Task GetSongList(List<IPreviewBeatmapLevel> levels)
        {
            List<PreviewBeatmapLevel> subpacketList = new List<PreviewBeatmapLevel>();

            PlayerData playerData = Resources.FindObjectsOfTypeAll<PlayerDataModel>().FirstOrDefault().playerData;
            List<Task<PreviewBeatmapLevel>> tasks = new List<Task<PreviewBeatmapLevel>>();

            foreach (var level in levels)
            {
                tasks.Add(ConvertToPacketType(level, playerData));
            }

            subpacketList.AddRange(await Task.WhenAll(tasks));

            this.subpacketList = subpacketList;
        }

        public async Task SendSongList()
        {
            Logger.Debug("F");

            //Check if we are connected
            if (client != null && client.Connected)
            {
                Logger.Debug("M");
                //Make SongList
                var songList = new SongList();

                //Set Levels
                songList.Levels = subpacketList.ToArray();

                //Send the list over the Network
                Logger.Debug("Sending List");
                File.WriteAllText(Path.Combine(IPA.Utilities.UnityGame.UserDataPath, "JSon.txt"), JsonConvert.SerializeObject(songList));
                client.Send(new Packet(songList).ToBytes());
            }
            else
            {
                var unused = SendSongList(subpacketList).ConfigureAwait(false);
            }
        }
        public Texture2D GetReadableTexForUnreadableTex(Texture2D tex)
        {
            Logger.Debug("Is Main Thread: " + threadTester.TestThread(Thread.CurrentThread).ToString());
            tex.filterMode = FilterMode.Point;

            //Get Temporary RenderTexture
            RenderTexture rt = RenderTexture.GetTemporary(tex.width, tex.height);
            rt.filterMode = FilterMode.Point;

            //Set RenderTexture as Active
            RenderTexture.active = rt;

            //Blit Texture to RenderTexture
            Graphics.Blit(tex, rt);

            //Make New Texture
            Texture2D img2 = new Texture2D(tex.width, tex.height);

            //Read Pixels from RenderTexture
            img2.ReadPixels(new Rect(0, 0, tex.width, tex.height), 0, 0);

            //Apply Pixels
            img2.Apply();
            
            //Reset Active RenderTexure
            RenderTexture.ReleaseTemporary(rt);
            RenderTexture.active = null;

            return img2;
        }
        public Texture2D ClipTexture(Texture2D tex, Rect rect)
        {
            var pixData = tex.GetPixels((int)rect.x, (int)rect.y, (int)rect.width, (int)rect.height);
            var newTex = new Texture2D((int)rect.width, (int)rect.height);
            newTex.SetPixels(pixData);
            newTex.Apply();
            return newTex;
        }
        public PreviewBeatmapLevel LoadSong(PreviewBeatmapLevel packetLevel, IPreviewBeatmapLevel x)
        {
            PreviewBeatmapLevel level = packetLevel;
            LoadedSong loadedSong = new LoadedSong();
            HMMainThreadDispatcher.instance.Enqueue(() => 
            { 
                level.chars = x.previewDifficultyBeatmapSets.Select((PreviewDifficultyBeatmapSet set) => 
                    { 
                        Characteristic Char = new Characteristic(); 
                        Logger.Debug(set.beatmapCharacteristic.icon.texture.isReadable.ToString()); 
                        Char.Name = set.beatmapCharacteristic.serializedName; 
                        Char.diffs = set.beatmapDifficulties.Select((BeatmapDifficulty diff) => { return BeatmapDifficultyMethods.Name(diff); }).ToArray(); 
                        return Char; 
                    }).ToArray();
                loadedSong.level = level;
                client.Send(new Packet(loadedSong).ToBytes()); 
            });
            return level;
        }
        public async Task<PreviewBeatmapLevel> ConvertToPacketType(IPreviewBeatmapLevel x, PlayerData playerData)   
        { 
            //Test Threadx
            

            //Make packet level
            var level = new PreviewBeatmapLevel();

            //Set Parameters;
            level.LevelId = x.levelID;
            level.Name = x.songName;
            level.SubName = x.songSubName;
            level.Author = x.songAuthorName;
            level.Mapper = x.levelAuthorName;
            level.BPM = x.beatsPerMinute;
            level.Duration = TimeExtensions.MinSecDurationText(x.songDuration);
            level.favorited = playerData.favoritesLevelIds.Contains(x.levelID);
            //level.chars = x.previewDifficultyBeatmapSets.Select((PreviewDifficultyBeatmapSet set) => { Characteristic Char = new Characteristic(); Logger.Debug(set.beatmapCharacteristic.icon.texture.isReadable.ToString()); Char.Name = set.beatmapCharacteristic.serializedName; Char.Icon = GetReadableTexForUnreadableTex(set.beatmapCharacteristic.icon.texture).EncodeToPNG(); Char.diffs = set.beatmapDifficulties.Select((BeatmapDifficulty diff)=> { return BeatmapDifficultyMethods.ShortName(diff); }).ToArray(); return Char; }).ToArray();
            //Get Level Sprite
            if (!metadata.runLowCostMode)
            {
                Sprite sprite = await x.GetCoverImageAsync(CancellationToken.None);

                //Get Texture
                Texture2D texture = sprite.texture;
                if (!texture.isReadable)
                {
                    texture = GetReadableTexForUnreadableTex(texture);
                }

                //Encode to PNG and set packet cover
                level.cover = texture.EncodeToPNG();
            }
            Logger.Info("Got Cover for" + x.songName);
            return level;
        }
        public static ServerMetadata metadata = new ServerMetadata();
        private void Client_PacketRecieved(Packet packet)
        {
            if (packet.Type == PacketType.PlaySong)
            {
                PlaySong playSong = packet.SpecificPacket as PlaySong;

                var desiredLevel = Plugin.masterLevelList.First(x => x.levelID == playSong.levelId);
                var desiredCharacteristic = desiredLevel.previewDifficultyBeatmapSets.GetBeatmapCharacteristics().First(x => x.serializedName == playSong.characteristic.Name);
                BeatmapDifficulty desiredDifficulty;
                playSong.difficulty.BeatmapDifficultyFromSerializedName(out desiredDifficulty);


                SaberUtilities.PlaySong(desiredLevel, desiredCharacteristic, desiredDifficulty, playSong);
            }
            else if (packet.Type == PacketType.LoadSong)
            {
                LoadSong loadSong = packet.SpecificPacket as LoadSong;

                LoadedSong loaded = new LoadedSong();
                loaded.level = subpacketList.First(x => x.LevelId == loadSong.levelId);
                loaded.level = LoadSong(loaded.level, Plugin.masterLevelList.First(x => x.levelID == loadSong.levelId));
                //client.Send(new Packet(loaded).ToBytes());
            }
            else if (packet.Type == PacketType.Command)
            {
                Command command = packet.SpecificPacket as Command;
                if (command.commandType == Command.CommandType.ReturnToMenu)
                {
                    SaberUtilities.ReturnToMenu();
                }
            }
            else if (packet.Type == PacketType.ServerMetadata)
            {
                metadata = packet.SpecificPacket as ServerMetadata;
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
