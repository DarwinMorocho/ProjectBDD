using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Servicios;
using System.Configuration;

namespace ProjectBDD
{
    public partial class FrmAlquilar : Form
    {
        string ejemplar = "";
        string titulo = "";
        string dniSocio = "";
        string accion = "A";

        //devolucion

        string dniSocioDev = "";
        string fechaDev = "";
        string ejemplaeDev = "";
        string peliculaDev = "";

        private bool alquilado = false;
        public FrmAlquilar()
        {
            InitializeComponent();
        }

        private void txtBuscarPelicula_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                consultarEjemplar();
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void FrmAlquilar_Load(object sender, EventArgs e)
        {
            try
            {
                dgvAlquilados.Enabled = false;
                gbEntrega.Enabled = false;
                consultarEjemplar();
                consultarSocio();
                //string miValor = ConfigurationManager.AppSettings["Opcion1"];
                //MessageBox.Show(miValor);

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["user"].Value = "NoVale";
                config.Save(ConfigurationSaveMode.Modified);

            }
            catch (Exception)
            {

                throw;
            }
        }

        #region consultas
        private void consultarEjemplar()
        {
            try
            {
                dgvEjemplar.DataSource = new Servicios.LogicaNegocio().ConsultarEjemplar(txtBuscarPelicula.Text, alquilado).Tables[0];
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void consultarSocio()
        {
            try
            {
                dgvSocio.DataSource = new Servicios.LogicaNegocio().ConsultarSocio(txtBuscarPelicula.Text).Tables[0];
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        private void txtBuscarSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                consultarSocio();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void rbAlquilar_CheckedChanged(object sender, EventArgs e)
        {
            lblPelicula.Text = "";
            lblPelicula.Text = "";
            if (rbAlquilar.Checked == true)
            {
                dgvAlquilados.Enabled = false;
                accion = "A";
                gbAlquiler.Enabled = true;
                alquilado = false;
                gbPelicula.Enabled = true;
                gbAlquiler.Enabled = true;
                gbSocio.Enabled = true;
                consultarEjemplar();

            }
            else
            {
                gbAlquiler.Enabled = false;
                alquilado = true;
                gbPelicula.Enabled = true;

                consultarEjemplar();
            }
        }

        private void consultarAlquilados() {
            try
            {
                 dgvAlquilados.DataSource = new Servicios.LogicaNegocio().ConsultarAlquilados().Tables[0];
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void rbDevolucion_CheckedChanged(object sender, EventArgs e)
        {
            lblPelicula.Text = "";
            lblPelicula.Text = "";
            if (rbDevolucion.Checked == true)
            {
                consultarAlquilados();
               
                dgvAlquilados.Enabled = true;
                accion = "D";
                alquilado = true;
                gbEntrega.Enabled = true;
                gbAlquiler.Enabled = false;
                gbPelicula.Enabled = false;
                gbAlquiler.Enabled = false;
                gbSocio.Enabled = false;

                consultarEjemplar();
            }
            else
            {
                gbAlquiler.Enabled = true;
                gbEntrega.Enabled = false;
                alquilado = false;
                gbPelicula.Enabled = true;
                gbSocio.Enabled = true;
                consultarEjemplar();
            }
        }

        private void dgvEjemplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dgvEjemplar.DataSource;
            DataRow dr = dt.Rows[e.RowIndex];
            ejemplar = dr["EJE_NUM_EJEMPLAR"].ToString();
            titulo = dr["PEL_TITULO"].ToString();

            consultarSocio();


            lblPelicula.Text = "Numero ejemplar: " + ejemplar + " Titulo: " + titulo;
        }

        private void dgvSocio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dgvSocio.DataSource;
            DataRow dr = dt.Rows[e.RowIndex];
            dniSocio = dr["DNI_SOCIO"].ToString();


            lblSocio.Text = "Socio" + dniSocio;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (accion.Equals("A"))
                {
                    InsertarAlquile();
                    MessageBox.Show("Registrado con exitos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    consultarEjemplar();
                }
                else
                {

                    if (!dniSocioDev.Equals(""))
                    {
                        actualizarAlquile();
                        consultarAlquilados();
                        consultarEjemplar();
                        consultarSocio();
                        
                    }
                    else {
                        MessageBox.Show("Seleccione un registro", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique la disponibilidad del ejemplar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void InsertarAlquile()
        {

            DataSet dsCliente = new DataSet();
            DataTable dtInfo = new DataTable();
            try
            {

                dtInfo.Columns.Add("DNI", typeof(string));
                dtInfo.Columns.Add("FECHA", typeof(string));
                dtInfo.Columns.Add("NUM", typeof(string));
                dtInfo.Columns.Add("PELI", typeof(string));

                dtInfo.Rows.Add(dniSocio, dtpAlquiler.Value.ToString(), ejemplar, titulo);
                dsCliente.Tables.Add(dtInfo);
                new Servicios.LogicaNegocio().InsertarAlquilar(dsCliente);



            }
            catch (Exception e)
            {

            }
        }


        private void actualizarAlquile()
        {

            DataSet dsCliente = new DataSet();
            DataTable dtInfo = new DataTable();
            try
            {

                //string dni = dsInfo.Tables[0].Rows[0]["DNI"].ToString();
                //string fechaDev = dsInfo.Tables[0].Rows[0]["FECHA_DEV"].ToString();
                //string fechaAl = dsInfo.Tables[0].Rows[0]["FECHAAL"].ToString();
                //string numEjem = dsInfo.Tables[0].Rows[0]["NUM"].ToString();
                //string peli = dsInfo.Tables[0].Rows[0]["PELI"].ToString();

                dtInfo.Columns.Add("DNI", typeof(string));
                dtInfo.Columns.Add("FECHA_DEV", typeof(string));
                dtInfo.Columns.Add("FECHAAL", typeof(string));
                dtInfo.Columns.Add("NUM", typeof(string));
                dtInfo.Columns.Add("PELI", typeof(string));

                dtInfo.Rows.Add(dniSocioDev,dtpEntrega.Value.ToString() ,fechaDev, ejemplaeDev, peliculaDev);
                dsCliente.Tables.Add(dtInfo);
                new Servicios.LogicaNegocio().actualizarAlquilar(dsCliente);



            }
            catch (Exception e)
            {

            }
        }

       
        private void dgvAlquilados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dgvAlquilados.DataSource;
            DataRow dr = dt.Rows[e.RowIndex];
            dniSocioDev = dr["DNI_SOCIO"].ToString();
            fechaDev = dr["FECHA_ALQUILER"].ToString();
            ejemplaeDev = dr["EJE_NUM_EJEMPLAR"].ToString();
            peliculaDev = dr["PELICULA"].ToString();
            lblSeleccionado.Text = peliculaDev;


        }

        private void lblAlquilado_Click(object sender, EventArgs e)
        {

        }

    }
}
