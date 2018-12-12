using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Utility;
using QueryBase;
namespace DataAccess
{
    public class DataHandler : IDisposable
    {
        private SqlConnection objConnection;
        private SqlCommand objCommand;
        private SqlDataAdapter objAdapter;
        private SqlTransaction objTransaction;

        private SqlParameter parameter;


        private List<SqlParameter> parameterCollection = new List<SqlParameter>();

        private bool hasTransaction;

        private ResultArgs result;
        public DataHandler(Common.ConnectionType connctionType)
        {
            string connection = string.Empty;
            if (connctionType == Common.ConnectionType.Ascend)
            {
                connection = ConfigurationManager.ConnectionStrings["Ascend"].ConnectionString;
                objConnection = new SqlConnection(connection);
            }
            else
            {
                connection = ConfigurationManager.ConnectionStrings["MarineDelivery"].ConnectionString;
                objConnection = new SqlConnection(connection);
                
            }

        }

        public void AddParameter(string parameterName, object value)
        {
            parameter = new SqlParameter();
            parameter.Value = value;
            parameter.ParameterName = "@" + parameterName;
            parameterCollection.Add(parameter);
        }

        public void BeginTransaction()
        {
            if (objConnection.State != ConnectionState.Open)
                objConnection.Open();
            objTransaction = objConnection.BeginTransaction();
            hasTransaction = true;
        }

        public void CommitTrasaction(ResultArgs result)
        {
            if (result.Success)
                objTransaction.Commit();
            else
                objTransaction.Rollback();
            objConnection.Close();
        }

        public ResultArgs Fetch(object command, Common.CommandType cmdType)
        {
            result = new ResultArgs();
            try
            {
                
                objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                if (hasTransaction)
                    objCommand.Transaction = objTransaction;

                if (cmdType == Common.CommandType.StroeProcedure)
                {
                    
                    objCommand.CommandType = CommandType.StoredProcedure;
                    QueryFetch objQueryFetch = new QueryFetch();
                    objCommand.CommandText = objQueryFetch.GetQuery(command);
                   
                }
                else if (cmdType == Common.CommandType.Query)
                {
                    objCommand.CommandType = CommandType.Text;
                    QueryFetch objQueryFetch = new QueryFetch();
                    objCommand.CommandText = objQueryFetch.GetQuery(command);
                }

                BindParameterWithCommand();
                objAdapter = new SqlDataAdapter();
                if (objConnection.State != ConnectionState.Open)
                    objConnection.Open();
                objAdapter.SelectCommand = objCommand;
                DataTable dtresult = new DataTable();
               
                objAdapter.Fill(dtresult);
               
                result.Source = dtresult;
                result.Success = true;
                if (result.Source != null && result.Source.Rows.Count > 0)
                {
                    result.AffectedRows = result.Source.Rows.Count;
                }
                else
                {
                    result.AffectedRows = 0;
                    result.Message = "Proc returned no records.";

                }

            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                Logger.WriteErrorLog(objCommand.CommandText);
                foreach (SqlParameter item in parameterCollection)
                {
                    result.Message += objCommand.CommandText;
                    Logger.WriteErrorLog(string.Format("Name - {0} - Value - {1}", item.ParameterName, item.Value));
                }
                Logger.WriteErrorLog(ex.Message);
                result.Success = false;
                result.AffectedRows = 0;




            }
            finally
            {
                if (!hasTransaction)
                    objConnection.Close();

                parameterCollection.Clear();
            }
            return result;

        }

        public ResultArgs ExecuteScalar(object command, Common.CommandType cmdType)
        {
            result = new ResultArgs();
            try
            {
                objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                if (hasTransaction)
                    objCommand.Transaction = objTransaction;
                if (cmdType == Common.CommandType.StroeProcedure)
                {
                    objCommand.CommandType = CommandType.StoredProcedure;
                    QueryFetch objQueryFetch = new QueryFetch();
                    objCommand.CommandText = objQueryFetch.GetQuery(command);
                }
                else if (cmdType == Common.CommandType.Query)
                {
                    objCommand.CommandType = CommandType.Text;
                    QueryFetch objQueryFetch = new QueryFetch();
                    objCommand.CommandText = objQueryFetch.GetQuery(command);
                }
                BindParameterWithCommand();
                if (objConnection.State != ConnectionState.Open)
                    objConnection.Open();
                result.Scalar = objCommand.ExecuteScalar();
                result.Success = true;

            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.AffectedRows = 0;
                Logger.WriteErrorLog(objCommand.CommandText);
                foreach (SqlParameter item in parameterCollection)
                {
                    Logger.WriteErrorLog(string.Format("Name - {0} - Value - {1}", item.ParameterName, item.Value));
                }
                Logger.WriteLog(ex.Message);
                result.Success = false;
            }
            finally
            {
                if (!hasTransaction)
                    objConnection.Close();

                parameterCollection.Clear();
            }
            Logger.WriteLog(result.Scalar.ToString());
            return result;
        }


        public ResultArgs Update(object command, Common.CommandType cmdType)
        {
            result = new ResultArgs();
            try
            {
                objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                if (hasTransaction)
                    objCommand.Transaction = objTransaction;
                if (cmdType == Common.CommandType.StroeProcedure)
                {
                    objCommand.CommandType = CommandType.StoredProcedure;
                    QueryFetch objQueryFetch = new QueryFetch();
                    objCommand.CommandText = objQueryFetch.GetQuery(command);
                }
                else if (cmdType == Common.CommandType.Query)
                {
                    objCommand.CommandType = CommandType.Text;
                    QueryFetch objQueryFetch = new QueryFetch();
                    objCommand.CommandText = objQueryFetch.GetQuery(command);
                }
                BindParameterWithCommand();
                if (objConnection.State != ConnectionState.Open)
                    objConnection.Open();

                result.AffectedRows = objCommand.ExecuteNonQuery();
                result.Success = true;
            }
            catch (Exception ex)
            {
                Logger.WriteErrorLog(objCommand.CommandText);
                foreach (SqlParameter item in parameterCollection)
                {
                    Logger.WriteErrorLog(string.Format("Name - {0} - Value - {1}", item.ParameterName, item.Value));
                }
                Logger.WriteErrorLog(ex.Message);
                
                result.Message = ex.Message;
                result.AffectedRows = 0;
                result.Success = false;
            }
            finally
            {
                if (!hasTransaction)
                    objConnection.Close();

                parameterCollection.Clear();
            }
            return result;
        }


        private void BindParameterWithCommand()
        {
            foreach (SqlParameter para in parameterCollection)
            {
                objCommand.Parameters.AddWithValue(para.ParameterName, para.Value);

            }
        }

        public void Dispose()
        {
            GC.Collect();
        }
    }
}
