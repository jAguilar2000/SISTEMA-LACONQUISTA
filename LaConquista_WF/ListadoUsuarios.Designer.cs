namespace LaConquista_WF
{
    partial class ListadoUsuarios
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
            this.BTNSALIRUSUARIO = new System.Windows.Forms.Button();
            this.BTNINGRESARUSUARIO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUSUARIOS = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUSUARIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNSALIRUSUARIO
            // 
            this.BTNSALIRUSUARIO.BackColor = System.Drawing.Color.Black;
            this.BTNSALIRUSUARIO.ForeColor = System.Drawing.Color.White;
            this.BTNSALIRUSUARIO.Location = new System.Drawing.Point(326, 255);
            this.BTNSALIRUSUARIO.Name = "BTNSALIRUSUARIO";
            this.BTNSALIRUSUARIO.Size = new System.Drawing.Size(100, 32);
            this.BTNSALIRUSUARIO.TabIndex = 9;
            this.BTNSALIRUSUARIO.Text = "SALIR";
            this.BTNSALIRUSUARIO.UseVisualStyleBackColor = false;
            // 
            // BTNINGRESARUSUARIO
            // 
            this.BTNINGRESARUSUARIO.BackColor = System.Drawing.Color.Black;
            this.BTNINGRESARUSUARIO.ForeColor = System.Drawing.Color.White;
            this.BTNINGRESARUSUARIO.Location = new System.Drawing.Point(12, 255);
            this.BTNINGRESARUSUARIO.Name = "BTNINGRESARUSUARIO";
            this.BTNINGRESARUSUARIO.Size = new System.Drawing.Size(100, 32);
            this.BTNINGRESARUSUARIO.TabIndex = 8;
            this.BTNINGRESARUSUARIO.Text = "INGRESAR";
            this.BTNINGRESARUSUARIO.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "LISTADO DE USUARIOS";
            // 
            // dataGridViewUSUARIOS
            // 
            this.dataGridViewUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUSUARIOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Usuario,
            this.Contraseña});
            this.dataGridViewUSUARIOS.Location = new System.Drawing.Point(-5, 47);
            this.dataGridViewUSUARIOS.Name = "dataGridViewUSUARIOS";
            this.dataGridViewUSUARIOS.Size = new System.Drawing.Size(438, 190);
            this.dataGridViewUSUARIOS.TabIndex = 6;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            // 
            // ListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(439, 300);
            this.Controls.Add(this.BTNSALIRUSUARIO);
            this.Controls.Add(this.BTNINGRESARUSUARIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUSUARIOS);
            this.Name = "ListadoUsuarios";
            this.Text = "ListadoUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUSUARIOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSALIRUSUARIO;
        private System.Windows.Forms.Button BTNINGRESARUSUARIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUSUARIOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
    }
}