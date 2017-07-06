using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace HPBWebServices.WebServices
{
    public class AcademicPositionModel
    {
        public string AcademicPositionCode { get; set; }
        public string AcademicPositionTh { get; set; }
        public string AcademicPositionEng { get; set; }

        public AcademicPositionModel() { }
        public AcademicPositionModel
            (
                string academicpositioncode,
                string academicpositionth,
                string academicpositioneng
            )
        {
            AcademicPositionCode = academicpositioncode;
            AcademicPositionTh = academicpositionth;
            AcademicPositionEng = academicpositioneng;
        }
    }
}
