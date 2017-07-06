using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Globalization;

namespace HPBWebServices.WebServices
{
    public class DataDAO : IDataProvider 
    {
        private string m_ConnString = "";

        public DataDAO()
        {
            m_ConnString = "Provider=OraOLEDB.Oracle;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=hostName)(PORT=1521))(CONNECT_DATA=(SID=kmis)(SERVER=DEDICATED)));User Id=userName;Password=Password";
        }

        #region IDataProvider Members

        //GetAll
        public IList<PositionModel> GetAll_Position()
        {
            using (OleDbConnection conn = new OleDbConnection(m_ConnString))
            {
                string query = "select PositionCode, PositionTh, PositionEng " +
                            "from HPB.tblPosition " +
                            "where Status = 0";

                conn.Open();

                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        try
                        {
                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                List<PositionModel> postList = new List<PositionModel>();
                                PositionModel post = null;
                                while (reader.Read())
                                {
                                    post = new PositionModel();
                                    post.PositionCode = reader["PositionCode"].ToString();
                                    post.PositionTh = reader["PositionTh"].ToString();
                                    post.PositionEng = (reader["PositionEng"] == DBNull.Value ? "" : reader["PositionEng"].ToString());

                                    postList.Add(post);
                                }
                                while (reader.NextResult()) ;
                                return postList;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public IList<AcademicPositionModel> GetAll_AcademicPosition()
        {
            using (OleDbConnection conn = new OleDbConnection(m_ConnString))
            {
                string query = "select AcademicPositionCode, AcademicPositionTh, AcademicPositionEng " +
                            "from HPB.tblAcademicPosition " +
                            "where Status = 0";

                conn.Open();

                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        try
                        {
                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                List<AcademicPositionModel> acaList = new List<AcademicPositionModel>();
                                AcademicPositionModel aca = null;
                                while (reader.Read())
                                {
                                    aca = new AcademicPositionModel();
                                    aca.AcademicPositionCode = reader["AcademicPositionCode"].ToString();
                                    aca.AcademicPositionTh = reader["AcademicPositionTh"].ToString();
                                    aca.AcademicPositionEng = (reader["AcademicPositionEng"] == DBNull.Value ? "" : reader["AcademicPositionEng"].ToString());

                                    acaList.Add(aca);
                                }
                                while (reader.NextResult()) ;
                                return acaList;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public IList<TitleModel> GetAll_Title()
        {
            using (OleDbConnection conn = new OleDbConnection(m_ConnString))
            {
                string query = "select TitleCode, TitleTh, TitleEng, TitleShortTh, TitleShortEng " +
                            "from HPB.tblTitle " +
                            "where Status = 0 and AcademicPositionCode is null";

                conn.Open();

                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        try
                        {
                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                List<TitleModel> titleList = new List<TitleModel>();
                                TitleModel title = null;
                                while (reader.Read())
                                {
                                    title = new TitleModel();
                                    title.TitleCode = reader["TitleCode"].ToString();
                                    title.TitleTh = (reader["TitleTh"] == DBNull.Value ? "" : reader["TitleTh"].ToString());
                                    title.TitleEng = (reader["TitleEng"] == DBNull.Value ? "" : reader["TitleEng"].ToString());
                                    title.TitleShortTh = (reader["TitleShortTh"] == DBNull.Value ? "" : reader["TitleShortTh"].ToString());
                                    title.TitleShortEng = (reader["TitleShortEng"] == DBNull.Value ? "" : reader["TitleShortEng"].ToString());

                                    titleList.Add(title);
                                }
                                while (reader.NextResult()) ;
                                return titleList;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public IList<AcademicTitleModel> GetAll_AcademicTitle()
        {
            using (OleDbConnection conn = new OleDbConnection(m_ConnString))
            {
                string query = "select TitleCode, TitleTh, TitleEng, TitleShortTh, TitleShortEng " +
                            "from HPB.tblTitle " +
                            "where Status = 0 and AcademicPositionCode is not null";

                conn.Open();

                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        try
                        {
                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                List<AcademicTitleModel> acatitleList = new List<AcademicTitleModel>();
                                AcademicTitleModel acatitle = null;
                                while (reader.Read())
                                {
                                    acatitle = new AcademicTitleModel();
                                    acatitle.AcademicTitleCode = reader["TitleCode"].ToString();
                                    acatitle.AcademicTitleTh = (reader["TitleTh"] == DBNull.Value ? "" : reader["TitleTh"].ToString());
                                    acatitle.AcademicTitleEng = (reader["TitleEng"] == DBNull.Value ? "" : reader["TitleEng"].ToString());
                                    acatitle.AcademicTitleShortTh = (reader["TitleShortTh"] == DBNull.Value ? "" : reader["TitleShortTh"].ToString());
                                    acatitle.AcademicTitleShortEng = (reader["TitleShortEng"] == DBNull.Value ? "" : reader["TitleShortEng"].ToString());

                                    acatitleList.Add(acatitle);
                                }
                                while (reader.NextResult()) ;
                                return acatitleList;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        
        //GetByCode
        public IList<PositionModel> Get_Position_ByCode(string positioncode)
        {
            using (OleDbConnection conn = new OleDbConnection(m_ConnString))
            {
                string query = "select PositionCode, PositionTh, PositionEng " +
                            "from  HPB.tblPosition " +
                            "where Status = 0 and PositionCode = :PostCode";

                conn.Open();
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        try
                        {
                            cmd.Parameters.Add(new OleDbParameter(":PostCode", OleDbType.VarChar, 5));
                            cmd.Parameters[":PostCode"].Value = positioncode.Trim();

                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                List<PositionModel> postList = new List<PositionModel>();
                                PositionModel post = null;
                                while (reader.Read())
                                {
                                    post = new PositionModel();
                                    post.PositionCode = reader["PositionCode"].ToString();
                                    post.PositionTh = (reader["PositionTh"] == DBNull.Value ? "" : reader["PositionTh"].ToString());
                                    post.PositionEng = (reader["PositionEng"] == DBNull.Value ? "" : reader["PositionEng"].ToString());

                                    postList.Add(post);
                                }
                                while (reader.NextResult()) ;
                                return postList;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public IList<AcademicPositionModel> Get_AcademicPosition_ByCode(string acapostcode)
        {
            using (OleDbConnection conn = new OleDbConnection(m_ConnString))
            {
                string query = "select AcademicPositionCode, AcademicPositionTh, AcademicPositionEng " +
                            "from  HPB.tblAcademicPosition " +
                            "where Status = 0 and AcademicPositionCode = :AcaPostCode";

                conn.Open();
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        try
                        {
                            cmd.Parameters.Add(new OleDbParameter(":AcaPostCode", OleDbType.VarChar, 5));
                            cmd.Parameters[":AcaPostCode"].Value = acapostcode.Trim();

                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                List<AcademicPositionModel> acaList = new List<AcademicPositionModel>();
                                AcademicPositionModel aca = null;
                                while (reader.Read())
                                {
                                    aca = new AcademicPositionModel();
                                    aca.AcademicPositionCode = reader["AcademicPositionCode"].ToString();
                                    aca.AcademicPositionTh = (reader["AcademicPositionTh"] == DBNull.Value ? "" : reader["AcademicPositionTh"].ToString());
                                    aca.AcademicPositionEng = (reader["AcademicPositionEng"] == DBNull.Value ? "" : reader["AcademicPositionEng"].ToString());

                                    acaList.Add(aca);
                                }
                                while (reader.NextResult()) ;
                                return acaList;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public IList<TitleModel> Get_Title_ByCode(string titlecode)
        {
            using (OleDbConnection conn = new OleDbConnection(m_ConnString))
            {
                string query = "select TitleCode, TitleTh, TitleEng, TitleShortTh, TitleShortEng " +
                            "from HPB.tblTitle " +
                            "where Status = 0 and AcademicPositionCode is null and TitleCode = :TitleCode";

                conn.Open();
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        try
                        {
                            cmd.Parameters.Add(new OleDbParameter(":TitleCode", OleDbType.VarChar, 5));
                            cmd.Parameters[":TitleCode"].Value = titlecode.Trim();
                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                List<TitleModel> titleList = new List<TitleModel>();
                                TitleModel title = null;
                                while (reader.Read())
                                {
                                    title = new TitleModel();
                                    title.TitleCode = reader["TitleCode"].ToString();
                                    title.TitleTh = (reader["TitleTh"] == DBNull.Value ? "" : reader["TitleTh"].ToString());
                                    title.TitleEng = (reader["TitleEng"] == DBNull.Value ? "" : reader["TitleEng"].ToString());
                                    title.TitleShortTh = (reader["TitleShortTh"] == DBNull.Value ? "" : reader["TitleShortTh"].ToString());
                                    title.TitleShortEng = (reader["TitleShortEng"] == DBNull.Value ? "" : reader["TitleShortEng"].ToString());

                                    titleList.Add(title);
                                }
                                while (reader.NextResult()) ;
                                return titleList;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public IList<AcademicTitleModel> Get_AcademicTitle_ByCode(string acatitlecode)
        {
            using (OleDbConnection conn = new OleDbConnection(m_ConnString))
            {
                string query = "select TitleCode, TitleTh, TitleEng, TitleShortTh, TitleShortEng " +
                            "from HPB.tblTitle " +
                            "where Status = 0 and AcademicPositionCode is not null and TitleCode = :AcaTitleCode";

                conn.Open();
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        try
                        {
                            cmd.Parameters.Add(new OleDbParameter(":AcaTitleCode", OleDbType.VarChar, 5));
                            cmd.Parameters[":AcaTitleCode"].Value = acatitlecode.Trim();
                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                List<AcademicTitleModel> acatitleList = new List<AcademicTitleModel>();
                                AcademicTitleModel acatitle = null;
                                while (reader.Read())
                                {
                                    acatitle = new AcademicTitleModel();
                                    acatitle.AcademicTitleCode = reader["TitleCode"].ToString();
                                    acatitle.AcademicTitleTh = (reader["TitleTh"] == DBNull.Value ? "" : reader["TitleTh"].ToString());
                                    acatitle.AcademicTitleEng = (reader["TitleEng"] == DBNull.Value ? "" : reader["TitleEng"].ToString());
                                    acatitle.AcademicTitleShortTh = (reader["TitleShortTh"] == DBNull.Value ? "" : reader["TitleShortTh"].ToString());
                                    acatitle.AcademicTitleShortEng = (reader["TitleShortEng"] == DBNull.Value ? "" : reader["TitleShortEng"].ToString());

                                    acatitleList.Add(acatitle);
                                }
                                while (reader.NextResult()) ;
                                return acatitleList;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        //GetByKeyWord
        public IList<PositionModel> Get_Position_ByKeyWord(string prefix)
        {
            using(OleDbConnection conn = new OleDbConnection(m_ConnString))
            {
                string query = "select PositionCode, PositionTh, PositionEng " +
                            "from HPB.tblPosition " +
                            "where Status = 0 and trim(PositionTh) like :pPostTh " +
                            "union all " +
                            "select PositionCode, PositionTh, PositionEng " +
                            "from HPB.tblPosition " +
                            "where Status = 0 and Trim(PositionEng) like :pPostEng";

                conn.Open();
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        try
                        {
                            cmd.Parameters.Add(new OleDbParameter(":pPostTh", OleDbType.VarChar, 150));
                            cmd.Parameters.Add(new OleDbParameter(":pPostEng", OleDbType.VarChar, 150));
                            cmd.Parameters[":pPostTh"].Value = String.Format("%{0}{1}", Helper.RemoveWhiteSpace(prefix.Trim()), "%");
                            cmd.Parameters[":pPostEng"].Value = String.Format("%{0}{1}", Helper.RemoveWhiteSpace(prefix.Trim()), "%");

                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                List<PositionModel> postList = new List<PositionModel>();
                                PositionModel post = null;
                                while (reader.Read())
                                {
                                    post = new PositionModel();
                                    post.PositionCode = reader["PositionCode"].ToString();
                                    post.PositionTh = (reader["PositionTh"] == DBNull.Value ? "" : reader["PositionTh"].ToString());
                                    post.PositionEng = (reader["PositionEng"] == DBNull.Value ? "" : reader["PositionEng"].ToString());

                                    postList.Add(post);
                                }
                                while(reader.NextResult());
                                return postList;
                            }
                        }
                        catch(Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }
        public IList<AcademicPositionModel> Get_AcademicPosition_ByKeyWord(string prefix)
        {
            using(OleDbConnection conn = new OleDbConnection(m_ConnString))
            {
                string query = "select AcademicPositionCode, AcademicPositionTh, AcademicPositionEng " +
                            "from HPB.tblAcademicPosition " +
                            "where Status = 0 and trim(AcademicPositionTh) like :pAcaTh " +
                            "union all " +
                            "select AcademicPositionCode, AcademicPositionTh, AcademicPositionEng " +
                            "from HPB.tblAcademicPosition " +
                            "where Status = 0 and trim(AcademicPositionEng) like :pAcaEng";

                conn.Open();
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        try
                        {
                            cmd.Parameters.Add(new OleDbParameter(":pAcaTh", OleDbType.VarChar, 150));
                            cmd.Parameters.Add(new OleDbParameter(":pAcaEng", OleDbType.VarChar, 150));
                            cmd.Parameters[":pAcaTh"].Value = String.Format("%{0}{1}", Helper.RemoveWhiteSpace(prefix.Trim()), "%");
                            cmd.Parameters[":pAcaEng"].Value = String.Format("%{0}{1}", Helper.RemoveWhiteSpace(prefix.Trim()), "%");

                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                List<AcademicPositionModel> acaList = new List<AcademicPositionModel>();
                                AcademicPositionModel aca = null;
                                while (reader.Read())
                                {
                                    aca = new AcademicPositionModel();
                                    aca.AcademicPositionCode = reader["AcademicPositionCode"].ToString();
                                    aca.AcademicPositionTh = (reader["AcademicPositionTh"] == DBNull.Value ? "" : reader["AcademicPositionTh"].ToString());
                                    aca.AcademicPositionEng = (reader["AcademicPositionEng"] == DBNull.Value ? "" : reader["AcademicPositionEng"].ToString());

                                    acaList.Add(aca);
                                }
                                while(reader.NextResult());
                                return acaList;
                            }
                        }
                        catch(Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }
        public IList<TitleModel> Get_Title_ByKeyWord(string prefix)
        {
            using (OleDbConnection conn = new OleDbConnection(m_ConnString))
            {
                string query = "select TitleCode, TitleTh, TitleEng, TitleShortTh, TitleShortEng " +
                            "from HPB.tblTitle " +
                            "where Status = 0 and AcademicPositionCode is null and trim(TitleTh) like :pTitleTh " +
                            "union all " +
                            "select TitleCode, TitleTh, TitleEng, TitleShortTh, TitleShortEng " +
                            "from HPB.tblTitle " +
                            "where Status = 0 and AcademicPositionCode is null and trim(TitleEng) like :pTitleEng";

                conn.Open();
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        try
                        {
                            cmd.Parameters.Add(new OleDbParameter(":pTitleTh", OleDbType.VarChar, 150));
                            cmd.Parameters.Add(new OleDbParameter(":pTitleEng", OleDbType.VarChar, 150));
                            cmd.Parameters[":pTitleTh"].Value = String.Format("%{0}{1}", Helper.RemoveWhiteSpace(prefix.Trim()), "%");
                            cmd.Parameters[":pTitleEng"].Value = String.Format("%{0}{1}", Helper.RemoveWhiteSpace(prefix.Trim()), "%");

                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                List<TitleModel> titleList = new List<TitleModel>();
                                TitleModel title = null;
                                while (reader.Read())
                                {
                                    title = new TitleModel();
                                    title.TitleCode = reader["TitleCode"].ToString();
                                    title.TitleTh = (reader["TitleTh"] == DBNull.Value ? "" : reader["TitleTh"].ToString());
                                    title.TitleEng = (reader["TitleEng"] == DBNull.Value ? "" : reader["TitleEng"].ToString());
                                    title.TitleShortTh = (reader["TitleShortTh"] == DBNull.Value ? "" : reader["TitleShortTh"].ToString());
                                    title.TitleShortEng = (reader["TitleShortEng"] == DBNull.Value ? "" : reader["TitleShortEng"].ToString());

                                    titleList.Add(title);
                                }
                                while (reader.NextResult()) ;
                                return titleList ;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public IList<AcademicTitleModel> Get_AcademicTitle_ByKeyWord(string prefix)
        {
            using (OleDbConnection conn = new OleDbConnection(m_ConnString))
            {
                string query = "select TitleCode, TitleTh, TitleEng, TitleShortTh, TitleShortEng " +
                            "from HPB.tblTitle " +
                            "where Status = 0 and AcademicPositionCode is not null and trim(TitleTh) like :pAcaTitleTh " +
                            "union all " +
                            "select TitleCode, TitleTh, TitleEng, TitleShortTh, TitleShortEng " +
                            "from HPB.tblTitle " +
                            "where Status = 0 and AcademicPositionCode is not null and trim(TitleEng) like :pAcaTitleEng";

                conn.Open();
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        try
                        {
                            cmd.Parameters.Add(new OleDbParameter(":pAcaTitleTh", OleDbType.VarChar, 150));
                            cmd.Parameters.Add(new OleDbParameter(":pAcaTitleEng", OleDbType.VarChar, 150));
                            cmd.Parameters[":pAcaTitleTh"].Value = String.Format("%{0}{1}", Helper.RemoveWhiteSpace(prefix.Trim()), "%");
                            cmd.Parameters[":pAcaTitleEng"].Value = String.Format("%{0}{1}", Helper.RemoveWhiteSpace(prefix.Trim()), "%");

                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                List<AcademicTitleModel> acaTitleList = new List<AcademicTitleModel>();
                                AcademicTitleModel acaTitle = null;
                                while (reader.Read())
                                {
                                    acaTitle = new AcademicTitleModel();
                                    acaTitle.AcademicTitleCode = reader["TitleCode"].ToString();
                                    acaTitle.AcademicTitleTh = (reader["TitleTh"] == DBNull.Value ? "" : reader["TitleTh"].ToString());
                                    acaTitle.AcademicTitleEng = (reader["TitleEng"] == DBNull.Value ? "" : reader["TitleEng"].ToString());
                                    acaTitle.AcademicTitleShortTh = (reader["TitleShortTh"] == DBNull.Value ? "" : reader["TitleShortTh"].ToString());
                                    acaTitle.AcademicTitleShortEng = (reader["TitleShortEng"] == DBNull.Value ? "" : reader["TitleShortEng"].ToString());

                                    acaTitleList.Add(acaTitle);
                                }
                                while (reader.NextResult()) ;
                                return acaTitleList;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        //WTE
        public IEnumerable<JobHistoryModel> GetJobHistory(string EmployeeID, string StartDate, string EndDate) 
        {
            using (OleDbConnection conn = new OleDbConnection(m_ConnString))
            {
                string query = "with PositionHistory as " +
                               "(select EmployeeID, EmployeeTypeCode, EmployeeGroupCode, DepartmentCode, EffectiveDate as StartDate, " +
                               "Lead(EffectiveDate, 1) over (partition by EmployeeID order by EffectiveDate nulls last) - 1 as EndDate " +
                               "from ( " +
                               "select EmployeeID, EmployeeTypeCode, EmployeeGroupCode, DepartmentCode, min(EffectiveDate) as EffectiveDate " +
                               "from HPB.tblPositionandSalaryMov " +
                               "left outer join HPB.tblEmployeeLine  on HPB.tblPositionandSalaryMov.EmployeeLineCode = HPB.tblEmployeeLine.EmployeeLineCode " +
                               "where tblPositionandSalaryMov.Status = 0 " +
                               "group by EmployeeID, EmployeeTypeCode, EmployeeGroupCode, DepartmentCode)) " +
                               "select EmployeeID, FirstNameTh, LastNameTh, StartDate, case when StartDate > EndDate then StartDate else EndDate end as EndDate, " +
                               "EmployeeTypeCode, EmployeeGroupCode, DepartmentCode " +
                               "from (select PositionHistory.EmployeeID, FirstNameTh, LastNameTh, EmployeeTypeCode, EmployeeGroupCode, DepartmentCode, StartDate, " +
                               "decode(EndDate, '', QuitedDate, EndDate) as EndDate " +
                               "from PositionHistory " +
                               "inner join (select EmployeeID, FirstNameTh, LastNameTh, QuitedDate from APMViewCurrentEmployeePosition) P2 " +
                               "on PositionHistory.EmployeeID = P2.EmployeeID) " +
                               "where EmployeeID = :pEmpID and StartDate <= to_date(:pStartDate,'DD/MM/YYYY') - numtoyminterval(543,'year') " +
                               "and (EndDate >= to_date(:pEndDate,'DD/MM/YYYY') - numtoyminterval(543,'year') or EndDate is null)";
                conn.Open();
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        try
                        {
                            cmd.Parameters.Add(new OleDbParameter(":pEmpID", OleDbType.VarChar, 7));
                            cmd.Parameters.Add(new OleDbParameter(":pStartDate", OleDbType.VarChar, 10));
                            cmd.Parameters.Add(new OleDbParameter(":pEndDate", OleDbType.VarChar, 10));

                            cmd.Parameters[":pEmpID"].Value = EmployeeID;
                            cmd.Parameters[":pStartDate"].Value = StartDate;
                            cmd.Parameters[":pEndDate"].Value = EndDate;

                            using (OleDbDataReader reader = cmd.ExecuteReader())
                            {
                                List<JobHistoryModel> jobList = new List<JobHistoryModel>();
                                JobHistoryModel job = null;
                                while (reader.Read())
                                {
                                    job = new JobHistoryModel();
                                    job.EMPLOYEE_ID = (reader["EmployeeID"] == DBNull.Value ? "" : reader["EmployeeID"].ToString());
                                    job.FIRSTNAME_TH = (reader["FirstNameTh"] == DBNull.Value ? "" : reader["FirstNameTh"].ToString());
                                    job.LASTNAME_TH = (reader["LastNameTh"] == DBNull.Value ? "" : reader["LastNameTh"].ToString());
                                    job.START_DATE = DateTime.Parse(reader["StartDate"].ToString());
                                    job.END_DATE = (reader["EndDate"] == DBNull.Value ? DateTime.Now : DateTime.Parse(reader["EndDate"].ToString()));
                                    job.TYPE_CODE = (reader["EmployeeTypeCode"] == DBNull.Value ? "" : reader["EmployeeTypeCode"].ToString());
                                    job.GROUP_CODE = (reader["EmployeeGroupCode"] == DBNull.Value ? "" : reader["EmployeeGroupCode"].ToString());
                                    job.DEPARTMENT_ID = (reader["DepartmentCode"] == DBNull.Value ? "" : reader["DepartmentCode"].ToString());

                                    jobList.Add(job);
                                }
                                while (reader.NextResult()) ;
                                return jobList;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        #endregion
    }
}
