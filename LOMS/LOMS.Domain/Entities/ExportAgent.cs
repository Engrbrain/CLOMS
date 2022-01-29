using System.Collections.Generic;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class ExportAgent : BaseEntity
    {
        public string ExportAgentName { get; set; }
        public string ContactPerson { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public country Country { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
