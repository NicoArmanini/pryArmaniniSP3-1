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
            this.mrcEstadisticas = new System.Windows.Forms.GroupBox();
            this.lblNumeroTurno = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.AnioFabricacion = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblCantTurnos = new System.Windows.Forms.Label();
            this.lblMasAntiguo = new System.Windows.Forms.Label();
            this.lbl6Caracteres = new System.Windows.Forms.Label();
            this.txtNumeroTurno = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.lstAnioFabricacion = new System.Windows.Forms.ListBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtCantTurnos = new System.Windows.Forms.TextBox();
            this.txtMasAntiguo = new System.Windows.Forms.TextBox();
            this.txt6Caracteres = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mrcRegistro.SuspendLayout();
            this.mrcEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.txtTitular);
            this.mrcRegistro.Controls.Add(this.lstAnioFabricacion);
            this.mrcRegistro.Controls.Add(this.txtDominio);
            this.mrcRegistro.Controls.Add(this.txtNumeroTurno);
            this.mrcRegistro.Controls.Add(this.lblTitular);
            this.mrcRegistro.Controls.Add(this.AnioFabricacion);
            this.mrcRegistro.Controls.Add(this.lblDominio);
            this.mrcRegistro.Controls.Add(this.lblNumeroTurno);
            this.mrcRegistro.Location = new System.Drawing.Point(40, 21);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(642, 206);
            this.mrcRegistro.TabIndex = 0;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro de Turnos";
            // 
            // mrcEstadisticas
            // 
            this.mrcEstadisticas.Controls.Add(this.txt6Caracteres);
            this.mrcEstadisticas.Controls.Add(this.txtMasAntiguo);
            this.mrcEstadisticas.Controls.Add(this.txtCantTurnos);
            this.mrcEstadisticas.Controls.Add(this.lbl6Caracteres);
            this.mrcEstadisticas.Controls.Add(this.lblMasAntiguo);
            this.mrcEstadisticas.Controls.Add(this.lblCantTurnos);
            this.mrcEstadisticas.Location = new System.Drawing.Point(40, 253);
            this.mrcEstadisticas.Name = "mrcEstadisticas";
            this.mrcEstadisticas.Size = new System.Drawing.Size(642, 206);
            this.mrcEstadisticas.TabIndex = 0;
            this.mrcEstadisticas.TabStop = false;
            this.mrcEstadisticas.Text = "Estadisticas";
            // 
            // lblNumeroTurno
            // 
            this.lblNumeroTurno.AutoSize = true;
            this.lblNumeroTurno.Location = new System.Drawing.Point(30, 40);
            this.lblNumeroTurno.Name = "lblNumeroTurno";
            this.lblNumeroTurno.Size = new System.Drawing.Size(112, 16);
            this.lblNumeroTurno.TabIndex = 0;
            this.lblNumeroTurno.Text = "Numero de Turno";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(30, 76);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(57, 16);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // AnioFabricacion
            // 
            this.AnioFabricacion.AutoSize = true;
            this.AnioFabricacion.Location = new System.Drawing.Point(30, 113);
            this.AnioFabricacion.Name = "AnioFabricacion";
            this.AnioFabricacion.Size = new System.Drawing.Size(127, 16);
            this.AnioFabricacion.TabIndex = 2;
            this.AnioFabricacion.Text = "Anio de Fabricacion";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(30, 155);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(44, 16);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // lblCantTurnos
            // 
            this.lblCantTurnos.AutoSize = true;
            this.lblCantTurnos.Location = new System.Drawing.Point(30, 52);
            this.lblCantTurnos.Name = "lblCantTurnos";
            this.lblCantTurnos.Size = new System.Drawing.Size(125, 16);
            this.lblCantTurnos.TabIndex = 0;
            this.lblCantTurnos.Text = "Cantidad de Turnos";
            // 
            // lblMasAntiguo
            // 
            this.lblMasAntiguo.AutoSize = true;
            this.lblMasAntiguo.Location = new System.Drawing.Point(30, 102);
            this.lblMasAntiguo.Name = "lblMasAntiguo";
            this.lblMasAntiguo.Size = new System.Drawing.Size(133, 16);
            this.lblMasAntiguo.TabIndex = 1;
            this.lblMasAntiguo.Text = "Anio del mas Antiguo";
            // 
            // lbl6Caracteres
            // 
            this.lbl6Caracteres.AutoSize = true;
            this.lbl6Caracteres.Location = new System.Drawing.Point(30, 150);
            this.lbl6Caracteres.Name = "lbl6Caracteres";
            this.lbl6Caracteres.Size = new System.Drawing.Size(233, 16);
            this.lbl6Caracteres.TabIndex = 2;
            this.lbl6Caracteres.Text = "Cantidad con dominio de 6 caracteres";
            // 
            // txtNumeroTurno
            // 
            this.txtNumeroTurno.Location = new System.Drawing.Point(226, 34);
            this.txtNumeroTurno.MaxLength = 5;
            this.txtNumeroTurno.Name = "txtNumeroTurno";
            this.txtNumeroTurno.Size = new System.Drawing.Size(104, 22);
            this.txtNumeroTurno.TabIndex = 4;
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(226, 70);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(182, 22);
            this.txtDominio.TabIndex = 5;
            // 
            // lstAnioFabricacion
            // 
            this.lstAnioFabricacion.FormattingEnabled = true;
            this.lstAnioFabricacion.ItemHeight = 16;
            this.lstAnioFabricacion.Location = new System.Drawing.Point(226, 109);
            this.lstAnioFabricacion.Name = "lstAnioFabricacion";
            this.lstAnioFabricacion.Size = new System.Drawing.Size(102, 20);
            this.lstAnioFabricacion.TabIndex = 6;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(226, 149);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(385, 22);
            this.txtTitular.TabIndex = 7;
            // 
            // txtCantTurnos
            // 
            this.txtCantTurnos.Location = new System.Drawing.Point(307, 46);
            this.txtCantTurnos.Name = "txtCantTurnos";
            this.txtCantTurnos.Size = new System.Drawing.Size(107, 22);
            this.txtCantTurnos.TabIndex = 3;
            // 
            // txtMasAntiguo
            // 
            this.txtMasAntiguo.Location = new System.Drawing.Point(307, 96);
            this.txtMasAntiguo.Name = "txtMasAntiguo";
            this.txtMasAntiguo.Size = new System.Drawing.Size(107, 22);
            this.txtMasAntiguo.TabIndex = 4;
            // 
            // txt6Caracteres
            // 
            this.txt6Caracteres.Location = new System.Drawing.Point(307, 144);
            this.txt6Caracteres.Name = "txt6Caracteres";
            this.txt6Caracteres.Size = new System.Drawing.Size(107, 22);
            this.txt6Caracteres.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(734, 21);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(165, 49);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(734, 97);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(165, 47);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(734, 253);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(165, 43);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 483);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcEstadisticas);
            this.Controls.Add(this.mrcRegistro);
            this.Name = "frmMain";
            this.Text = "Auto test";
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            this.mrcEstadisticas.ResumeLayout(false);
            this.mrcEstadisticas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label AnioFabricacion;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblNumeroTurno;
        private System.Windows.Forms.GroupBox mrcEstadisticas;
        private System.Windows.Forms.Label lbl6Caracteres;
        private System.Windows.Forms.Label lblMasAntiguo;
        private System.Windows.Forms.Label lblCantTurnos;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.ListBox lstAnioFabricacion;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.TextBox txtNumeroTurno;
        private System.Windows.Forms.TextBox txt6Caracteres;
        private System.Windows.Forms.TextBox txtMasAntiguo;
        private System.Windows.Forms.TextBox txtCantTurnos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
    }
}

