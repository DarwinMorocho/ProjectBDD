using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BaseDatos;
namespace Servicios
{
    public class LogicaNegocio
    {

        #region Consultas

        public DataSet ConsultarEjemplar(string valor, bool alquilado)
        {

            try
            {

                string strSQL = "Select * from EJEMPLAR where ALQUILADO='" + alquilado + "' and PEL_TITULO like '%" + valor + "%'";

                return new BaseDatos.ClsHelperSQL().ExecuteDataSet(strSQL);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet ConsultarSocio(string valor)
        {

            try
            {

                string strSQL = "SELECT * FROM dbo.SOCIO S where S.SOC_NOMBRE like '%" + valor + "%'";

                return new BaseDatos.ClsHelperSQL().ExecuteDataSet(strSQL);

            }
            catch (Exception)
            {

                throw;
            }
        }

       
          public DataSet ConsultarAlquilados()
        {

            try
            {

                string strSQL = "select * from ALQUILA where FECHA_DEVOLUCION is null";

                return new BaseDatos.ClsHelperSQL().ExecuteDataSet(strSQL);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataSet ConsultarSocioDNI(string valor)
        {

            try
            {

                string strSQL = "SELECT * FROM dbo.SOCIO S where S.DNI_SOCIO= '" + valor + "'";

                return new BaseDatos.ClsHelperSQL().ExecuteDataSet(strSQL);

            }
            catch (Exception)
            {

                throw;
            }
        }

        //select name from sysusers where name ='UsuarioDarwin' and islogin=1
        public DataSet verificarUsuario(string valor)
        {

            try
            {

                string strSQL = "select name from sysusers where name ='" + valor + "' and islogin=1";

                return new BaseDatos.ClsHelperSQL().ExecuteDataSet(strSQL);

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Insert
        public void InsertarAlquilar(DataSet dsInfo)
        {
            try
            {
                string dni = dsInfo.Tables[0].Rows[0]["DNI"].ToString();
                string fechaAl = dsInfo.Tables[0].Rows[0]["FECHA"].ToString();
                string numEjem = dsInfo.Tables[0].Rows[0]["NUM"].ToString();
                string peli = dsInfo.Tables[0].Rows[0]["PELI"].ToString();

                string strSQL = string.Empty;




                strSQL = "INSERT INTO [VC_GLOB_GUSTERS].[dbo].[ALQUILA] " +
           "([DNI_SOCIO]" +
          " ,[FECHA_ALQUILER]" +
         "  ,[EJE_NUM_EJEMPLAR]" +
         "  ,[PELICULA])" +
   "  VALUES" +
     "      ('" + dni + "'" +
       "    ,'" + fechaAl + "'" +
      "     ,'" + numEjem + "'" +
      "     ,'" + peli + "')";

                BaseDatos.ClsHelperSQL objAccesoDatos =
                    new ClsHelperSQL();
                objAccesoDatos.ExecuteNonQuery(strSQL);
            }
            catch (Exception)
            {
                //graba el archivo de error

                throw;
            }
        }


            public void actualizarAlquilar(DataSet dsInfo)
        {
            try
            {
                string dni = dsInfo.Tables[0].Rows[0]["DNI"].ToString();
                string fechaDev = dsInfo.Tables[0].Rows[0]["FECHA_DEV"].ToString();
                string fechaAl = dsInfo.Tables[0].Rows[0]["FECHAAL"].ToString();
                string numEjem = dsInfo.Tables[0].Rows[0]["NUM"].ToString();
                string peli = dsInfo.Tables[0].Rows[0]["PELI"].ToString();

                string strSQL = string.Empty;




                strSQL = "UPDATE ALQUILA SET FECHA_DEVOLUCION='" + fechaDev + "' WHERE DNI_SOCIO='" + dni +
                    "' AND FECHA_ALQUILER='" + fechaAl + "' AND EJE_NUM_EJEMPLAR='" + numEjem + "' AND PELICULA='"+peli+"'";

                BaseDatos.ClsHelperSQL objAccesoDatos =
                    new ClsHelperSQL();
                objAccesoDatos.ExecuteNonQuery(strSQL);
            }
            catch (Exception)
            {
                //graba el archivo de error

                throw;
            }
        }
        #endregion


    }
    
    


}
