﻿using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public class StorageContainer
    {
        public StorageContainer()
        {
            StorageItems = new HashSet<StorageItem>();
        }

        public int StorageContainerID { get; set; }
        public string AreaName { get; set; }
        public string AreaTag { get; set; }
        public string AreaResref { get; set; }

        public ICollection<StorageItem> StorageItems { get; set; }
    }
}
