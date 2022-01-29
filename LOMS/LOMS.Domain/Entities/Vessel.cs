using System.Collections.Generic;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class Vessel : BaseEntity
    {
        public string VesselName { get; set; }
        public string VesselReferenceID { get; set; }
        public string SummerDeadWeight { get; set; }
        public string Flag { get; set; }
        public string PortOfRegistry { get; set; }
        public string CallSign { get; set; }
    }
}
