using System;

namespace PartyPanelShared.Models
{
    [Serializable]
    public class GameplayModifiers
    {
		public enum EnabledObstacleType
		{
			All,
			FullHeightOnly,
			NoObstacles
		}
		public enum SongSpeed
        {
            Normal,
            Faster,
            Slower,
            SuperFast
        }
		public enum EnergyType
		{
			Bar,
			Battery
		}

		public EnergyType energyType;

		public bool noFailOn0Energy;

		public bool demoNoFail;

		public bool instaFail;

		public bool failOnSaberClash;

		public EnabledObstacleType enabledObstacleType;

		public bool demoNoObstacles;

		public bool FastNotes;

		public bool strictAngles;

		public bool disappearingArrows;

		public bool ghostNotes;

		public bool noBombs;

		public SongSpeed songSpeed;

		public bool noArrows;

		public bool proMode;

		public bool zenMode;

		public bool smallCubes;
	}
}
