﻿using System;

namespace Freescape.Web.Data.Entities
{
    public class ClientLogEvent
    {
        public int ClientLogEventID { get; set; }
        public int ClientLogEventTypeID { get; set; }
        public string PlayerID { get; set; }
        public string CDKey { get; set; }
        public string AccountName { get; set; }
        public DateTime DateOfEvent { get; set; }

        public ClientLogEventTypesDomain ClientLogEventType { get; set; }
        public PlayerCharacter Player { get; set; }
    }
}
