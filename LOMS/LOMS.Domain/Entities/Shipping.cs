using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class Shipping : BaseEntity
    {
        public int ConsignorId { get; set; }
        [ForeignKey("ConsignorId")]
        public Consignor Consignor { get; set; }
        public int VesselId { get; set; }
        [ForeignKey("VesselId")]
        public Vessel Vessel { get; set; }

        public int AssetId { get; set; }
        [ForeignKey("AssetId")]
        public Asset Asset { get; set; }
        public int LiftingProjectId { get; set;}
        [ForeignKey("LiftingProjectId")]
        public LiftingProject LiftingProject { get; set; }


Comment line 1
Comment line 2
Comment line 3
Comment line 4
Comment line 5
Grade
L/TONS GROSS
L/TONS NET
US Bbls GROSS
US Bbls NET
S.G @600F GROSS
S.G @600F NET
FLASH PL GROSS
CU MTRS @150F GROSS
CU MTRS @150F NET
AV. Temp Gross
Av.Temp Net

        [ForeignKey("LiftingProjectId")]
        public LiftingProject LiftingProject { get; set; }
    }
}
