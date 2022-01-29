using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LOMS.Domain.Entities
{
    public class LiftingProject : BaseEntity
    {
        public string LiftingNumber { get; set; }
        public int ExportPermitId { get; set; }
        [ForeignKey("ExportPermitId")]
        public virtual ExportPermit ExportPermit { get; set; }
        public int  VesselId { get; set; }
        [ForeignKey("VesselId")]
        public virtual Vessel Vessel { get; set; }
        public double NorminatedQuantity { get; set; }
        public  string VessleETA { get; set; }
        public  string Laycan { get; set; }
        public int ExportAgentId { get; set; }
        [ForeignKey("ExportAgentId")]
        public virtual ExportAgent ExportAgent { get; set; }
        public int IndependentInspectorId { get; set; }
        [ForeignKey("IndependentInspectorId")]
        public virtual IndependentInspector IndependentInspector { get; set; }
        public string NominationUrl { get; set; }
        public string CustomClearanceDocumentInwardUrl { get; set; }
        public string CustomClearanceDocumentOutwardUrl { get; set; }
        public string OutturnCloseOutLetterUrl { get; set; }
        public string lettersOfProtestUrl { get; set; }


    }
}
