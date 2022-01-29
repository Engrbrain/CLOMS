using System.Collections.Generic;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class Destination : BaseEntity
    {
        public string DestinationName { get; set; }
        public string FullAddress { get; set; }
    }
}
