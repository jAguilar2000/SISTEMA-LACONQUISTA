namespace LaConquista_WF
{
    partial class ListadoProducto
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
            this.BTNSALIRPRODUCTO = new System.Windows.Forms.Button();
            this.btbINGRESARPRODUCTO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewPRODUCTO = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUCTO)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNSALIRPRODUCTO
            // 
            this.BTNSALIRPRODUCTO.BackColor = System.Drawing.Color.Black;
            this.BTNSALIRPRODUCTO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIRPRODUCTO.ForeColor = System.Drawing.Color.White;
            this.BTNSALIRPRODUCTO.Location = new System.Drawing.Point(483, 273);
            this.BTNSALIRPRODUCTO.Name = "BTNSALIRPRODUCTO";
            this.BTNSALIRPRODUCTO.Size = new System.Drawing.Size(100, 32);
            this.BTNSALIRPRODUCTO.TabIndex = 9;
            this.BTNSALIRPRODUCTO.Text = "SALIR";
            this.BTNSALIRPRODUCTO.UseVisualStyleBackColor = false;
            // 
            // btbINGRESARPRODUCTO
            // 
            this.btbINGRESARPRODUCTO.BackColor = System.Drawing.Color.Black;
            this.btbINGRESARPRODUCTO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbINGRESARPRODUCTO.ForeColor = System.Drawing.Color.White;
            this.btbINGRESARPRODUCTO.Location = new System.Drawing.Point(37, 273);
            this.btbINGRESARPRODUCTO.Name = "btbINGRESARPRODUCTO";
            this.btbINGRESARPRODUCTO.Size = new System.Drawing.Size(100, 32);
            this.btbINGRESARPRODUCTO.TabIndex = 8;
            this.btbINGRESARPRODUCTO.Text = "INGRESAR";
            this.btbINGRESARPRODUCTO.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "LISTADO DE PRODUCTOS";
            // 
            // dataGridViewPRODUCTO
            // 
            this.dataGridViewPRODUCTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPRODUCTO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Precio,
            this.Categoria,
            this.CantidadDisponible});
            this.dataGridViewPRODUCTO.Location = new System.Drawing.Point(37, 65);
            this.dataGridViewPRODUCTO.Name = "dataGridViewPRODUCTO";
            this.dataGridViewPRODUCTO.Size = new System.Drawing.Size(546, 190);
            this.dataGridViewPRODUCTO.TabIndex = 6;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Catégoria";
            this.Categoria.Name = "Categoria";
            // 
            // CantidadDisponible
            // 
            this.CantidadDisponible.HeaderText = "Cantidad Disponible";
            this.CantidadDisponible.Name = "CantidadDisponible";
            // 
            // ListadoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(622, 332);
            this.Controls.Add(this.BTNSALIRPRODUCTO);
            this.Controls.Add(this.btbINGRESARPRODUCTO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPRODUCTO);
            this.Name = "ListadoProducto";
            this.Text = "ListadoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUCTO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSALIRPRODUCTO;
        private System.Windows.Forms.Button btbINGRESARPRODUCTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDisponible;
    }
}