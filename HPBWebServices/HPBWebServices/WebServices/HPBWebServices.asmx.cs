using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Script.Serialization;

namespace HPBWebServices.WebServices
{
    /// <summary>
    /// Summary description for HPBWebServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HPBWebServices : System.Web.Services.WebService
    {

        //PositionModel
        //Json
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetAll_Position_Json()
        {
            IDataProvider provider = new DataDAO();
            IEnumerable<PositionModel> post = provider.GetAll_Position();

            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            return ser.Serialize(post);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_Position_ByCode_Json(string postcode)
        {
            IDataProvider provider = new DataDAO();
            IEnumerable<PositionModel> post = provider.Get_Position_ByCode(postcode);

            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            return ser.Serialize(post);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_Position_ByKeyWord_Json(string prefix)
        {
            IDataProvider provider = new DataDAO();
            IEnumerable<PositionModel> post = provider.Get_Position_ByKeyWord(prefix);

            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            return ser.Serialize(post);
        }
        //XML
        [WebMethod]
        public List<PositionModel> GetAll_Position_XML()
        {
            IDataProvider provider = new DataDAO();
            List<PositionModel> post = (List<PositionModel>)provider.GetAll_Position();

            return post;
        }
        [WebMethod]
        public List<PositionModel> Get_Position_ByCode_XML(string postcode)
        {
            IDataProvider provider = new DataDAO();
            List<PositionModel> post = (List<PositionModel>)provider.Get_Position_ByCode(postcode);

            return post;
        }
        [WebMethod]
        public List<PositionModel> Get_Position_ByKeyWord_XML(string prefix)
        {
            IDataProvider provider = new DataDAO();
            List<PositionModel> post = (List<PositionModel>)provider.Get_Position_ByKeyWord(prefix);

            return post;
        }



        //AcademicPositionModel
        //Json
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetAll_AcademicPosition_Json()
        {
            IDataProvider provider = new DataDAO();
            IEnumerable<AcademicPositionModel> aca = provider.GetAll_AcademicPosition();

            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            return ser.Serialize(aca);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_AcademicPosition_ByCode_Json(string acapost)
        {
            IDataProvider provider = new DataDAO();
            IEnumerable<AcademicPositionModel> aca = provider.Get_AcademicPosition_ByCode(acapost);

            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            return ser.Serialize(aca);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_AcademicPosition_ByKeyWord_Json(string prefix)
        {
            IDataProvider provider = new DataDAO();
            IEnumerable<AcademicPositionModel> aca = provider.Get_AcademicPosition_ByKeyWord(prefix);

            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            return ser.Serialize(aca);
        }
        //XML
        [WebMethod]
        public List<AcademicPositionModel> GetAll_AcademicPosition_XML()
        {
            IDataProvider provider = new DataDAO();
            List<AcademicPositionModel> aca = (List<AcademicPositionModel>)provider.GetAll_AcademicPosition();

            return aca;
        }
        [WebMethod]
        public List<AcademicPositionModel> Get_AcademicPosition_ByCode_XML(string acapost)
        {
            IDataProvider provider = new DataDAO();
            List<AcademicPositionModel> aca = (List<AcademicPositionModel>)provider.Get_AcademicPosition_ByCode(acapost);

            return aca;
        }
        [WebMethod]
        public List<AcademicPositionModel> Get_AcademicPosition_ByKeyWord_XML(string prefix)
        {
            IDataProvider provider = new DataDAO();
            List<AcademicPositionModel> aca = (List<AcademicPositionModel>)provider.Get_AcademicPosition_ByKeyWord(prefix);
            return aca;
        }
        


        //TitleModel
        //Json
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetAll_Title_Json()
        {
            IDataProvider provider = new DataDAO();
            IEnumerable<TitleModel> title = provider.GetAll_Title();

            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            return ser.Serialize(title);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_Title_ByCode_Json(string titlecode)
        {
            IDataProvider provider = new DataDAO();
            IEnumerable<TitleModel> title = provider.Get_Title_ByCode(titlecode);

            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            return ser.Serialize(title);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_Title_ByKeyWord_Json(string prefix)
        {
            IDataProvider provider = new DataDAO();
            IEnumerable<TitleModel> title = provider.Get_Title_ByKeyWord(prefix);

            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            return ser.Serialize(title);
        }
        //XML
        [WebMethod]
        public List<TitleModel> GetAll_Title_XML()
        {
            IDataProvider provider = new DataDAO();
            List<TitleModel> title = (List<TitleModel>)provider.GetAll_Title();

            return title;
        }
        [WebMethod]
        public List<TitleModel> Get_Title_ByCode_XML(string titlecode)
        {
            IDataProvider provider = new DataDAO();
            List<TitleModel> title = (List<TitleModel>)provider.Get_Title_ByCode(titlecode);

            return title;
        }
        [WebMethod]
        public List<TitleModel> Get_Title_ByKeyWord_XML(string prefix)
        {
            IDataProvider provider = new DataDAO();
            List<TitleModel> title = (List<TitleModel>)provider.Get_Title_ByKeyWord(prefix);

            return title;
        }



        //AcademicTitleModel
        //Json
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetAll_AcademicTitle_Json()
        {
            IDataProvider provider = new DataDAO();
            IEnumerable<AcademicTitleModel> acatitle = provider.GetAll_AcademicTitle();

            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            return ser.Serialize(acatitle);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_AcademicTitle_ByCode_Json(string acatitlecode)
        {
            IDataProvider provider = new DataDAO();
            IEnumerable<AcademicTitleModel> acatitle = provider.Get_AcademicTitle_ByCode(acatitlecode);

            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            return ser.Serialize(acatitle);
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Get_AcademicTitle_ByKeyWord_Json(string prefix)
        {
            IDataProvider provider = new DataDAO();
            IEnumerable<AcademicTitleModel> acatitle = provider.Get_AcademicTitle_ByKeyWord(prefix);

            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            return ser.Serialize(acatitle);
        }
        //XML
        [WebMethod]
        public List<AcademicTitleModel> GetAll_AcademicTitle_XML()
        {
            IDataProvider provider = new DataDAO();
            List<AcademicTitleModel> acatitle = (List<AcademicTitleModel>)provider.GetAll_AcademicTitle();

            return acatitle;
        }
        [WebMethod]
        public List<AcademicTitleModel> Get_AcademicTitle_ByCode_XML(string acatitlecode)
        {
            IDataProvider provider = new DataDAO();
            List<AcademicTitleModel> acatitle = (List<AcademicTitleModel>)provider.Get_AcademicTitle_ByCode(acatitlecode);

            return acatitle;
        }
        [WebMethod]
        public List<AcademicTitleModel> Get_AcademicTitle_ByKeyWord_XML(string prefix)
        {
            IDataProvider provider = new DataDAO();
            List<AcademicTitleModel> acatitle = (List<AcademicTitleModel>)provider.Get_AcademicTitle_ByKeyWord(prefix);

            return acatitle;
        }

        //WTE
        //Json
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetJobHistory_Json(string pEmployeeID, string pStartDate, string pEndDate)
        {
            IDataProvider provider = new DataDAO();
            IEnumerable<JobHistoryModel> jobHist = provider.GetJobHistory(pEmployeeID, pStartDate, pEndDate);

            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = Int32.MaxValue;
            return ser.Serialize(jobHist);
        }
        //XML
        [WebMethod]
        public List<JobHistoryModel> GetJobHistory_XML(string pEmployeeID, string pStartDate, string pEndDate)
        {
            IDataProvider provider = new DataDAO();
            List<JobHistoryModel> jobHist = (List<JobHistoryModel>)provider.GetJobHistory(pEmployeeID, pStartDate, pEndDate);

            return jobHist;
        }
    }
}
