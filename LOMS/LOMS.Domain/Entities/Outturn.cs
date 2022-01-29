using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class Outturn : BaseEntity
    {
        public string OutturnName { get; set; }
        public freeWaterMeasurementMethod FreeWaterMeasurementMethod { get; set; }
        public string Function { get; set; }
        public string CrewCode { get; set; }
        public int NumberOfPersonnel { get; set; }
        public int LiftingProjectId { get; set; }
        [ForeignKey("LiftingProjectId")]
        public LiftingProject LiftingProject { get; set; }
    }
}
