using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaConquista_WF.Models;
using LaConquista_WF.Helpers;


namespace LaConquista_WF
{
    public partial class AgregarUsuarios : Form
    {
        public AgregarUsuarios()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BTNINGRESARUSUARIO_Click(object sender, EventArgs e)
        {
            using (SistemaLaConquistaEntities model = new SistemaLaConquistaEntities())
            {
                Utilidades u = new Utilidades();
                tbUsuario usuarios = new tbUsuario();
                usuarios.user_Nombre = TXT_NOMBRE.Text;
                usuarios.user_Apellido = TXT_APELLIDO.Text;
                usuarios.user_NombreUsuario = TXT_USUARIO.Text;
                usuarios.user_FechaCreacion = DateTime.Now;
                
                model.tbUsuario.Add(usuarios);
                model.SaveChanges();
                this.Hide();
            }
        }
    }
}
