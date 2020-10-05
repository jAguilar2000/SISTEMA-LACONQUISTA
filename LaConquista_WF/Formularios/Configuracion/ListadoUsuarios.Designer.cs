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
            this.BTNSALIRUSUARIO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIRUSUARIO.ForeColor = System.Drawing.Color.White;
            this.BTNSALIRUSUARIO.Location = new System.Drawing.Point(487, 382);
            this.BTNSALIRUSUARIO.Margin = new System.Windows.Forms.Padding(4);
            this.BTNSALIRUSUARIO.Name = "BTNSALIRUSUARIO";
            this.BTNSALIRUSUARIO.Size = new System.Drawing.Size(133, 39);
            this.BTNSALIRUSUARIO.TabIndex = 9;
            this.BTNSALIRUSUARIO.Text = "SALIR";
            this.BTNSALIRUSUARIO.UseVisualStyleBackColor = false;
            // 
            // BTNINGRESARUSUARIO
            // 
            this.BTNINGRESARUSUARIO.BackColor = System.Drawing.Color.Black;
            this.BTNINGRESARUSUARIO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNINGRESARUSUARIO.ForeColor = System.Drawing.Color.White;
            this.BTNINGRESARUSUARIO.Location = new System.Drawing.Point(68, 382);
            this.BTNINGRESARUSUARIO.Margin = new System.Windows.Forms.Padding(4);
            this.BTNINGRESARUSUARIO.Name = "BTNINGRESARUSUARIO";
            this.BTNINGRESARUSUARIO.Size = new System.Drawing.Size(133, 39);
            this.BTNINGRESARUSUARIO.TabIndex = 8;
            this.BTNINGRESARUSUARIO.Text = "INGRESAR";
            this.BTNINGRESARUSUARIO.UseVisualStyleBackColor = false;
            this.BTNINGRESARUSUARIO.Click += new System.EventHandler(this.BTNINGRESARUSUARIO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
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
            this.dataGridViewUSUARIOS.Location = new System.Drawing.Point(68, 130);
            this.dataGridViewUSUARIOS.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUSUARIOS.Name = "dataGridViewUSUARIOS";
            this.dataGridViewUSUARIOS.Size = new System.Drawing.Size(552, 234);
            this.dataGridViewUSUARIOS.TabIndex = 6;
            this.dataGridViewUSUARIOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUSUARIOS_CellContentClick);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.BTNSALIRUSUARIO);
            this.Controls.Add(this.BTNINGRESARUSUARIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUSUARIOS);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListadoUsuarios";
            this.Text = "ListadoUsuarios";
            this.Load += new System.EventHandler(this.ListadoUsuarios_Load);
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