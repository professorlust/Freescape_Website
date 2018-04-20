﻿namespace Freescape.Web.Data.Entities
{
    public class PCRegionalFame
    {
        public int PCRegionalFameID { get; set; }
        public string PlayerID { get; set; }
        public int FameRegionID { get; set; }
        public int Amount { get; set; }

        public FameRegion FameRegion { get; set; }
        public PlayerCharacter Player { get; set; }
    }
}
