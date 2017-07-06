using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace HPBWebServices.WebServices
{
    public class JobHistoryModel
    {
        public string EMPLOYEE_ID { get; set; }
        public string FIRSTNAME_TH { get; set; }
        public string LASTNAME_TH { get; set; }
        public DateTime START_DATE { get; set; }
        public DateTime END_DATE { get; set; }
        public string TYPE_CODE { get; set; }
        public string GROUP_CODE { get; set; }
        public string DEPARTMENT_ID { get; set; }

        public JobHistoryModel() { }
        public JobHistoryModel
            (
                string employeeid,
                string firstnameth,
                string lastnameth,
                DateTime startdate,
                DateTime enddate,
                string employeetypecode,
                string employeegroupcode,
                string departmentcode
            )
        {
            EMPLOYEE_ID = employeeid;
            FIRSTNAME_TH = firstnameth;
            LASTNAME_TH = lastnameth;
            START_DATE = startdate;
            END_DATE = enddate;
            TYPE_CODE = employeetypecode;
            GROUP_CODE = employeegroupcode;
            DEPARTMENT_ID = departmentcode;
        }
    }
}
