using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOMS.Domain.Enum
{
    class managerEnum
    {
        public enum country
        {
            Nigeria
        }

        public enum month
        {
            Januray,
            Febraury
        }

        public enum timeUOM
        {
            Hours,
            Days
        }
        
            public enum actionStatus
        {
            Hours,
            Days
        }
        

              public enum weightUOM
        {
            Kg,
            lbs
        }

        public enum bloodPressureUOM
        {
            Kg,
            lbs
        }

        
            public enum flightStatus
        {
            Kg,
            lbs
        }
        
               public enum calculationApproach
        {
            Kg
            lbs
        }
        public enum parameterUOM
        {
            bbls,
            %Vol
        }

        public enum freeWaterMeasurementMethod
        {
            UTI,
            Paste,
            AnalyzeBothChooseUTI,
            AnalyzeBothChoosePaste,
            AnalyzeBothChooseAverage,

        }
    }
}
