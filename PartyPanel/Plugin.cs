using IPA;
using SongCore;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using Logger = PartyPanelShared.Logger;

/*
 * Created by Moon on 11/12/2018
 * 
 * This plugin is designed to provide a user interface to launch songs
 * without being in the game
 */

namespace PartyPanel
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        public string Name => "PartyPanel";
        public string Version => "0.0.1";

        private AlwaysOwnedContentSO _alwaysOwnedContent;

        public static List<IPreviewBeatmapLevel> masterLevelList;

        private Client client;
        [OnStart]
        public void OnApplicationStart()
        {
            client = new Client();
            client.Start();

            Loader.SongsLoadedEvent += (Loader _, ConcurrentDictionary<string, CustomPreviewBeatmapLevel> __) =>
            {
                if (_alwaysOwnedContent == null) _alwaysOwnedContent = Resources.FindObjectsOfTypeAll<AlwaysOwnedContentSO>().First();

                masterLevelList = new List<IPreviewBeatmapLevel>();
                for (int i = 0; i < _alwaysOwnedContent.alwaysOwnedPacks.Count(); i++)
                {
                    masterLevelList.AddRange(_alwaysOwnedContent.alwaysOwnedPacks[i].beatmapLevelCollection.beatmapLevels);
                }
                masterLevelList.AddRange(Loader.CustomLevelsCollection.beatmapLevels);

                client.SendSongList(masterLevelList);
            };
        }

        public void OnApplicationQuit()
        {
        }

        public void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
        {
        }

        public void OnSceneUnloaded(Scene scene)
        {
        }

        public void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
        {
        }

        public void OnUpdate()
        {
        }

        public void OnFixedUpdate()
        {
        }
    }
}
