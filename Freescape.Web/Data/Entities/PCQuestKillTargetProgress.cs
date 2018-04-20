﻿namespace Freescape.Web.Data.Entities
{
    public class PCQuestKillTargetProgress
    {
        public int PCQuestKillTargetProgressID { get; set; }
        public string PlayerID { get; set; }
        public int PCQuestStatusID { get; set; }
        public int NPCGroupID { get; set; }
        public int RemainingToKill { get; set; }

        public NPCGroup NPCGroup { get; set; }
        public PCQuestStatus PCQuestStatus { get; set; }
        public PlayerCharacter Player { get; set; }
    }
}
