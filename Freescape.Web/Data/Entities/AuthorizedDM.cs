﻿namespace Freescape.Web.Data.Entities
{
    public class AuthorizedDM
    {
        public int AuthorizedDMID { get; set; }
        public string Name { get; set; }
        public string CDKey { get; set; }
        public int DMRole { get; set; }
        public bool IsActive { get; set; }
    }
}
