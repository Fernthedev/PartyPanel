using System;

namespace PartyPanelShared.Models
{
    [Serializable]
    public class PreviewBeatmapLevel
    {
        // -- Unloaded levels have the following:
        public string LevelId { get; set; }
        public string Name { get; set; }
        public string SubName { get; set; }
        public string Author { get; set; }
        public float Duration { get; set; }
        public float BPM { get; set; }

        // -- Only Loaded levels will have the following:
        public string[] diffs { get; set; }
        public byte[] cover { get; set; } //Cover Imaage stored as bytes
    }
}
