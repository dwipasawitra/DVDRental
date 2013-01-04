using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Drawing;
using Oracle.DataAccess.Types;
using System.IO;


// Database Connection
namespace Rentalin
{
    class dbConnection
    {
        private OracleConnection conn;
        private string connStr = "Data Source=(DESCRIPTION="
             + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
             + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));"
             + "User Id=hyuuzu;Password=kireina;";
        //private string connStr = "";
        public bool Open()
         {
            try
            {
                // Open connection text file
                

                conn = new OracleConnection(connStr);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi tidak bisa dilakukan, pastikan definisi koneksi pada koneksi.txt diisi dengan benar.\nPesan kesalahan : \n" + ex.ToString(), "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Query gagal dijalankan, pastikan definisi data di dalam Oracle 11g sudah sesuai dengan upstream.\nPesan kesalahan : \n" + ex.ToString(), "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        public DataTable ExecuteDataTable(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(sql, conn);
                da.Fill(dt);
                da.Update(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Query gagal dijalankan, pastikan definisi data di dalam Oracle 11g sudah sesuai dengan upstream.\nPesan kesalahan : \n" + ex.ToString(), "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
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
                MessageBox.Show("Query gagal dijalankan, pastikan definisi data di dalam Oracle 11g sudah sesuai dengan upstream.\nPesan kesalahan : \n" + ex.ToString(), "Galat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return -1;
        }

        public string connString { get; set; }
    }
}