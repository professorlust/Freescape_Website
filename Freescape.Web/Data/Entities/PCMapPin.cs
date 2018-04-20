﻿namespace Freescape.Web.Data.Entities
{
    public class PCMapPin
    {
        public int PCMapPinID { get; set; }
        public string PlayerID { get; set; }
        public string AreaTag { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public string NoteText { get; set; }

        public PlayerCharacter Player { get; set; }
    }
}
