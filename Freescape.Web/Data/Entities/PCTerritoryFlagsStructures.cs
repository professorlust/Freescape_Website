﻿using System;
using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class PcterritoryFlagsStructures
    {
        public PcterritoryFlagsStructures()
        {
            PcterritoryFlagsStructuresItems = new HashSet<PcterritoryFlagsStructuresItems>();
            StructureQuickBuildAudit = new HashSet<StructureQuickBuildAudit>();
        }

        public long PcterritoryFlagStructureId { get; set; }
        public int PcterritoryFlagId { get; set; }
        public int StructureBlueprintId { get; set; }
        public bool IsUseable { get; set; }
        public string LocationAreaTag { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }
        public DateTime CreateDate { get; set; }
        public string CustomName { get; set; }

        public PcterritoryFlags PcterritoryFlag { get; set; }
        public StructureBlueprints StructureBlueprint { get; set; }
        public ICollection<PcterritoryFlagsStructuresItems> PcterritoryFlagsStructuresItems { get; set; }
        public ICollection<StructureQuickBuildAudit> StructureQuickBuildAudit { get; set; }
    }
}
