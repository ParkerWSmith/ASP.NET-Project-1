using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace Project_1
{
    public class clsDatabase
    {
        //***** AcquireConnection()
        private static SqlConnection AcquireConnection()
        {
            SqlConnection cnSQL = null;
            Boolean blnErrorOccurred = false;

            if (ConfigurationManager.ConnectionStrings["ServiceCenter"] != null)
            {
                cnSQL = new SqlConnection();
                cnSQL.ConnectionString = ConfigurationManager.ConnectionStrings["ServiceCenter"].ToString();

                try
                {
                    cnSQL.Open();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return cnSQL;
            }
        }

        //*****GetTechnicianByID()
        public static DataSet GetTechnicianByID(string strTechID)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            Boolean blnErrorOccurred = false;
            Int32 intRetCode;

            if (strTechID.Trim().Length > 0)
            {
                cnSQL = AcquireConnection();
                if (cnSQL == null)
                {
                    blnErrorOccurred = true;
                }
                else
                {
                    cmdSQL = new SqlCommand();
                    cmdSQL.Connection = cnSQL;
                    cmdSQL.CommandType = CommandType.StoredProcedure;
                    cmdSQL.CommandText = "uspGetTechniciansByID";

                    cmdSQL.Parameters.Add(new SqlParameter("@TechniciansID", SqlDbType.NVarChar, 10));
                    cmdSQL.Parameters["@TechniciansID"].Direction = ParameterDirection.Input;
                    cmdSQL.Parameters["@TechniciansID"].Value = strTechID;

                    cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                    cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                    dsSQL = new DataSet();
                    try
                    {
                        daSQL = new SqlDataAdapter(cmdSQL);
                        intRetCode = daSQL.Fill(dsSQL);
                        daSQL.Dispose();
                    }
                    catch (Exception ex)
                    {
                        blnErrorOccurred = true;
                        dsSQL.Dispose();
                    }
                    finally
                    {
                        cmdSQL.Parameters.Clear();
                        cmdSQL.Dispose();
                        cnSQL.Close();
                        cnSQL.Dispose();
                    }
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }

        //***** GetTechnicianList()
        public static DataSet GetTechnicianList()
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            Boolean blnErrorOccurred = false;
            Int32 intRetCode;

            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                return null;
            }
            else
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "uspGetTechnicianList";

                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                dsSQL = new DataSet();
                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    intRetCode = daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    dsSQL.Dispose();
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }

        //***** GetTechnicians()
        public static DataSet GetTechnicians()
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            Boolean blnErrorOccurred = false;
            Int32 intRetCode;

            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                blnErrorOccurred = true;
            }
            else
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "uspGetTechnicians";

                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                dsSQL = new DataSet();
                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    intRetCode = daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    dsSQL.Dispose();
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }

        //***** InsertTechnician()
        //public static Int32 InsertTechnician(string strLName, string strFName, string strMInit, string strEMail, string strDept, string strPhone, decimal decHRate)
        //{

        //}

        public static Int32 RemoveTechnicians(String strTechID)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            Boolean blnErrorOccurred = false;
            Int32 intRetCode = 0;

            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                blnErrorOccurred = true;
            }
            else
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "uspDeleteTechnician";

                cmdSQL.Parameters.Add(new SqlParameter("@TechID", SqlDbType.NVarChar, 10));
                cmdSQL.Parameters["@TechID"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@TechID"].Value = strTechID;

                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                try
                {
                    intRetCode = cmdSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
}