﻿namespace Freescape.Web.Models.UI.QuestEditor
{
    public class QuestRequiredItemUI
    {
        public string Resref { get; set; }
        public int Quantity { get; set; }

        public QuestRequiredItemUI()
        {
            Resref = string.Empty;
            Quantity = 0;
        }
    }
}
