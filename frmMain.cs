using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmaniniSP3_1
{
    public partial class frmMain : Form
    {
        
       
            //declarar variables globales
            int NumeroTurno;
            string Dominio;
            int AnioFabricacion;
            string Titular;
        

        // constante para la cantidad total de elementos del arreglo
        const int MAX = 50;
        // variable para controlar la cantidad de elementos cargados
        public int Cantidad = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void txtNumeroTurno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            
            this.Close();  
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            NumeroTurno = int.Parse(txtNumeroTurno.Text);
            Dominio = txtDominio.Text;
            AnioFabricacion = Convert.ToInt32(nudAnioFabricacion.Text);
            Titular = txtTitular.Text;

            MessageBox.Show("Registro realizado", "Registro", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarInterfaz();
        }

        private void LimpiarInterfaz()
        {
            txtNumeroTurno.Clear();
            txtDominio.Clear();
            nudAnioFabricacion.Value = 2022;
            txtTitular.Clear();
            txtNumeroTurno.Focus();
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
