using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace HPBWebServices.WebServices
{
    public class AcademicTitleModel
    {
        public string AcademicTitleCode { get; set; }
        public string AcademicTitleTh { get; set; }
        public string AcademicTitleEng { get; set; }
        public string AcademicTitleShortTh { get; set; }
        public string AcademicTitleShortEng { get; set; }

        public AcademicTitleModel() { }
        public AcademicTitleModel
            (
                string academictitlecode,
                string academictitleth,
                string academictitleeng,
                string academictitleshortth,
                string academictitleshorteng
            )
        {
            AcademicTitleCode = academictitlecode;
            AcademicTitleTh = academictitleth;
            AcademicTitleEng = academictitleeng;
            AcademicTitleShortTh = academictitleshortth;
            AcademicTitleShortEng = academictitleshorteng;
        }
    }
}
