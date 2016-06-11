using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Servicios;

namespace ProjectBDD
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                String usuarioBase="";
                
                if (!txtUsuario.Text.Equals(""))
                {
                    DataSet ds = new Servicios.LogicaNegocio().verificarUsuario(txtUsuario.Text.ToString());
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        usuarioBase = ds.Tables[0].Rows[0]["name"].ToString();
                    }
                    else {

                        MessageBox.Show("Verifique el usuario", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (usuarioBase.Equals(txtUsuario.Text)&&!usuarioBase.Equals(""))
                    {
                        this.Close();
                        Utilitario.pasarDatos.verificarLogueo = "true";
                    }
                    else
                    {
                        MessageBox.Show("Verifique el usuario", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Verifique el usuario", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No se estable comunicacion con la base de datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Utilitario.pasarDatos.verificarLogueo = "false";
        }
    }
}
