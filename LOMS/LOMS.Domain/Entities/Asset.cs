using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class Asset : BaseEntity
    {
        public string AssetName { get; set; }
        public string AssetLocation { get; set; }
        public int ConsignorId  { get; set; }
        [ForeignKey("ConsignorId")]
        public virtual Consignor Consignor { get; set; }
        public string Cargo { get; set; }
    }
}
