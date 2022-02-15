using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static LOMS.Domain.Enum.managerEnum;

namespace LOMS.Domain.Entities
{
    public class Shipping : BaseEntity
    {
        public int ConsignorId { get; set; }
        [ForeignKey("ConsignorId")]
        public Consignor Consignor { get; set; }
        public int VesselId { get; set; }
        [ForeignKey("VesselId")]
        public Vessel Vessel { get; set; }

        public int AssetId { get; set; }
        [ForeignKey("AssetId")]
        public Asset Asset { get; set; }
        public int LiftingProjectId { get; set; }
        [ForeignKey("LiftingProjectId")]
        public LiftingProject LiftingProject { get; set; }

        public int DestinationId { get; set; }
        [ForeignKey("DestinationId")]
        public Destination Destination { get; set; }

        public int ConsigneeId { get; set; }
        [ForeignKey("ConsigneeId")]
        public Consignee Consignee { get; set; }

        public string CommentLine1 {get; set;}
        public string CommentLine2 { get; set; }
        public string CommentLine3 { get; set; }
        public string CommentLine4 { get; set; }
        public string CommentLine5 { get; set; }
        public string Grade { get; set; }
        public string LTONSGross { get; set; }
        public string LTONSNet { get; set; }
        public string USBBLSGross { get; set; }
        public string USBBLSNet { get; set; }
        public string SG600FGross { get; set; }
        public string SG900FNet { get; set; }
        public string FlashPLGross { get; set; }
        public string FlashPLNet { get; set; }
        public string CUMTRS150FGross { get; set; }
        public string CUMTRS150FNet { get; set; }
        public string AVTempGross { get; set; }
        public string AVTempNet { get; set; }
        public string API60FGross { get; set; }
        public string API60FNet { get; set; }
        public string MTONSGross { get; set; }
        public string MTONSNet { get; set; }
        public string CUMTRS200FGross { get; set; }
        public string CUMTRS200FNet { get; set; }
        public string DestinationPort { get; set; }

        public string ShippingDay { get; set; }
        public string ShippingMonthYear { get; set; }

        public string M315oC { get; set; }

        public int AuthorizedSignatoryId { get; set; } 
        [ForeignKey("AuthorizedSignatoryId")]
        public LifitngPersonnel LifitngPersonnel { get; set; }

        public int InspectionCompanyId { get; set; }
        [ForeignKey("InspectionCompanyId")]
        public IndependentInspector IndependentInspector { get; set; }
       public string WaterContentVol { get; set; }
        public string NumberOfSamples { get; set; }
        public string VolumeOfSamples { get; set; }
        public string MastersName { get; set; }


    }
}
