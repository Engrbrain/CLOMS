using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class Outturn : BaseEntity
    {
        public string OutturnName { get; set; }
        public string UltimateBuyer { get; set; }
        public DateTime BOLDate { get; set; }
        public string primaryDestination { get; set; }
        public int LiftingProjectId { get; set; }
        [ForeignKey("LiftingProjectId")]
        public LiftingProject LiftingProject { get; set; }
    }
}
