using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HPBWebServices.WebServices
{
    interface IDataProvider
    {
        //GetAll
        IList<PositionModel> GetAll_Position();
        IList<AcademicPositionModel> GetAll_AcademicPosition();
        IList<TitleModel> GetAll_Title();
        IList<AcademicTitleModel> GetAll_AcademicTitle();

        //GetByCode
        IList<PositionModel> Get_Position_ByCode(string positioncode);
        IList<AcademicPositionModel> Get_AcademicPosition_ByCode(string acapostcode);
        IList<TitleModel> Get_Title_ByCode(string titlecode);
        IList<AcademicTitleModel> Get_AcademicTitle_ByCode(string acatitlecode);

        //GetByKeyWord
        IList<PositionModel> Get_Position_ByKeyWord(string prefix);
        IList<AcademicPositionModel> Get_AcademicPosition_ByKeyWord(string prefix);
        IList<TitleModel> Get_Title_ByKeyWord(string prefix);
        IList<AcademicTitleModel> Get_AcademicTitle_ByKeyWord(string prefix);

        //WTE
        IEnumerable<JobHistoryModel> GetJobHistory(string EmployeeID, string StartDate, string EndDate);
    }
}
