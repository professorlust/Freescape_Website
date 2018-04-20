﻿using System;

namespace Freescape.Web.Data.Entities
{
    public class User
    {
        public long UserID { get; set; }
        public string DiscordUserID { get; set; }
        public string Username { get; set; }
        public string AvatarHash { get; set; }
        public string Discriminator { get; set; }
        public string Email { get; set; }
        public int RoleID { get; set; }
        public DateTime DateRegistered { get; set; }

        public DMRoleDomain Role { get; set; }
    }
}
