using LaConquista_WF.Models;
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
    public partial class ListadoUsuarios : Form
    {
        public ListadoUsuarios()
        {
            InitializeComponent();
        }

        private void dataGridViewUSUARIOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void ListadoUsuarios_Load(object sender, EventArgs e)
        { 
            refrescar();
        }

        private void BTNINGRESARUSUARIO_Click(object sender, EventArgs e)
        {
            AgregarUsuarios add = new AgregarUsuarios();
            add.ShowDialog();
            refrescar();
        }

        #region generales
        private void refrescar()
        {
            try
            {
                using (SistemaLaConquistaEntities model = new SistemaLaConquistaEntities())
                {
                    var lst = from obj in model.tbUsuario
                              select obj;
                    dataGridViewUSUARIOS.DataSource = lst.ToList();

                }
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

    }
}
