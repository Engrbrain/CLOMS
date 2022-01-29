using System.Collections.Generic;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class CultailmentProgram : BaseEntity
    {
        public month Month { get; set; }
        public string CultailmentProgramUrl { get; set; }
    }
}
