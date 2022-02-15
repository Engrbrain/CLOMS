using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class OutturnMaster : BaseEntity
    {
        public string ParameterName { get; set; }
        public string ParameterDescription { get; set; }
        public parameterUOM ParamterUOM { get; set; }
    }
}
