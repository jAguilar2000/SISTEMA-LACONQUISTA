namespace LaConquista_WF
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
            this.TELEFONO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTPRECIO = new System.Windows.Forms.TextBox();
            this.Apellido_cliente = new System.Windows.Forms.Label();
            this.Nombre_cliente = new System.Windows.Forms.Label();
            this.TXT_DESCRIPCION = new System.Windows.Forms.TextBox();
            this.TXT_CODIGO = new System.Windows.Forms.TextBox();
            this.BTNINGRESARPRODUCTO = new System.Windows.Forms.Button();
            this.BTNSALIRPRODUCTO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBCATEGORIA = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TELEFONO
            // 
            this.TELEFONO.AutoSize = true;
            this.TELEFONO.Location = new System.Drawing.Point(69, 188);
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.Size = new System.Drawing.Size(69, 13);
            this.TELEFONO.TabIndex = 30;
            this.TELEFONO.Text = "CATÉGORIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "PRECIO";
            // 
            // TXTPRECIO
            // 
            this.TXTPRECIO.BackColor = System.Drawing.SystemColors.Info;
            this.TXTPRECIO.Location = new System.Drawing.Point(143, 140);
            this.TXTPRECIO.Multiline = true;
            this.TXTPRECIO.Name = "TXTPRECIO";
            this.TXTPRECIO.Size = new System.Drawing.Size(150, 28);
            this.TXTPRECIO.TabIndex = 27;
            // 
            // Apellido_cliente
            // 
            this.Apellido_cliente.AutoSize = true;
            this.Apellido_cliente.Location = new System.Drawing.Point(58, 101);
            this.Apellido_cliente.Name = "Apellido_cliente";
            this.Apellido_cliente.Size = new System.Drawing.Size(80, 13);
            this.Apellido_cliente.TabIndex = 26;
            this.Apellido_cliente.Text = "DESCRIPCIÓN";
            // 
            // Nombre_cliente
            // 
            this.Nombre_cliente.AutoSize = true;
            this.Nombre_cliente.Location = new System.Drawing.Point(88, 56);
            this.Nombre_cliente.Name = "Nombre_cliente";
            this.Nombre_cliente.Size = new System.Drawing.Size(49, 13);
            this.Nombre_cliente.TabIndex = 25;
            this.Nombre_cliente.Text = "CÓDIGO";
            // 
            // TXT_DESCRIPCION
            // 
            this.TXT_DESCRIPCION.BackColor = System.Drawing.SystemColors.Info;
            this.TXT_DESCRIPCION.Location = new System.Drawing.Point(143, 98);
            this.TXT_DESCRIPCION.Multiline = true;
            this.TXT_DESCRIPCION.Name = "TXT_DESCRIPCION";
            this.TXT_DESCRIPCION.Size = new System.Drawing.Size(150, 28);
            this.TXT_DESCRIPCION.TabIndex = 24;
            // 
            // TXT_CODIGO
            // 
            this.TXT_CODIGO.BackColor = System.Drawing.SystemColors.Info;
            this.TXT_CODIGO.Location = new System.Drawing.Point(143, 53);
            this.TXT_CODIGO.Multiline = true;
            this.TXT_CODIGO.Name = "TXT_CODIGO";
            this.TXT_CODIGO.Size = new System.Drawing.Size(150, 28);
            this.TXT_CODIGO.TabIndex = 23;
            // 
            // BTNINGRESARPRODUCTO
            // 
            this.BTNINGRESARPRODUCTO.BackColor = System.Drawing.Color.Black;
            this.BTNINGRESARPRODUCTO.ForeColor = System.Drawing.Color.White;
            this.BTNINGRESARPRODUCTO.Location = new System.Drawing.Point(72, 245);
            this.BTNINGRESARPRODUCTO.Name = "BTNINGRESARPRODUCTO";
            this.BTNINGRESARPRODUCTO.Size = new System.Drawing.Size(100, 32);
            this.BTNINGRESARPRODUCTO.TabIndex = 22;
            this.BTNINGRESARPRODUCTO.Text = "INGRESAR";
            this.BTNINGRESARPRODUCTO.UseVisualStyleBackColor = false;
            // 
            // BTNSALIRPRODUCTO
            // 
            this.BTNSALIRPRODUCTO.BackColor = System.Drawing.Color.Black;
            this.BTNSALIRPRODUCTO.ForeColor = System.Drawing.Color.White;
            this.BTNSALIRPRODUCTO.Location = new System.Drawing.Point(245, 245);
            this.BTNSALIRPRODUCTO.Name = "BTNSALIRPRODUCTO";
            this.BTNSALIRPRODUCTO.Size = new System.Drawing.Size(100, 32);
            this.BTNSALIRPRODUCTO.TabIndex = 21;
            this.BTNSALIRPRODUCTO.Text = "SALIR";
            this.BTNSALIRPRODUCTO.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "INGRESAR PRODUCTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CBCATEGORIA
            // 
            this.CBCATEGORIA.FormattingEnabled = true;
            this.CBCATEGORIA.Location = new System.Drawing.Point(143, 188);
            this.CBCATEGORIA.Name = "CBCATEGORIA";
            this.CBCATEGORIA.Size = new System.Drawing.Size(150, 21);
            this.CBCATEGORIA.TabIndex = 31;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(385, 301);
            this.Controls.Add(this.CBCATEGORIA);
            this.Controls.Add(this.TELEFONO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTPRECIO);
            this.Controls.Add(this.Apellido_cliente);
            this.Controls.Add(this.Nombre_cliente);
            this.Controls.Add(this.TXT_DESCRIPCION);
            this.Controls.Add(this.TXT_CODIGO);
            this.Controls.Add(this.BTNINGRESARPRODUCTO);
            this.Controls.Add(this.BTNSALIRPRODUCTO);
            this.Controls.Add(this.label1);
            this.Name = "AgregarProducto";
            this.Text = "AgregarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TELEFONO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTPRECIO;
        private System.Windows.Forms.Label Apellido_cliente;
        private System.Windows.Forms.Label Nombre_cliente;
        private System.Windows.Forms.TextBox TXT_DESCRIPCION;
        private System.Windows.Forms.TextBox TXT_CODIGO;
        private System.Windows.Forms.Button BTNINGRESARPRODUCTO;
        private System.Windows.Forms.Button BTNSALIRPRODUCTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBCATEGORIA;
    }
}