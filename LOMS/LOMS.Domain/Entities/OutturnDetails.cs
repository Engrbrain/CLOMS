using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class OutturnDetails : BaseEntity
    {
        public int OutturnId { get; set; }
        [ForeignKey("OutturnId")]
        public Outturn Outturn { get; set; }
        public int OutturnMasterId { get; set; }
        [ForeignKey("OutturnMasterId")]
        public OutturnMaster OutturnMaster { get; set; }
        public float ParameterValue { get; set; }
    }
}
