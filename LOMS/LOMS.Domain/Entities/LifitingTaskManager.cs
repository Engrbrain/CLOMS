using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class LifitingTaskManager : BaseEntity
    {
        public int LiftingCheckListTemplateId { get; set; }
        [ForeignKey("LiftingCheckListTemplate")]
        public virtual LiftingCheckListTemplate LiftingCheckListTemplate { get; set;}

        public  DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LifitngCrewId { get; set; }
        [ForeignKey("LifitngCrewId")]
        public virtual LifitngCrew LiftingCrew { get; set; }

        public int FollowupId { get; set; }
        [ForeignKey("FollowupId")]
        public virtual LifitngCrew FollowUpCrew { get; set; }

        public int LiftingProjectId { get; set; }
        [ForeignKey("LiftingProjectId")]
        public virtual LiftingProject LiftingProject { get; set; }
        public actionStatus Status { get; set; }
        public DateTime DateClosed { get; set; }
        public string Remark { get; set; }
    }
}
