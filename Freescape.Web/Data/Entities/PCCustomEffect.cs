﻿namespace Freescape.Web.Data.Entities
{
    public class PCCustomEffect
    {
        public long PCCustomEffectID { get; set; }
        public string PlayerID { get; set; }
        public long CustomEffectID { get; set; }
        public int Ticks { get; set; }

        public CustomEffect CustomEffect { get; set; }
        public PlayerCharacter Player { get; set; }
    }
}
