using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class LifitngPersonnel : BaseEntity
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public double Weight { get; set; }
        public weightUOM WeightUOM { get; set; }
        public string BloodPressure { get; set; }
        public bloodPressureUOM BloodPressureUOM { get; set; }
        public bool is_AuthorizedSignature { get; set; }
        public int LifitngCrewId { get; set; }
        [ForeignKey("LifitngCrewId")]
        public LifitngCrew LifitngCrew { get; set; }
        public int LiftingProjectId { get; set; }
        [ForeignKey("LiftingProjectId")]
        public LiftingProject LiftingProject { get; set; }
    }
}
