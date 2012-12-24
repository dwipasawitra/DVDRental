using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Drawing;
using Oracle.DataAccess.Types;


// Database Connection
namespace Rentalin
{
    class dbConnection
    {
        private OracleConnection conn;
        private string connStr = "Data Source=(DESCRIPTION="
             + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
             + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));"
             + "User Id=wira;Password=280993;";
        
        public bool Open()
         {
            try
            {
                conn = new OracleConnection(connStr);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }

        public DataSet ExecuteDataSet(string sql)   //executeQuery
        {
            try
            {
                DataSet ds = new DataSet();
                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public OracleDataReader Exception(string sql)
        {
            try
            {
                OracleDataReader reader;
                OracleCommand cmd = new OracleCommand(sql, conn);
                reader = cmd.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public int ExecuteNonQuery(string sql)//executeSQL
        {
            try
            {
                int affected;
                OracleTransaction mytransaction = conn.BeginTransaction();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

        public DataTable ExecuteDataTable(string sql)
        {
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(sql, conn);
            da.Fill(dt);
            da.Update(dt);
            return dt;
        }

        public int ExecuteBlobQuery(string sql, string param, byte[] blob)
        {
            try
            {
                OracleParameter blobParameter = new OracleParameter();
                blobParameter.OracleDbType = OracleDbType.Blob;
                blobParameter.ParameterName = param;
                blobParameter.Value = blob;
                OracleCommand cmd = new OracleCommand(sql, conn);
                cmd.Parameters.Add(blobParameter);
                int affected = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

        public string connString { get; set; }
    }
}