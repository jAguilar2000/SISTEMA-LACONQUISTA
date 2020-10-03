using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaConquista_WF
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListadoProducto listadoProducto = new ListadoProducto();
            listadoProducto.Show();
            this.Close();
        }

        private void BTNSALIRPRODUCTO_Click(object sender, EventArgs e)
        {
            ListadoProducto listadoProducto = new ListadoProducto();
            listadoProducto.Show();
            this.Close();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
