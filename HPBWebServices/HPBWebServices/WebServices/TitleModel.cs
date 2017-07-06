using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
namespace HPBWebServices.WebServices
{
    public class TitleModel
    {
        public string TitleCode { get; set; }
        public string TitleTh { get; set; }
        public string TitleEng { get; set; }
        public string TitleShortTh { get; set; }
        public string TitleShortEng { get; set; }

        public TitleModel() { }
        public TitleModel
            (
                string titlecode,
                string titleth,
                string titleeng,
                string titleshortth,
                string titleshorteng
            )
        {
            TitleCode = titlecode;
            TitleTh = titleth;
            TitleEng = titleeng;
            TitleShortTh = titleshortth;
            TitleShortEng = titleshorteng;
        }
    }
}
