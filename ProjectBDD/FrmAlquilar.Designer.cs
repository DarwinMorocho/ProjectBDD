namespace ProjectBDD
{
    partial class FrmAlquilar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlquilar));
            this.gbPelicula = new System.Windows.Forms.GroupBox();
            this.dgvSocio = new System.Windows.Forms.DataGridView();
            this.dgvEjemplar = new System.Windows.Forms.DataGridView();
            this.txtBuscarSocio = new System.Windows.Forms.TextBox();
            this.txtBuscarPelicula = new System.Windows.Forms.TextBox();
            this.Socio = new System.Windows.Forms.Label();
            this.Pelicula = new System.Windows.Forms.Label();
            this.rbAlquilar = new System.Windows.Forms.RadioButton();
            this.rbDevolucion = new System.Windows.Forms.RadioButton();
            this.gbSocio = new System.Windows.Forms.GroupBox();
            this.dtpAlquiler = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbAlquiler = new System.Windows.Forms.GroupBox();
            this.gbEntrega = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblSocio = new System.Windows.Forms.Label();
            this.dgvAlquilados = new System.Windows.Forms.DataGridView();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPelicula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplar)).BeginInit();
            this.gbSocio.SuspendLayout();
            this.gbAlquiler.SuspendLayout();
            this.gbEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquilados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPelicula
            // 
            this.gbPelicula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPelicula.Controls.Add(this.dgvEjemplar);
            this.gbPelicula.Controls.Add(this.txtBuscarPelicula);
            this.gbPelicula.Controls.Add(this.Pelicula);
            this.gbPelicula.Location = new System.Drawing.Point(12, 48);
            this.gbPelicula.Name = "gbPelicula";
            this.gbPelicula.Size = new System.Drawing.Size(494, 220);
            this.gbPelicula.TabIndex = 0;
            this.gbPelicula.TabStop = false;
            this.gbPelicula.Text = "Seleccion";
            // 
            // dgvSocio
            // 
            this.dgvSocio.AllowUserToAddRows = false;
            this.dgvSocio.AllowUserToDeleteRows = false;
            this.dgvSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocio.Location = new System.Drawing.Point(9, 50);
            this.dgvSocio.Name = "dgvSocio";
            this.dgvSocio.ReadOnly = true;
            this.dgvSocio.Size = new System.Drawing.Size(448, 150);
            this.dgvSocio.TabIndex = 5;
            this.dgvSocio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSocio_CellClick);
            // 
            // dgvEjemplar
            // 
            this.dgvEjemplar.AllowUserToAddRows = false;
            this.dgvEjemplar.AllowUserToDeleteRows = false;
            this.dgvEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEjemplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjemplar.Location = new System.Drawing.Point(16, 50);
            this.dgvEjemplar.Name = "dgvEjemplar";
            this.dgvEjemplar.ReadOnly = true;
            this.dgvEjemplar.Size = new System.Drawing.Size(461, 149);
            this.dgvEjemplar.TabIndex = 4;
            this.dgvEjemplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEjemplar_CellClick);
            // 
            // txtBuscarSocio
            // 
            this.txtBuscarSocio.Location = new System.Drawing.Point(47, 24);
            this.txtBuscarSocio.Name = "txtBuscarSocio";
            this.txtBuscarSocio.Size = new System.Drawing.Size(224, 20);
            this.txtBuscarSocio.TabIndex = 3;
            this.txtBuscarSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarSocio_KeyPress);
            // 
            // txtBuscarPelicula
            // 
            this.txtBuscarPelicula.Location = new System.Drawing.Point(63, 24);
            this.txtBuscarPelicula.Name = "txtBuscarPelicula";
            this.txtBuscarPelicula.Size = new System.Drawing.Size(152, 20);
            this.txtBuscarPelicula.TabIndex = 2;
            this.txtBuscarPelicula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarPelicula_KeyPress);
            // 
            // Socio
            // 
            this.Socio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Socio.AutoSize = true;
            this.Socio.Location = new System.Drawing.Point(6, 28);
            this.Socio.Name = "Socio";
            this.Socio.Size = new System.Drawing.Size(34, 13);
            this.Socio.TabIndex = 1;
            this.Socio.Text = "Socio";
            // 
            // Pelicula
            // 
            this.Pelicula.AutoSize = true;
            this.Pelicula.Location = new System.Drawing.Point(13, 24);
            this.Pelicula.Name = "Pelicula";
            this.Pelicula.Size = new System.Drawing.Size(44, 13);
            this.Pelicula.TabIndex = 0;
            this.Pelicula.Text = "Pelicula";
            // 
            // rbAlquilar
            // 
            this.rbAlquilar.AutoSize = true;
            this.rbAlquilar.Checked = true;
            this.rbAlquilar.Location = new System.Drawing.Point(28, 12);
            this.rbAlquilar.Name = "rbAlquilar";
            this.rbAlquilar.Size = new System.Drawing.Size(59, 17);
            this.rbAlquilar.TabIndex = 6;
            this.rbAlquilar.TabStop = true;
            this.rbAlquilar.Text = "Alquilar";
            this.rbAlquilar.UseVisualStyleBackColor = true;
            this.rbAlquilar.CheckedChanged += new System.EventHandler(this.rbAlquilar_CheckedChanged);
            // 
            // rbDevolucion
            // 
            this.rbDevolucion.AutoSize = true;
            this.rbDevolucion.Location = new System.Drawing.Point(159, 12);
            this.rbDevolucion.Name = "rbDevolucion";
            this.rbDevolucion.Size = new System.Drawing.Size(79, 17);
            this.rbDevolucion.TabIndex = 7;
            this.rbDevolucion.Text = "Devolucion";
            this.rbDevolucion.UseVisualStyleBackColor = true;
            this.rbDevolucion.CheckedChanged += new System.EventHandler(this.rbDevolucion_CheckedChanged);
            // 
            // gbSocio
            // 
            this.gbSocio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSocio.Controls.Add(this.Socio);
            this.gbSocio.Controls.Add(this.txtBuscarSocio);
            this.gbSocio.Controls.Add(this.dgvSocio);
            this.gbSocio.Location = new System.Drawing.Point(510, 48);
            this.gbSocio.Name = "gbSocio";
            this.gbSocio.Size = new System.Drawing.Size(463, 220);
            this.gbSocio.TabIndex = 6;
            this.gbSocio.TabStop = false;
            this.gbSocio.Text = "Socio";
            // 
            // dtpAlquiler
            // 
            this.dtpAlquiler.Location = new System.Drawing.Point(107, 18);
            this.dtpAlquiler.Name = "dtpAlquiler";
            this.dtpAlquiler.Size = new System.Drawing.Size(200, 20);
            this.dtpAlquiler.TabIndex = 8;
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Location = new System.Drawing.Point(107, 19);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(200, 20);
            this.dtpEntrega.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha de alquiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha entrega";
            // 
            // gbAlquiler
            // 
            this.gbAlquiler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbAlquiler.Controls.Add(this.dtpAlquiler);
            this.gbAlquiler.Controls.Add(this.label1);
            this.gbAlquiler.Location = new System.Drawing.Point(646, 274);
            this.gbAlquiler.Name = "gbAlquiler";
            this.gbAlquiler.Size = new System.Drawing.Size(327, 67);
            this.gbAlquiler.TabIndex = 12;
            this.gbAlquiler.TabStop = false;
            this.gbAlquiler.Text = "Alquiler";
            // 
            // gbEntrega
            // 
            this.gbEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbEntrega.Controls.Add(this.dtpEntrega);
            this.gbEntrega.Controls.Add(this.label2);
            this.gbEntrega.Location = new System.Drawing.Point(646, 341);
            this.gbEntrega.Name = "gbEntrega";
            this.gbEntrega.Size = new System.Drawing.Size(327, 66);
            this.gbEntrega.TabIndex = 13;
            this.gbEntrega.TabStop = false;
            this.gbEntrega.Text = "Entrega";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(846, 413);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(127, 37);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pelicula seleccionada";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Socio seleccionado";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelicula.Location = new System.Drawing.Point(178, 271);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(37, 20);
            this.lblPelicula.TabIndex = 17;
            this.lblPelicula.Text = ".......";
            // 
            // lblSocio
            // 
            this.lblSocio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSocio.AutoSize = true;
            this.lblSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(178, 300);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(37, 20);
            this.lblSocio.TabIndex = 18;
            this.lblSocio.Text = ".......";
            // 
            // dgvAlquilados
            // 
            this.dgvAlquilados.AllowUserToAddRows = false;
            this.dgvAlquilados.AllowUserToDeleteRows = false;
            this.dgvAlquilados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlquilados.Location = new System.Drawing.Point(12, 323);
            this.dgvAlquilados.Name = "dgvAlquilados";
            this.dgvAlquilados.ReadOnly = true;
            this.dgvAlquilados.Size = new System.Drawing.Size(494, 117);
            this.dgvAlquilados.TabIndex = 19;
            this.dgvAlquilados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlquilados_CellClick);
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionado.Location = new System.Drawing.Point(139, 446);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(33, 20);
            this.lblSeleccionado.TabIndex = 20;
            this.lblSeleccionado.Text = "......";
            this.lblSeleccionado.Click += new System.EventHandler(this.lblAlquilado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Seleccionado: ";
            // 
            // FrmAlquilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.dgvAlquilados);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gbEntrega);
            this.Controls.Add(this.gbAlquiler);
            this.Controls.Add(this.rbAlquilar);
            this.Controls.Add(this.rbDevolucion);
            this.Controls.Add(this.gbSocio);
            this.Controls.Add(this.gbPelicula);
            this.Name = "FrmAlquilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlquilar";
            this.Load += new System.EventHandler(this.FrmAlquilar_Load);
            this.gbPelicula.ResumeLayout(false);
            this.gbPelicula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplar)).EndInit();
            this.gbSocio.ResumeLayout(false);
            this.gbSocio.PerformLayout();
            this.gbAlquiler.ResumeLayout(false);
            this.gbAlquiler.PerformLayout();
            this.gbEntrega.ResumeLayout(false);
            this.gbEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquilados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPelicula;
        private System.Windows.Forms.DataGridView dgvEjemplar;
        private System.Windows.Forms.TextBox txtBuscarSocio;
        private System.Windows.Forms.TextBox txtBuscarPelicula;
        private System.Windows.Forms.Label Socio;
        private System.Windows.Forms.Label Pelicula;
        private System.Windows.Forms.DataGridView dgvSocio;
        private System.Windows.Forms.RadioButton rbDevolucion;
        private System.Windows.Forms.RadioButton rbAlquilar;
        private System.Windows.Forms.GroupBox gbSocio;
        private System.Windows.Forms.DateTimePicker dtpAlquiler;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbAlquiler;
        private System.Windows.Forms.GroupBox gbEntrega;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.DataGridView dgvAlquilados;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Label label5;
    }
}