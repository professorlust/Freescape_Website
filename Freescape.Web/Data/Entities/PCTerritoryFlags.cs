﻿using System.Collections.Generic;

namespace Freescape.Web.Data.Entities
{
    public partial class PcterritoryFlags
    {
        public PcterritoryFlags()
        {
            ConstructionSites = new HashSet<ConstructionSites>();
            PcterritoryFlagsPermissions = new HashSet<PcterritoryFlagsPermissions>();
            PcterritoryFlagsStructures = new HashSet<PcterritoryFlagsStructures>();
            StructureQuickBuildAudit = new HashSet<StructureQuickBuildAudit>();
        }

        public int PcterritoryFlagId { get; set; }
        public string PlayerId { get; set; }
        public int StructureBlueprintId { get; set; }
        public string LocationAreaTag { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }
        public int BuildPrivacySettingId { get; set; }

        public BuildPrivacyDomain BuildPrivacySetting { get; set; }
        public PlayerCharacters Player { get; set; }
        public StructureBlueprints StructureBlueprint { get; set; }
        public ICollection<ConstructionSites> ConstructionSites { get; set; }
        public ICollection<PcterritoryFlagsPermissions> PcterritoryFlagsPermissions { get; set; }
        public ICollection<PcterritoryFlagsStructures> PcterritoryFlagsStructures { get; set; }
        public ICollection<StructureQuickBuildAudit> StructureQuickBuildAudit { get; set; }
    }
}
