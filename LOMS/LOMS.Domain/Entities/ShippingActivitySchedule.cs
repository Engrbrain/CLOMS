using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class ShippingActivitySchedule : BaseEntity
    {
        public int ShippingId { get; set; }
        [ForeignKey("ShippingId")]
        public Shipping Shipping { get; set; }
      
        public string TimeStatement {get; set;}
        public string ScheduleDate { get; set; }
        public string ScheduleTime { get; set; }
        public string Comment { get; set; }
    }
}
