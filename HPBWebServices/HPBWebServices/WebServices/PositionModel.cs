using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;


namespace HPBWebServices.WebServices
{
    public class PositionModel
    {
        public string PositionCode { get; set; }
        public string PositionTh { get; set; }
        public string PositionEng { get; set; }

        public PositionModel() { }
        public PositionModel
            (
                string positionCode,
                string positionTh,
                string positionEng
            )
        {
            PositionCode = positionCode;
            PositionTh = positionTh;
            PositionEng = positionEng;
        }
    }
}
