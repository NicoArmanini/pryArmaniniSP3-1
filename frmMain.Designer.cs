namespace pryArmaniniSP3_1
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.nudAnioFabricacion = new System.Windows.Forms.NumericUpDown();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.txtNumeroTurno = new System.Windows.Forms.TextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblAnioFabricacion = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblNumeroTurno = new System.Windows.Forms.Label();
            this.mrcEstadisticas = new System.Windows.Forms.GroupBox();
            this.txt6Caracteres = new System.Windows.Forms.TextBox();
            this.txtMasAntiguo = new System.Windows.Forms.TextBox();
            this.txtCantTurnos = new System.Windows.Forms.TextBox();
            this.lbl6Caracteres = new System.Windows.Forms.Label();
            this.lblMasAntiguo = new System.Windows.Forms.Label();
            this.lblCantTurnos = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mrcRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioFabricacion)).BeginInit();
            this.mrcEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.nudAnioFabricacion);
            this.mrcRegistro.Controls.Add(this.txtTitular);
            this.mrcRegistro.Controls.Add(this.txtDominio);
            this.mrcRegistro.Controls.Add(this.txtNumeroTurno);
            this.mrcRegistro.Controls.Add(this.lblTitular);
            this.mrcRegistro.Controls.Add(this.lblAnioFabricacion);
            this.mrcRegistro.Controls.Add(this.lblDominio);
            this.mrcRegistro.Controls.Add(this.lblNumeroTurno);
            this.mrcRegistro.Location = new System.Drawing.Point(30, 17);
            this.mrcRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Padding = new System.Windows.Forms.Padding(2);
            this.mrcRegistro.Size = new System.Drawing.Size(482, 167);
            this.mrcRegistro.TabIndex = 0;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro de Turnos";
            // 
            // nudAnioFabricacion
            // 
            this.nudAnioFabricacion.Location = new System.Drawing.Point(175, 90);
            this.nudAnioFabricacion.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nudAnioFabricacion.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.nudAnioFabricacion.Name = "nudAnioFabricacion";
            this.nudAnioFabricacion.Size = new System.Drawing.Size(94, 20);
            this.nudAnioFabricacion.TabIndex = 8;
            this.nudAnioFabricacion.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(170, 121);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(290, 20);
            this.txtTitular.TabIndex = 7;
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(170, 57);
            this.txtDominio.Margin = new System.Windows.Forms.Padding(2);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(138, 20);
            this.txtDominio.TabIndex = 5;
            // 
            // txtNumeroTurno
            // 
            this.txtNumeroTurno.Location = new System.Drawing.Point(170, 28);
            this.txtNumeroTurno.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroTurno.MaxLength = 5;
            this.txtNumeroTurno.Name = "txtNumeroTurno";
            this.txtNumeroTurno.Size = new System.Drawing.Size(79, 20);
            this.txtNumeroTurno.TabIndex = 4;
            this.txtNumeroTurno.TextChanged += new System.EventHandler(this.txtNumeroTurno_TextChanged);
            this.txtNumeroTurno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTurno_KeyPress);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(22, 126);
            this.lblTitular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // lblAnioFabricacion
            // 
            this.lblAnioFabricacion.AutoSize = true;
            this.lblAnioFabricacion.Location = new System.Drawing.Point(22, 92);
            this.lblAnioFabricacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnioFabricacion.Name = "lblAnioFabricacion";
            this.lblAnioFabricacion.Size = new System.Drawing.Size(101, 13);
            this.lblAnioFabricacion.TabIndex = 2;
            this.lblAnioFabricacion.Text = "Anio de Fabricacion";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(22, 62);
            this.lblDominio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // lblNumeroTurno
            // 
            this.lblNumeroTurno.AutoSize = true;
            this.lblNumeroTurno.Location = new System.Drawing.Point(22, 32);
            this.lblNumeroTurno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroTurno.Name = "lblNumeroTurno";
            this.lblNumeroTurno.Size = new System.Drawing.Size(90, 13);
            this.lblNumeroTurno.TabIndex = 0;
            this.lblNumeroTurno.Text = "Numero de Turno";
            // 
            // mrcEstadisticas
            // 
            this.mrcEstadisticas.Controls.Add(this.txt6Caracteres);
            this.mrcEstadisticas.Controls.Add(this.txtMasAntiguo);
            this.mrcEstadisticas.Controls.Add(this.txtCantTurnos);
            this.mrcEstadisticas.Controls.Add(this.lbl6Caracteres);
            this.mrcEstadisticas.Controls.Add(this.lblMasAntiguo);
            this.mrcEstadisticas.Controls.Add(this.lblCantTurnos);
            this.mrcEstadisticas.Location = new System.Drawing.Point(30, 206);
            this.mrcEstadisticas.Margin = new System.Windows.Forms.Padding(2);
            this.mrcEstadisticas.Name = "mrcEstadisticas";
            this.mrcEstadisticas.Padding = new System.Windows.Forms.Padding(2);
            this.mrcEstadisticas.Size = new System.Drawing.Size(482, 167);
            this.mrcEstadisticas.TabIndex = 0;
            this.mrcEstadisticas.TabStop = false;
            this.mrcEstadisticas.Text = "Estadisticas";
            // 
            // txt6Caracteres
            // 
            this.txt6Caracteres.Location = new System.Drawing.Point(230, 117);
            this.txt6Caracteres.Margin = new System.Windows.Forms.Padding(2);
            this.txt6Caracteres.Name = "txt6Caracteres";
            this.txt6Caracteres.ReadOnly = true;
            this.txt6Caracteres.Size = new System.Drawing.Size(81, 20);
            this.txt6Caracteres.TabIndex = 5;
            // 
            // txtMasAntiguo
            // 
            this.txtMasAntiguo.Location = new System.Drawing.Point(230, 78);
            this.txtMasAntiguo.Margin = new System.Windows.Forms.Padding(2);
            this.txtMasAntiguo.Name = "txtMasAntiguo";
            this.txtMasAntiguo.ReadOnly = true;
            this.txtMasAntiguo.Size = new System.Drawing.Size(81, 20);
            this.txtMasAntiguo.TabIndex = 4;
            // 
            // txtCantTurnos
            // 
            this.txtCantTurnos.Location = new System.Drawing.Point(230, 37);
            this.txtCantTurnos.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantTurnos.Name = "txtCantTurnos";
            this.txtCantTurnos.ReadOnly = true;
            this.txtCantTurnos.Size = new System.Drawing.Size(81, 20);
            this.txtCantTurnos.TabIndex = 3;
            // 
            // lbl6Caracteres
            // 
            this.lbl6Caracteres.AutoSize = true;
            this.lbl6Caracteres.Location = new System.Drawing.Point(22, 122);
            this.lbl6Caracteres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl6Caracteres.Name = "lbl6Caracteres";
            this.lbl6Caracteres.Size = new System.Drawing.Size(186, 13);
            this.lbl6Caracteres.TabIndex = 2;
            this.lbl6Caracteres.Text = "Cantidad con dominio de 6 caracteres";
            // 
            // lblMasAntiguo
            // 
            this.lblMasAntiguo.AutoSize = true;
            this.lblMasAntiguo.Location = new System.Drawing.Point(22, 83);
            this.lblMasAntiguo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMasAntiguo.Name = "lblMasAntiguo";
            this.lblMasAntiguo.Size = new System.Drawing.Size(106, 13);
            this.lblMasAntiguo.TabIndex = 1;
            this.lblMasAntiguo.Text = "Anio del mas Antiguo";
            // 
            // lblCantTurnos
            // 
            this.lblCantTurnos.AutoSize = true;
            this.lblCantTurnos.Location = new System.Drawing.Point(22, 42);
            this.lblCantTurnos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantTurnos.Name = "lblCantTurnos";
            this.lblCantTurnos.Size = new System.Drawing.Size(100, 13);
            this.lblCantTurnos.TabIndex = 0;
            this.lblCantTurnos.Text = "Cantidad de Turnos";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(550, 17);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 40);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(550, 79);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 38);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(550, 206);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(124, 35);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 392);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcEstadisticas);
            this.Controls.Add(this.mrcRegistro);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Auto test";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioFabricacion)).EndInit();
            this.mrcEstadisticas.ResumeLayout(false);
            this.mrcEstadisticas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblAnioFabricacion;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblNumeroTurno;
        private System.Windows.Forms.GroupBox mrcEstadisticas;
        private System.Windows.Forms.Label lbl6Caracteres;
        private System.Windows.Forms.Label lblMasAntiguo;
        private System.Windows.Forms.Label lblCantTurnos;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.TextBox txtNumeroTurno;
        private System.Windows.Forms.TextBox txt6Caracteres;
        private System.Windows.Forms.TextBox txtMasAntiguo;
        private System.Windows.Forms.TextBox txtCantTurnos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.NumericUpDown nudAnioFabricacion;
    }
}

