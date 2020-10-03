namespace LaConquista_WF
{
    partial class AgregarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.Apellido_cliente = new System.Windows.Forms.Label();
            this.Nombre_cliente = new System.Windows.Forms.Label();
            this.TXT_APELLIDO = new System.Windows.Forms.TextBox();
            this.TXT_NOMBRE = new System.Windows.Forms.TextBox();
            this.BTNINGRESARCLIENTE = new System.Windows.Forms.Button();
            this.BTNSALIRCLIENTE = new System.Windows.Forms.Button();
            this.TELEFONO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTTELEFONO = new System.Windows.Forms.TextBox();
            this.TXTIDENTIDAD = new System.Windows.Forms.TextBox();
            this.EMAIL = new System.Windows.Forms.Label();
            this.TXTEMAIL = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "INGRESAR CLIENTE";
            // 
            // Apellido_cliente
            // 
            this.Apellido_cliente.AutoSize = true;
            this.Apellido_cliente.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido_cliente.Location = new System.Drawing.Point(62, 99);
            this.Apellido_cliente.Name = "Apellido_cliente";
            this.Apellido_cliente.Size = new System.Drawing.Size(63, 15);
            this.Apellido_cliente.TabIndex = 13;
            this.Apellido_cliente.Text = "APELLIDO";
            // 
            // Nombre_cliente
            // 
            this.Nombre_cliente.AutoSize = true;
            this.Nombre_cliente.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_cliente.Location = new System.Drawing.Point(68, 54);
            this.Nombre_cliente.Name = "Nombre_cliente";
            this.Nombre_cliente.Size = new System.Drawing.Size(57, 15);
            this.Nombre_cliente.TabIndex = 12;
            this.Nombre_cliente.Text = "NOMBRE";
            this.Nombre_cliente.Click += new System.EventHandler(this.Usuario_Click);
            // 
            // TXT_APELLIDO
            // 
            this.TXT_APELLIDO.BackColor = System.Drawing.SystemColors.Info;
            this.TXT_APELLIDO.Location = new System.Drawing.Point(134, 97);
            this.TXT_APELLIDO.Multiline = true;
            this.TXT_APELLIDO.Name = "TXT_APELLIDO";
            this.TXT_APELLIDO.Size = new System.Drawing.Size(150, 28);
            this.TXT_APELLIDO.TabIndex = 11;
            // 
            // TXT_NOMBRE
            // 
            this.TXT_NOMBRE.BackColor = System.Drawing.SystemColors.Info;
            this.TXT_NOMBRE.Location = new System.Drawing.Point(134, 52);
            this.TXT_NOMBRE.Multiline = true;
            this.TXT_NOMBRE.Name = "TXT_NOMBRE";
            this.TXT_NOMBRE.Size = new System.Drawing.Size(150, 28);
            this.TXT_NOMBRE.TabIndex = 10;
            // 
            // BTNINGRESARCLIENTE
            // 
            this.BTNINGRESARCLIENTE.BackColor = System.Drawing.Color.Black;
            this.BTNINGRESARCLIENTE.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNINGRESARCLIENTE.ForeColor = System.Drawing.Color.White;
            this.BTNINGRESARCLIENTE.Location = new System.Drawing.Point(73, 285);
            this.BTNINGRESARCLIENTE.Name = "BTNINGRESARCLIENTE";
            this.BTNINGRESARCLIENTE.Size = new System.Drawing.Size(100, 32);
            this.BTNINGRESARCLIENTE.TabIndex = 9;
            this.BTNINGRESARCLIENTE.Text = "GUARDAR";
            this.BTNINGRESARCLIENTE.UseVisualStyleBackColor = false;
            this.BTNINGRESARCLIENTE.Click += new System.EventHandler(this.BTNINGRESARCLIENTE_Click);
            // 
            // BTNSALIRCLIENTE
            // 
            this.BTNSALIRCLIENTE.BackColor = System.Drawing.Color.Black;
            this.BTNSALIRCLIENTE.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIRCLIENTE.ForeColor = System.Drawing.Color.White;
            this.BTNSALIRCLIENTE.Location = new System.Drawing.Point(236, 285);
            this.BTNSALIRCLIENTE.Name = "BTNSALIRCLIENTE";
            this.BTNSALIRCLIENTE.Size = new System.Drawing.Size(100, 32);
            this.BTNSALIRCLIENTE.TabIndex = 8;
            this.BTNSALIRCLIENTE.Text = "CANCELAR";
            this.BTNSALIRCLIENTE.UseVisualStyleBackColor = false;
            this.BTNSALIRCLIENTE.Click += new System.EventHandler(this.BTNSALIRCLIENTE_Click);
            // 
            // TELEFONO
            // 
            this.TELEFONO.AutoSize = true;
            this.TELEFONO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TELEFONO.Location = new System.Drawing.Point(57, 186);
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.Size = new System.Drawing.Size(70, 15);
            this.TELEFONO.TabIndex = 17;
            this.TELEFONO.Text = "TELEFONO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "IDENTIDAD/RTN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TXTTELEFONO
            // 
            this.TXTTELEFONO.BackColor = System.Drawing.SystemColors.Info;
            this.TXTTELEFONO.Location = new System.Drawing.Point(134, 184);
            this.TXTTELEFONO.Multiline = true;
            this.TXTTELEFONO.Name = "TXTTELEFONO";
            this.TXTTELEFONO.Size = new System.Drawing.Size(150, 28);
            this.TXTTELEFONO.TabIndex = 15;
            // 
            // TXTIDENTIDAD
            // 
            this.TXTIDENTIDAD.BackColor = System.Drawing.SystemColors.Info;
            this.TXTIDENTIDAD.Location = new System.Drawing.Point(134, 139);
            this.TXTIDENTIDAD.Multiline = true;
            this.TXTIDENTIDAD.Name = "TXTIDENTIDAD";
            this.TXTIDENTIDAD.Size = new System.Drawing.Size(150, 28);
            this.TXTIDENTIDAD.TabIndex = 14;
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSize = true;
            this.EMAIL.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMAIL.Location = new System.Drawing.Point(62, 233);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(59, 15);
            this.EMAIL.TabIndex = 19;
            this.EMAIL.Text = "CORREO";
            // 
            // TXTEMAIL
            // 
            this.TXTEMAIL.BackColor = System.Drawing.SystemColors.Info;
            this.TXTEMAIL.Location = new System.Drawing.Point(134, 231);
            this.TXTEMAIL.Multiline = true;
            this.TXTEMAIL.Name = "TXTEMAIL";
            this.TXTEMAIL.Size = new System.Drawing.Size(150, 28);
            this.TXTEMAIL.TabIndex = 18;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(295, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "[Regresar]";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(358, 13);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(76, 13);
            this.linkLabel2.TabIndex = 21;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "[Cerrar Sesión]";
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(443, 329);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.TXTEMAIL);
            this.Controls.Add(this.TELEFONO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTTELEFONO);
            this.Controls.Add(this.TXTIDENTIDAD);
            this.Controls.Add(this.Apellido_cliente);
            this.Controls.Add(this.Nombre_cliente);
            this.Controls.Add(this.TXT_APELLIDO);
            this.Controls.Add(this.TXT_NOMBRE);
            this.Controls.Add(this.BTNINGRESARCLIENTE);
            this.Controls.Add(this.BTNSALIRCLIENTE);
            this.Controls.Add(this.label1);
            this.Name = "AgregarCliente";
            this.Text = "AgregarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Apellido_cliente;
        private System.Windows.Forms.Label Nombre_cliente;
        private System.Windows.Forms.TextBox TXT_APELLIDO;
        private System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.Button BTNINGRESARCLIENTE;
        private System.Windows.Forms.Button BTNSALIRCLIENTE;
        private System.Windows.Forms.Label TELEFONO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTTELEFONO;
        private System.Windows.Forms.TextBox TXTIDENTIDAD;
        private System.Windows.Forms.Label EMAIL;
        private System.Windows.Forms.TextBox TXTEMAIL;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}