using System.Collections.Generic;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class ExportPermit : BaseEntity
    {
        public string RegNumber { get; set; }
        public string PermitStartDate { get; set; }
        public string PermitEndDate { get; set; }
        public string ExportPermitFileUrl { get; set; }
        public string TechnicalAllowableUrl { get; set; }
        public string RoClearanceForRoyaltyUrl { get; set; }
        public string LACTUrl { get; set; }
        public string TaxClearanceCertificateUrl { get; set; }
        public string CommercialAllowableUrl  { get; set; }
        public string ApplicationPaymentUrl { get; set; }
        public List<LiftingProject> LiftingProjects { get; set; }
    }
}
