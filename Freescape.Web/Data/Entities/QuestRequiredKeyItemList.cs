﻿namespace Freescape.Web.Data.Entities
{
    public class QuestRequiredKeyItemList
    {
        public int QuestRequiredKeyItemID { get; set; }
        public int QuestID { get; set; }
        public int KeyItemID { get; set; }
        public int QuestStateID { get; set; }

        public KeyItem KeyItem { get; set; }
        public Quests Quest { get; set; }
        public QuestState QuestState { get; set; }
    }
}
