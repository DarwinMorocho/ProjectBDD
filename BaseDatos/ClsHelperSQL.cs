using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using System.Diagnostics;
using System.Configuration;

namespace BaseDatos
{
    public class ClsHelperSQL
    {
        //medio de tratamiento de la base 
        public void ExecuteNonQuery(string strSQL)
        {

            SqlConnection cnn = null;

            try
            {
                cnn = new SqlConnection(ObtenerCadenaConexion());
                cnn.Open();

                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }

            }




        }



        public DataSet ExecuteDataSet(string strSQL)
        {
            DataSet ds = new DataSet();
            SqlConnection cnn = null;

            try
            {
                cnn = new SqlConnection(ObtenerCadenaConexion());
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;

                cmd.CommandTimeout = 0;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }


        private string ObtenerCadenaConexion()
        {
            try
            {



                return "Data Source=" + ConfigurationManager.AppSettings["host"] + ";Initial Catalog=" + ConfigurationManager.AppSettings["database"] + ";Persist Security Info=True;User ID=" + ConfigurationManager.AppSettings["user"] + ";password=" + ConfigurationManager.AppSettings["password"];
                //Data Source=(local);Initial Catalog=VC_GLOB_GUSTERS;Persist Security Info=True;User ID=bases;password=bases";

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
