namespace LaConquista_WF.Formularios.Factura
{
    partial class ModalCobrar
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
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_CAMBIOC = new System.Windows.Forms.TextBox();
            this.Apellido_cliente = new System.Windows.Forms.Label();
            this.TXT_PAGOC = new System.Windows.Forms.TextBox();
            this.BTNINGRESARUSUARIO = new System.Windows.Forms.Button();
            this.BTNSALIRUSUARIO = new System.Windows.Forms.Button();
            this.Nombre_cliente = new System.Windows.Forms.Label();
            this.TXT_TOTALC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(143, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "CAMBIO";
            // 
            // TXT_CAMBIOC
            // 
            this.TXT_CAMBIOC.BackColor = System.Drawing.SystemColors.Info;
            this.TXT_CAMBIOC.Location = new System.Drawing.Point(99, 241);
            this.TXT_CAMBIOC.Multiline = true;
            this.TXT_CAMBIOC.Name = "TXT_CAMBIOC";
            this.TXT_CAMBIOC.Size = new System.Drawing.Size(150, 28);
            this.TXT_CAMBIOC.TabIndex = 33;
            // 
            // Apellido_cliente
            // 
            this.Apellido_cliente.AutoSize = true;
            this.Apellido_cliente.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido_cliente.ForeColor = System.Drawing.Color.Red;
            this.Apellido_cliente.Location = new System.Drawing.Point(161, 139);
            this.Apellido_cliente.Name = "Apellido_cliente";
            this.Apellido_cliente.Size = new System.Drawing.Size(51, 17);
            this.Apellido_cliente.TabIndex = 32;
            this.Apellido_cliente.Text = "PAGO";
            // 
            // TXT_PAGOC
            // 
            this.TXT_PAGOC.BackColor = System.Drawing.SystemColors.Info;
            this.TXT_PAGOC.Location = new System.Drawing.Point(99, 169);
            this.TXT_PAGOC.Multiline = true;
            this.TXT_PAGOC.Name = "TXT_PAGOC";
            this.TXT_PAGOC.Size = new System.Drawing.Size(150, 28);
            this.TXT_PAGOC.TabIndex = 31;
            // 
            // BTNINGRESARUSUARIO
            // 
            this.BTNINGRESARUSUARIO.BackColor = System.Drawing.Color.Black;
            this.BTNINGRESARUSUARIO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNINGRESARUSUARIO.ForeColor = System.Drawing.Color.White;
            this.BTNINGRESARUSUARIO.Location = new System.Drawing.Point(38, 287);
            this.BTNINGRESARUSUARIO.Name = "BTNINGRESARUSUARIO";
            this.BTNINGRESARUSUARIO.Size = new System.Drawing.Size(100, 32);
            this.BTNINGRESARUSUARIO.TabIndex = 30;
            this.BTNINGRESARUSUARIO.Text = "COBRAR";
            this.BTNINGRESARUSUARIO.UseVisualStyleBackColor = false;
            // 
            // BTNSALIRUSUARIO
            // 
            this.BTNSALIRUSUARIO.BackColor = System.Drawing.Color.Black;
            this.BTNSALIRUSUARIO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIRUSUARIO.ForeColor = System.Drawing.Color.White;
            this.BTNSALIRUSUARIO.Location = new System.Drawing.Point(208, 287);
            this.BTNSALIRUSUARIO.Name = "BTNSALIRUSUARIO";
            this.BTNSALIRUSUARIO.Size = new System.Drawing.Size(100, 32);
            this.BTNSALIRUSUARIO.TabIndex = 29;
            this.BTNSALIRUSUARIO.Text = "SALIR";
            this.BTNSALIRUSUARIO.UseVisualStyleBackColor = false;
            // 
            // Nombre_cliente
            // 
            this.Nombre_cliente.AutoSize = true;
            this.Nombre_cliente.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_cliente.ForeColor = System.Drawing.Color.Red;
            this.Nombre_cliente.Location = new System.Drawing.Point(150, 67);
            this.Nombre_cliente.Name = "Nombre_cliente";
            this.Nombre_cliente.Size = new System.Drawing.Size(62, 17);
            this.Nombre_cliente.TabIndex = 28;
            this.Nombre_cliente.Text = "TOTAL";
            this.Nombre_cliente.Click += new System.EventHandler(this.Nombre_cliente_Click);
            // 
            // TXT_TOTALC
            // 
            this.TXT_TOTALC.BackColor = System.Drawing.SystemColors.Info;
            this.TXT_TOTALC.Location = new System.Drawing.Point(99, 99);
            this.TXT_TOTALC.Multiline = true;
            this.TXT_TOTALC.Name = "TXT_TOTALC";
            this.TXT_TOTALC.Size = new System.Drawing.Size(150, 28);
            this.TXT_TOTALC.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "COBRAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ModalCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(343, 331);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_CAMBIOC);
            this.Controls.Add(this.Apellido_cliente);
            this.Controls.Add(this.TXT_PAGOC);
            this.Controls.Add(this.BTNINGRESARUSUARIO);
            this.Controls.Add(this.BTNSALIRUSUARIO);
            this.Controls.Add(this.Nombre_cliente);
            this.Controls.Add(this.TXT_TOTALC);
            this.Controls.Add(this.label1);
            this.Name = "ModalCobrar";
            this.Text = "ModalCobrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_CAMBIOC;
        private System.Windows.Forms.Label Apellido_cliente;
        private System.Windows.Forms.TextBox TXT_PAGOC;
        private System.Windows.Forms.Button BTNINGRESARUSUARIO;
        private System.Windows.Forms.Button BTNSALIRUSUARIO;
        private System.Windows.Forms.Label Nombre_cliente;
        private System.Windows.Forms.TextBox TXT_TOTALC;
        private System.Windows.Forms.Label label1;
    }
}