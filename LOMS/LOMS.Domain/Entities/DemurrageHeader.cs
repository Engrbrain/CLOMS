using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class DemurrageHeader : BaseEntity
    {
        public int LiftingProjectId { get; set; }
        [ForeignKey("LiftingProjectId")]
        public LiftingProject LiftingProject { get; set; }
        public calculationApproach calculationApproach { get; set; }
       
    }
}
