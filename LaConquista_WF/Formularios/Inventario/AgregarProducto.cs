﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LaConquista_WF.Models;
using LaConquista_WF.DB;

namespace LaConquista_WF
{
    public partial class AgregarProducto : Form
    {
        public int? id;
        tbProducto ontbProducto = null;
        public AgregarProducto(int? id=null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
            {
                CargaDatos();
            }
        }
        private void CargaDatos()
        {
            using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
            {
                ontbProducto = db.tbProducto.Find(id);

                txt_Codigo.Text = ontbProducto.produ_Codigo;
                txt_Descripcion.Text = ontbProducto.produ_Descripcion;
                txt_PrecioCompra.Text = Convert.ToString(ontbProducto.produ_PrecioCompra);
                txt_PrecioVenta.Text = Convert.ToString(ontbProducto.produ_PrecioVenta);
                txt_Cantidad.Text = Convert.ToString(ontbProducto.produ_Cantidad);
                cbx_Categoria.Text = Convert.ToString(ontbProducto.cprod_Id);
                cbx_Categoria.Text = ontbProducto.produ_Categoria;
                cbx_Proveedor.Text = Convert.ToString(ontbProducto.prove_IdProveedor);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void BTNSALIRPRODUCTO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaLaConquistaDataSet2.tbProveedor' Puede moverla o quitarla según sea necesario.
            this.tbProveedorTableAdapter.Fill(this.sistemaLaConquistaDataSet2.tbProveedor);
            // TODO: esta línea de código carga datos en la tabla 'sistemaLaConquistaDataSet1.tbCatalogoProductos' Puede moverla o quitarla según sea necesario.
            this.tbCatalogoProductosTableAdapter1.Fill(this.sistemaLaConquistaDataSet1.tbCatalogoProductos);
            // TODO: esta línea de código carga datos en la tabla 'sistemaLaConquistaDataSet.tbCatalogoProductos' Puede moverla o quitarla según sea necesario.
            this.tbCatalogoProductosTableAdapter.Fill(this.sistemaLaConquistaDataSet.tbCatalogoProductos);
        }

        private void BTNINGRESARPRODUCTO_Click(object sender, EventArgs e)
        {
            try
            {
                using (SistemaLaConquistaEntities db = new SistemaLaConquistaEntities())
                {
                    if(id == null)
                    {
                         ontbProducto = new tbProducto();
                        ontbProducto.produ_Codigo = txt_Codigo.Text;
                        ontbProducto.produ_Descripcion = txt_Descripcion.Text;
                        ontbProducto.produ_PrecioCompra = Convert.ToDecimal(txt_PrecioCompra.Text);
                        ontbProducto.produ_PrecioVenta = Convert.ToDecimal(txt_PrecioVenta.Text);
                        ontbProducto.produ_Cantidad = Convert.ToDecimal(txt_Cantidad.Text);
                        ontbProducto.cprod_Id = Convert.ToInt32(cbx_Categoria.SelectedValue);
                        ontbProducto.produ_Categoria = cbx_Categoria.Text;
                        ontbProducto.prove_IdProveedor = Convert.ToInt32(cbx_Proveedor.SelectedValue);// cbx_Proveedor.Text;
                        ontbProducto.produ_Estado = true;
                        ontbProducto.FechaCrea = DateTime.Now;
                        ontbProducto.UsuarioCrea = 5;
                        db.tbProducto.Add(ontbProducto);
                        db.SaveChanges();
                        MessageBox.Show("Datos ingresado correctamente!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ontbProducto.produ_Codigo = txt_Codigo.Text;
                        ontbProducto.produ_Descripcion = txt_Descripcion.Text;
                        ontbProducto.produ_PrecioCompra = Convert.ToDecimal(txt_PrecioCompra.Text);
                        ontbProducto.produ_PrecioVenta = Convert.ToDecimal(txt_PrecioVenta.Text);
                        ontbProducto.produ_Cantidad = Convert.ToDecimal(txt_Cantidad.Text);
                        ontbProducto.cprod_Id = Convert.ToInt32(cbx_Categoria.SelectedValue);
                        ontbProducto.produ_Categoria = cbx_Categoria.Text;
                        ontbProducto.prove_IdProveedor = Convert.ToInt32(cbx_Proveedor.SelectedValue);// cbx_Proveedor.Text;
                        ontbProducto.produ_Estado = true;
                        ontbProducto.UsuarioModifica = 5;
                        ontbProducto.FechaModifica = DateTime.Now;
                        db.Entry(ontbProducto).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Datos editado correctamente!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al Guardar: " + ex.Message);
            }
        }
    }
}
