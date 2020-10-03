using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaConquista_WF.Formularios.Factura;

namespace LaConquista_WF.Formularios.Factura
{
    public partial class ModalCobrar : Form
    {
        public ModalCobrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_cliente_Click(object sender, EventArgs e)
        {

        }

        private void BTNSALIRUSUARIO_Click(object sender, EventArgs e)
        {
            IngresarFactura ingresarFactura = new IngresarFactura();
            ingresarFactura.Show();
            this.Close();
        }
    }
}
