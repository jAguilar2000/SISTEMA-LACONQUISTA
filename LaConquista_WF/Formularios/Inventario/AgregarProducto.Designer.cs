﻿namespace LaConquista_WF
{
    partial class AgregarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TELEFONO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PrecioCompra = new System.Windows.Forms.TextBox();
            this.Apellido_cliente = new System.Windows.Forms.Label();
            this.Nombre_cliente = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.BTNINGRESARPRODUCTO = new System.Windows.Forms.Button();
            this.BTNSALIRPRODUCTO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PrecioVenta = new System.Windows.Forms.TextBox();
            this.cbx_Proveedor = new System.Windows.Forms.ComboBox();
            this.tbProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaLaConquistaDataSet2 = new LaConquista_WF.SistemaLaConquistaDataSet2();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.sistemaLaConquistaDataSet = new LaConquista_WF.SistemaLaConquistaDataSet();
            this.tbCatalogoProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCatalogoProductosTableAdapter = new LaConquista_WF.SistemaLaConquistaDataSetTableAdapters.tbCatalogoProductosTableAdapter();
            this.cbx_Categoria = new System.Windows.Forms.ComboBox();
            this.tbCatalogoProductosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaLaConquistaDataSet1 = new LaConquista_WF.SistemaLaConquistaDataSet1();
            this.tbCatalogoProductosTableAdapter1 = new LaConquista_WF.SistemaLaConquistaDataSet1TableAdapters.tbCatalogoProductosTableAdapter();
            this.tbProveedorTableAdapter = new LaConquista_WF.SistemaLaConquistaDataSet2TableAdapters.tbProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLaConquistaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLaConquistaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatalogoProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatalogoProductosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLaConquistaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TELEFONO
            // 
            this.TELEFONO.AutoSize = true;
            this.TELEFONO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TELEFONO.Location = new System.Drawing.Point(62, 277);
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.Size = new System.Drawing.Size(79, 15);
            this.TELEFONO.TabIndex = 30;
            this.TELEFONO.Text = "CATÉGORIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "PRECIO COMPRA";
            // 
            // txt_PrecioCompra
            // 
            this.txt_PrecioCompra.BackColor = System.Drawing.SystemColors.Info;
            this.txt_PrecioCompra.Location = new System.Drawing.Point(143, 140);
            this.txt_PrecioCompra.Multiline = true;
            this.txt_PrecioCompra.Name = "txt_PrecioCompra";
            this.txt_PrecioCompra.Size = new System.Drawing.Size(150, 28);
            this.txt_PrecioCompra.TabIndex = 27;
            // 
            // Apellido_cliente
            // 
            this.Apellido_cliente.AutoSize = true;
            this.Apellido_cliente.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido_cliente.Location = new System.Drawing.Point(51, 100);
            this.Apellido_cliente.Name = "Apellido_cliente";
            this.Apellido_cliente.Size = new System.Drawing.Size(86, 15);
            this.Apellido_cliente.TabIndex = 26;
            this.Apellido_cliente.Text = "DESCRIPCIÓN";
            // 
            // Nombre_cliente
            // 
            this.Nombre_cliente.AutoSize = true;
            this.Nombre_cliente.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_cliente.Location = new System.Drawing.Point(81, 55);
            this.Nombre_cliente.Name = "Nombre_cliente";
            this.Nombre_cliente.Size = new System.Drawing.Size(57, 15);
            this.Nombre_cliente.TabIndex = 25;
            this.Nombre_cliente.Text = "CÓDIGO";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Descripcion.Location = new System.Drawing.Point(143, 98);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(150, 28);
            this.txt_Descripcion.TabIndex = 24;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Codigo.Location = new System.Drawing.Point(143, 53);
            this.txt_Codigo.Multiline = true;
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(150, 28);
            this.txt_Codigo.TabIndex = 23;
            // 
            // BTNINGRESARPRODUCTO
            // 
            this.BTNINGRESARPRODUCTO.BackColor = System.Drawing.Color.Black;
            this.BTNINGRESARPRODUCTO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNINGRESARPRODUCTO.ForeColor = System.Drawing.Color.White;
            this.BTNINGRESARPRODUCTO.Location = new System.Drawing.Point(70, 385);
            this.BTNINGRESARPRODUCTO.Name = "BTNINGRESARPRODUCTO";
            this.BTNINGRESARPRODUCTO.Size = new System.Drawing.Size(100, 32);
            this.BTNINGRESARPRODUCTO.TabIndex = 22;
            this.BTNINGRESARPRODUCTO.Text = "GUARDAR";
            this.BTNINGRESARPRODUCTO.UseVisualStyleBackColor = false;
            this.BTNINGRESARPRODUCTO.Click += new System.EventHandler(this.BTNINGRESARPRODUCTO_Click);
            // 
            // BTNSALIRPRODUCTO
            // 
            this.BTNSALIRPRODUCTO.BackColor = System.Drawing.Color.Black;
            this.BTNSALIRPRODUCTO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIRPRODUCTO.ForeColor = System.Drawing.Color.White;
            this.BTNSALIRPRODUCTO.Location = new System.Drawing.Point(243, 385);
            this.BTNSALIRPRODUCTO.Name = "BTNSALIRPRODUCTO";
            this.BTNSALIRPRODUCTO.Size = new System.Drawing.Size(100, 32);
            this.BTNSALIRPRODUCTO.TabIndex = 21;
            this.BTNSALIRPRODUCTO.Text = "CANCELAR";
            this.BTNSALIRPRODUCTO.UseVisualStyleBackColor = false;
            this.BTNSALIRPRODUCTO.Click += new System.EventHandler(this.BTNSALIRPRODUCTO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "INGRESAR PRODUCTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "PRECIO VENTA";
            // 
            // txt_PrecioVenta
            // 
            this.txt_PrecioVenta.BackColor = System.Drawing.SystemColors.Info;
            this.txt_PrecioVenta.Location = new System.Drawing.Point(143, 186);
            this.txt_PrecioVenta.Multiline = true;
            this.txt_PrecioVenta.Name = "txt_PrecioVenta";
            this.txt_PrecioVenta.Size = new System.Drawing.Size(150, 28);
            this.txt_PrecioVenta.TabIndex = 32;
            // 
            // cbx_Proveedor
            // 
            this.cbx_Proveedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbProveedorBindingSource, "prove_IdProveedor", true));
            this.cbx_Proveedor.DataSource = this.tbProveedorBindingSource;
            this.cbx_Proveedor.DisplayMember = "prove_Nombre";
            this.cbx_Proveedor.FormattingEnabled = true;
            this.cbx_Proveedor.Location = new System.Drawing.Point(143, 313);
            this.cbx_Proveedor.Name = "cbx_Proveedor";
            this.cbx_Proveedor.Size = new System.Drawing.Size(150, 21);
            this.cbx_Proveedor.TabIndex = 35;
            this.cbx_Proveedor.ValueMember = "prove_IdProveedor";
            // 
            // tbProveedorBindingSource
            // 
            this.tbProveedorBindingSource.DataMember = "tbProveedor";
            this.tbProveedorBindingSource.DataSource = this.sistemaLaConquistaDataSet2;
            // 
            // sistemaLaConquistaDataSet2
            // 
            this.sistemaLaConquistaDataSet2.DataSetName = "SistemaLaConquistaDataSet2";
            this.sistemaLaConquistaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "PROVEEDOR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "CANTIDAD";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Cantidad.Location = new System.Drawing.Point(143, 226);
            this.txt_Cantidad.Multiline = true;
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(150, 28);
            this.txt_Cantidad.TabIndex = 38;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(306, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 13);
            this.linkLabel1.TabIndex = 42;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "[Regresar]";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(362, 16);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(76, 13);
            this.linkLabel2.TabIndex = 43;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "[Cerrar Sesión]";
            // 
            // sistemaLaConquistaDataSet
            // 
            this.sistemaLaConquistaDataSet.DataSetName = "SistemaLaConquistaDataSet";
            this.sistemaLaConquistaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCatalogoProductosBindingSource
            // 
            this.tbCatalogoProductosBindingSource.DataMember = "tbCatalogoProductos";
            this.tbCatalogoProductosBindingSource.DataSource = this.sistemaLaConquistaDataSet;
            // 
            // tbCatalogoProductosTableAdapter
            // 
            this.tbCatalogoProductosTableAdapter.ClearBeforeFill = true;
            // 
            // cbx_Categoria
            // 
            this.cbx_Categoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbCatalogoProductosBindingSource1, "cprod_Descripcion", true));
            this.cbx_Categoria.DataSource = this.tbCatalogoProductosBindingSource1;
            this.cbx_Categoria.DisplayMember = "cprod_Descripcion";
            this.cbx_Categoria.FormattingEnabled = true;
            this.cbx_Categoria.Location = new System.Drawing.Point(143, 270);
            this.cbx_Categoria.Name = "cbx_Categoria";
            this.cbx_Categoria.Size = new System.Drawing.Size(150, 21);
            this.cbx_Categoria.TabIndex = 44;
            this.cbx_Categoria.ValueMember = "cprod_Id";
            // 
            // tbCatalogoProductosBindingSource1
            // 
            this.tbCatalogoProductosBindingSource1.DataMember = "tbCatalogoProductos";
            this.tbCatalogoProductosBindingSource1.DataSource = this.sistemaLaConquistaDataSet1;
            // 
            // sistemaLaConquistaDataSet1
            // 
            this.sistemaLaConquistaDataSet1.DataSetName = "SistemaLaConquistaDataSet1";
            this.sistemaLaConquistaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCatalogoProductosTableAdapter1
            // 
            this.tbCatalogoProductosTableAdapter1.ClearBeforeFill = true;
            // 
            // tbProveedorTableAdapter
            // 
            this.tbProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(446, 424);
            this.Controls.Add(this.cbx_Categoria);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.cbx_Proveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PrecioVenta);
            this.Controls.Add(this.TELEFONO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_PrecioCompra);
            this.Controls.Add(this.Apellido_cliente);
            this.Controls.Add(this.Nombre_cliente);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.BTNINGRESARPRODUCTO);
            this.Controls.Add(this.BTNSALIRPRODUCTO);
            this.Controls.Add(this.label1);
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            this.Load += new System.EventHandler(this.AgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLaConquistaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLaConquistaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatalogoProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatalogoProductosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaLaConquistaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TELEFONO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PrecioCompra;
        private System.Windows.Forms.Label Apellido_cliente;
        private System.Windows.Forms.Label Nombre_cliente;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Button BTNINGRESARPRODUCTO;
        private System.Windows.Forms.Button BTNSALIRPRODUCTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PrecioVenta;
        private System.Windows.Forms.ComboBox cbx_Proveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private SistemaLaConquistaDataSet sistemaLaConquistaDataSet;
        private System.Windows.Forms.BindingSource tbCatalogoProductosBindingSource;
        private SistemaLaConquistaDataSetTableAdapters.tbCatalogoProductosTableAdapter tbCatalogoProductosTableAdapter;
        private System.Windows.Forms.ComboBox cbx_Categoria;
        private SistemaLaConquistaDataSet1 sistemaLaConquistaDataSet1;
        private System.Windows.Forms.BindingSource tbCatalogoProductosBindingSource1;
        private SistemaLaConquistaDataSet1TableAdapters.tbCatalogoProductosTableAdapter tbCatalogoProductosTableAdapter1;
        private SistemaLaConquistaDataSet2 sistemaLaConquistaDataSet2;
        private System.Windows.Forms.BindingSource tbProveedorBindingSource;
        private SistemaLaConquistaDataSet2TableAdapters.tbProveedorTableAdapter tbProveedorTableAdapter;
    }
}