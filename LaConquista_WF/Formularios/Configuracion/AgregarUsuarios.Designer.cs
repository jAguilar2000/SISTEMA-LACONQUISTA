namespace LaConquista_WF
{
    partial class AgregarUsuarios
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
            this.Nombre_cliente = new System.Windows.Forms.Label();
            this.TXT_NOMBRE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TELEFONO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_CONTRASENNA = new System.Windows.Forms.TextBox();
            this.TXT_USUARIO = new System.Windows.Forms.TextBox();
            this.Apellido_cliente = new System.Windows.Forms.Label();
            this.TXT_APELLIDO = new System.Windows.Forms.TextBox();
            this.BTNINGRESARUSUARIO = new System.Windows.Forms.Button();
            this.BTNSALIRUSUARIO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nombre_cliente
            // 
            this.Nombre_cliente.AutoSize = true;
            this.Nombre_cliente.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_cliente.Location = new System.Drawing.Point(52, 66);
            this.Nombre_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre_cliente.Name = "Nombre_cliente";
            this.Nombre_cliente.Size = new System.Drawing.Size(76, 17);
            this.Nombre_cliente.TabIndex = 15;
            this.Nombre_cliente.Text = "NOMBRE";
            // 
            // TXT_NOMBRE
            // 
            this.TXT_NOMBRE.BackColor = System.Drawing.SystemColors.Info;
            this.TXT_NOMBRE.Location = new System.Drawing.Point(149, 64);
            this.TXT_NOMBRE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_NOMBRE.MaxLength = 200;
            this.TXT_NOMBRE.Multiline = true;
            this.TXT_NOMBRE.Name = "TXT_NOMBRE";
            this.TXT_NOMBRE.Size = new System.Drawing.Size(199, 34);
            this.TXT_NOMBRE.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "INGRESAR USUARIO";
            // 
            // TELEFONO
            // 
            this.TELEFONO.AutoSize = true;
            this.TELEFONO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TELEFONO.Location = new System.Drawing.Point(21, 228);
            this.TELEFONO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.Size = new System.Drawing.Size(115, 17);
            this.TELEFONO.TabIndex = 25;
            this.TELEFONO.Text = "CONTRASEÑA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "USUARIO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TXT_CONTRASENNA
            // 
            this.TXT_CONTRASENNA.BackColor = System.Drawing.SystemColors.Info;
            this.TXT_CONTRASENNA.Location = new System.Drawing.Point(149, 225);
            this.TXT_CONTRASENNA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_CONTRASENNA.MaxLength = 50;
            this.TXT_CONTRASENNA.Multiline = true;
            this.TXT_CONTRASENNA.Name = "TXT_CONTRASENNA";
            this.TXT_CONTRASENNA.Size = new System.Drawing.Size(199, 34);
            this.TXT_CONTRASENNA.TabIndex = 23;
            // 
            // TXT_USUARIO
            // 
            this.TXT_USUARIO.BackColor = System.Drawing.SystemColors.Info;
            this.TXT_USUARIO.Location = new System.Drawing.Point(149, 170);
            this.TXT_USUARIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_USUARIO.MaxLength = 200;
            this.TXT_USUARIO.Multiline = true;
            this.TXT_USUARIO.Name = "TXT_USUARIO";
            this.TXT_USUARIO.Size = new System.Drawing.Size(199, 34);
            this.TXT_USUARIO.TabIndex = 22;
            // 
            // Apellido_cliente
            // 
            this.Apellido_cliente.AutoSize = true;
            this.Apellido_cliente.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido_cliente.Location = new System.Drawing.Point(45, 121);
            this.Apellido_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Apellido_cliente.Name = "Apellido_cliente";
            this.Apellido_cliente.Size = new System.Drawing.Size(82, 17);
            this.Apellido_cliente.TabIndex = 21;
            this.Apellido_cliente.Text = "APELLIDO";
            // 
            // TXT_APELLIDO
            // 
            this.TXT_APELLIDO.BackColor = System.Drawing.SystemColors.Info;
            this.TXT_APELLIDO.Location = new System.Drawing.Point(149, 118);
            this.TXT_APELLIDO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TXT_APELLIDO.MaxLength = 200;
            this.TXT_APELLIDO.Multiline = true;
            this.TXT_APELLIDO.Name = "TXT_APELLIDO";
            this.TXT_APELLIDO.Size = new System.Drawing.Size(199, 34);
            this.TXT_APELLIDO.TabIndex = 20;
            // 
            // BTNINGRESARUSUARIO
            // 
            this.BTNINGRESARUSUARIO.BackColor = System.Drawing.Color.Black;
            this.BTNINGRESARUSUARIO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNINGRESARUSUARIO.ForeColor = System.Drawing.Color.White;
            this.BTNINGRESARUSUARIO.Location = new System.Drawing.Point(61, 289);
            this.BTNINGRESARUSUARIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNINGRESARUSUARIO.Name = "BTNINGRESARUSUARIO";
            this.BTNINGRESARUSUARIO.Size = new System.Drawing.Size(133, 39);
            this.BTNINGRESARUSUARIO.TabIndex = 19;
            this.BTNINGRESARUSUARIO.Text = "INGRESAR";
            this.BTNINGRESARUSUARIO.UseVisualStyleBackColor = false;
            this.BTNINGRESARUSUARIO.Click += new System.EventHandler(this.BTNINGRESARUSUARIO_Click);
            // 
            // BTNSALIRUSUARIO
            // 
            this.BTNSALIRUSUARIO.BackColor = System.Drawing.Color.Black;
            this.BTNSALIRUSUARIO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIRUSUARIO.ForeColor = System.Drawing.Color.White;
            this.BTNSALIRUSUARIO.Location = new System.Drawing.Point(285, 289);
            this.BTNSALIRUSUARIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNSALIRUSUARIO.Name = "BTNSALIRUSUARIO";
            this.BTNSALIRUSUARIO.Size = new System.Drawing.Size(133, 39);
            this.BTNSALIRUSUARIO.TabIndex = 18;
            this.BTNSALIRUSUARIO.Text = "SALIR";
            this.BTNSALIRUSUARIO.UseVisualStyleBackColor = false;
            // 
            // AgregarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(435, 380);
            this.Controls.Add(this.TELEFONO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_CONTRASENNA);
            this.Controls.Add(this.TXT_USUARIO);
            this.Controls.Add(this.Apellido_cliente);
            this.Controls.Add(this.TXT_APELLIDO);
            this.Controls.Add(this.BTNINGRESARUSUARIO);
            this.Controls.Add(this.BTNSALIRUSUARIO);
            this.Controls.Add(this.Nombre_cliente);
            this.Controls.Add(this.TXT_NOMBRE);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AgregarUsuarios";
            this.Text = "AgregarUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre_cliente;
        private System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TELEFONO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_CONTRASENNA;
        private System.Windows.Forms.TextBox TXT_USUARIO;
        private System.Windows.Forms.Label Apellido_cliente;
        private System.Windows.Forms.TextBox TXT_APELLIDO;
        private System.Windows.Forms.Button BTNINGRESARUSUARIO;
        private System.Windows.Forms.Button BTNSALIRUSUARIO;
    }
}