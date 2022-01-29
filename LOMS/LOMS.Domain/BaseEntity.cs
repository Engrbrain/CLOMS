using LOMS.Domain.Auth;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOMS.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public bool isDeleted { get; set; }
        public bool isActive { get; set; }
        public bool isModified { get; set; }
        public string createdBy { get; set; }
        [ForeignKey("createdBy")]
        public ApplicationUser created { get; set; }

        public string modifiedBy { get; set; }
        [ForeignKey("modifiedBy")]
        public ApplicationUser modified { get; set; }
        public DateTime CreatedOn { get; set; } 
        public DateTime ModifiedOn { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
