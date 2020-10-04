using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaConquista_WF.DB;
namespace LaConquista_WF
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListadoCliente listadoCliente = new ListadoCliente();
            listadoCliente.Show();
            this.Close();
        }

        private void BTNINGRESARCLIENTE_Click(object sender, EventArgs e)
        {
            //try
            //{
                using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
                {
                    tbCliente ontbCliente = new tbCliente();
                ontbCliente.clint_Nombre = "Joshua"; //txt_Nombre.Text;
                    ontbCliente.clint_Apellido = "Aguilar";//txt_Apellido.Text;
                ontbCliente.clint_Identificacion = "0610-2000-00093";//txt_Identificacion.Text;
                ontbCliente.clint_Telefono = "8819-8991"; // txt_Telefono.Text;
                    //ontbCliente.clint_Direccion = txt_Direccion.Text;
                    ontbCliente.clint_Direccion = "La pradera";
                ontbCliente.clint_Correo = "joshua.aguilar@unah.hn"; // txt_Correo.Text;
                    ontbCliente.clint_Estado = true;
                    ontbCliente.UsuarioCrea = 5;
                    ontbCliente.FechaCrea = DateTime.Now;
                    db.tbCliente.Add(ontbCliente);
                    db.SaveChanges();
                }
            //}
            //catch(Exception ex)
            //{
              //  MessageBox.Show("Error al Guardar: " + ex.ToString());
            //}
            
        }

        private void BTNSALIRCLIENTE_Click(object sender, EventArgs e)
        {
            ListadoCliente listadoCliente = new ListadoCliente();
            listadoCliente.Show();
            this.Close();
        }
    }
}
