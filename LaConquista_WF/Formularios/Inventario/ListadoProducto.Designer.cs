﻿namespace LaConquista_WF
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNSALIRPRODUCTO
            // 
            this.BTNSALIRPRODUCTO.BackColor = System.Drawing.Color.Black;
            this.BTNSALIRPRODUCTO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIRPRODUCTO.ForeColor = System.Drawing.Color.White;
            this.BTNSALIRPRODUCTO.Location = new System.Drawing.Point(483, 321);
            this.BTNSALIRPRODUCTO.Name = "BTNSALIRPRODUCTO";
            this.BTNSALIRPRODUCTO.Size = new System.Drawing.Size(100, 32);
            this.BTNSALIRPRODUCTO.TabIndex = 9;
            this.BTNSALIRPRODUCTO.Text = "SALIR";
            this.BTNSALIRPRODUCTO.UseVisualStyleBackColor = false;
            this.BTNSALIRPRODUCTO.Click += new System.EventHandler(this.BTNSALIRPRODUCTO_Click);
            // 
            // btbINGRESARPRODUCTO
            // 
            this.btbINGRESARPRODUCTO.BackColor = System.Drawing.Color.Black;
            this.btbINGRESARPRODUCTO.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbINGRESARPRODUCTO.ForeColor = System.Drawing.Color.White;
            this.btbINGRESARPRODUCTO.Location = new System.Drawing.Point(37, 321);
            this.btbINGRESARPRODUCTO.Name = "btbINGRESARPRODUCTO";
            this.btbINGRESARPRODUCTO.Size = new System.Drawing.Size(100, 32);
            this.btbINGRESARPRODUCTO.TabIndex = 8;
            this.btbINGRESARPRODUCTO.Text = "REGISTRAR";
            this.btbINGRESARPRODUCTO.UseVisualStyleBackColor = false;
            this.btbINGRESARPRODUCTO.Click += new System.EventHandler(this.btbINGRESARPRODUCTO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "LISTADO DE PRODUCTOS";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(625, 29);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "[Regresar]";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(688, 29);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(76, 13);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "[Cerrar Sesión]";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 74);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(751, 241);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Black;
            this.btnEditar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(143, 321);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 32);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // ListadoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(776, 381);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BTNSALIRPRODUCTO);
            this.Controls.Add(this.btbINGRESARPRODUCTO);
            this.Controls.Add(this.label1);
            this.Name = "ListadoProducto";
            this.Text = "ListadoProducto";
            this.Load += new System.EventHandler(this.ListadoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSALIRPRODUCTO;
        private System.Windows.Forms.Button btbINGRESARPRODUCTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditar;
    }
}