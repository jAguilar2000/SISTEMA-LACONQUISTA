using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaConquista_WF.Formularios.Factura;
using System.Windows.Forms;

namespace LaConquista_WF
{
    public partial class IngresarFactura : Form
    {
        public IngresarFactura()
        {
            InitializeComponent();
        }

        private void IngresarFactura_Load(object sender, EventArgs e)
        {

        }

        private void Nombre_cliente_Click(object sender, EventArgs e)
        {

        }

        private void TXT_CODIGO_TextChanged(object sender, EventArgs e)
        {

        }

        private void Apellido_cliente_Click(object sender, EventArgs e)
        {

        }

        private void TXT_DESCRIPCION_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TXTIDESCUENTO_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNMENU_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void BTNCOBRAR_Click(object sender, EventArgs e)
        {
            ModalCobrar modalCobrar = new ModalCobrar();
            modalCobrar.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
