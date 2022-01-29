using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class LiftingCheckListTemplate : BaseEntity
    {
        public string TaskCode { get; set; }
        public string TaskDescription { get; set; }
        public int ActionDuration { get; set; }
        public timeUOM DurationUnit { get; set; }
        public string DaysFrom { get; set; }
        public int LifitngCrewId {get; set;}
        [ForeignKey("LifitngCrewId")]
        public virtual LifitngCrew LiftingCrew { get; set; }

        public int FollowupId { get; set; }
        [ForeignKey("FollowupId")]
        public virtual LifitngCrew FollowUpCrew { get; set; }
        public actionStatus Status { get; set; }
        public string Remark { get; set; }
    }
}
