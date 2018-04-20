﻿using System;

namespace Freescape.Web.Data.Entities
{
    public class PCKeyItem
    {
        public int PCKeyItemID { get; set; }
        public string PlayerID { get; set; }
        public int KeyItemID { get; set; }
        public DateTime AcquiredDate { get; set; }

        public KeyItem KeyItem { get; set; }
        public PlayerCharacter Player { get; set; }
    }
}
