using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class LifitngCrew : BaseEntity
    {
        public string Position { get; set; }
        public string Company { get; set; }
        public string Function { get; set; }
        public string CrewCode { get; set; }
        public int NumberOfPersonnel { get; set; }
        public int LiftingProjectId { get; set; }
        [ForeignKey("LiftingProjectId")]
        public LiftingProject LiftingProject { get; set; }
    }
}
