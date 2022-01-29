using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class FlightSchedule : BaseEntity
    {
        public int LifitngPersonnelId { get; set; }
        [ForeignKey("LifitngPersonnelId")]
        public LifitngPersonnel LifitngPersonnel { get; set; }
        public string Departing { get; set; }
        public string Arriving { get; set; }
        public string FlightDate { get; set; }
        public string FlightTime { get; set; }
        public int LiftingProjectId { get; set; }
        [ForeignKey("LiftingProjectId")]
        public LiftingProject LiftingProject { get; set; }
        public flightStatus FlightStatus { get; set; }
    }
}
