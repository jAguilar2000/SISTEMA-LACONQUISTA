namespace LaConquista_WF
{
    partial class IngresarFactura
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
            this.TXTIDESCUENTO = new System.Windows.Forms.TextBox();
            this.Apellido_cliente = new System.Windows.Forms.Label();
            this.Nombre_cliente = new System.Windows.Forms.Label();
            this.TXT_DESCRIPCION = new System.Windows.Forms.TextBox();
            this.TXT_CODIGO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BTNINGRESARCLIENTE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNAGREGARFACTURA = new System.Windows.Forms.Button();
            this.BTNMENU = new System.Windows.Forms.Button();
            this.BTNCOBRAR = new System.Windows.Forms.Button();
            this.BTNREGISTRARPRODUCTOFACTURA = new System.Windows.Forms.Button();
            this.BTNELIMINARFACTURA = new System.Windows.Forms.Button();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DTPFACTURA = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CBCLIENTEFACTURA = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "DESCUENTO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TXTIDESCUENTO
            // 
            this.TXTIDESCUENTO.BackColor = System.Drawing.SystemColors.Info;
            this.TXTIDESCUENTO.Location = new System.Drawing.Point(541, 217);
            this.TXTIDESCUENTO.Multiline = true;
            this.TXTIDESCUENTO.Name = "TXTIDESCUENTO";
            this.TXTIDESCUENTO.Size = new System.Drawing.Size(150, 31);
            this.TXTIDESCUENTO.TabIndex = 22;
            this.TXTIDESCUENTO.TextChanged += new System.EventHandler(this.TXTIDESCUENTO_TextChanged);
            // 
            // Apellido_cliente
            // 
            this.Apellido_cliente.AutoSize = true;
            this.Apellido_cliente.Location = new System.Drawing.Point(219, 220);
            this.Apellido_cliente.Name = "Apellido_cliente";
            this.Apellido_cliente.Size = new System.Drawing.Size(80, 13);
            this.Apellido_cliente.TabIndex = 21;
            this.Apellido_cliente.Text = "DESCRIPCION";
            this.Apellido_cliente.Click += new System.EventHandler(this.Apellido_cliente_Click);
            // 
            // Nombre_cliente
            // 
            this.Nombre_cliente.AutoSize = true;
            this.Nombre_cliente.Location = new System.Drawing.Point(8, 220);
            this.Nombre_cliente.Name = "Nombre_cliente";
            this.Nombre_cliente.Size = new System.Drawing.Size(49, 13);
            this.Nombre_cliente.TabIndex = 20;
            this.Nombre_cliente.Text = "CÓDIGO";
            this.Nombre_cliente.Click += new System.EventHandler(this.Nombre_cliente_Click);
            // 
            // TXT_DESCRIPCION
            // 
            this.TXT_DESCRIPCION.BackColor = System.Drawing.SystemColors.Info;
            this.TXT_DESCRIPCION.Location = new System.Drawing.Point(305, 217);
            this.TXT_DESCRIPCION.Multiline = true;
            this.TXT_DESCRIPCION.Name = "TXT_DESCRIPCION";
            this.TXT_DESCRIPCION.Size = new System.Drawing.Size(150, 31);
            this.TXT_DESCRIPCION.TabIndex = 19;
            this.TXT_DESCRIPCION.TextChanged += new System.EventHandler(this.TXT_DESCRIPCION_TextChanged);
            // 
            // TXT_CODIGO
            // 
            this.TXT_CODIGO.BackColor = System.Drawing.SystemColors.Info;
            this.TXT_CODIGO.Location = new System.Drawing.Point(63, 217);
            this.TXT_CODIGO.Multiline = true;
            this.TXT_CODIGO.Name = "TXT_CODIGO";
            this.TXT_CODIGO.Size = new System.Drawing.Size(150, 31);
            this.TXT_CODIGO.TabIndex = 18;
            this.TXT_CODIGO.TextChanged += new System.EventHandler(this.TXT_CODIGO_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "INGRESAR FACTURA";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(730, 131);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BTNINGRESARCLIENTE
            // 
            this.BTNINGRESARCLIENTE.BackColor = System.Drawing.Color.Salmon;
            this.BTNINGRESARCLIENTE.ForeColor = System.Drawing.Color.White;
            this.BTNINGRESARCLIENTE.Location = new System.Drawing.Point(26, 82);
            this.BTNINGRESARCLIENTE.Name = "BTNINGRESARCLIENTE";
            this.BTNINGRESARCLIENTE.Size = new System.Drawing.Size(100, 32);
            this.BTNINGRESARCLIENTE.TabIndex = 25;
            this.BTNINGRESARCLIENTE.Text = "HUEVOS";
            this.BTNINGRESARCLIENTE.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(149, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "AZUCAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(149, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 27;
            this.button2.Text = "SAL";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(26, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 32);
            this.button3.TabIndex = 28;
            this.button3.Text = "ARROZ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(26, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 32);
            this.button4.TabIndex = 29;
            this.button4.Text = "FRIJOLES";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Salmon;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(149, 158);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 32);
            this.button5.TabIndex = 30;
            this.button5.Text = "CONSOME";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightCoral;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(390, 158);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 32);
            this.button6.TabIndex = 36;
            this.button6.Text = "LECHE";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightCoral;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(267, 120);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 32);
            this.button7.TabIndex = 35;
            this.button7.Text = "POLLO";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightCoral;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(267, 158);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 32);
            this.button8.TabIndex = 34;
            this.button8.Text = "CHULETA";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightCoral;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(390, 82);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(100, 32);
            this.button9.TabIndex = 33;
            this.button9.Text = "QUESO";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightCoral;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(390, 120);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 32);
            this.button10.TabIndex = 32;
            this.button10.Text = "MANTEQUILLA";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightCoral;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(267, 82);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 32);
            this.button11.TabIndex = 31;
            this.button11.Text = "MORTADELA";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Tomato;
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(631, 158);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 32);
            this.button12.TabIndex = 42;
            this.button12.Text = "ZANAHORIA";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Tomato;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(508, 120);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 32);
            this.button13.TabIndex = 41;
            this.button13.Text = "JUGO";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Tomato;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(508, 158);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(100, 32);
            this.button14.TabIndex = 40;
            this.button14.Text = "REFRESCO";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Tomato;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(631, 82);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(100, 32);
            this.button15.TabIndex = 39;
            this.button15.Text = "TOMATE";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Tomato;
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(631, 120);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(100, 32);
            this.button16.TabIndex = 38;
            this.button16.Text = "CEBOLLA";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Tomato;
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(508, 82);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(100, 32);
            this.button17.TabIndex = 37;
            this.button17.Text = "AGUA";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.ISV,
            this.Descuento});
            this.dataGridView1.Location = new System.Drawing.Point(37, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 43;
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
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // ISV
            // 
            this.ISV.HeaderText = "ISV";
            this.ISV.Name = "ISV";
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // BTNAGREGARFACTURA
            // 
            this.BTNAGREGARFACTURA.BackColor = System.Drawing.Color.Salmon;
            this.BTNAGREGARFACTURA.ForeColor = System.Drawing.Color.White;
            this.BTNAGREGARFACTURA.Location = new System.Drawing.Point(697, 245);
            this.BTNAGREGARFACTURA.Name = "BTNAGREGARFACTURA";
            this.BTNAGREGARFACTURA.Size = new System.Drawing.Size(100, 32);
            this.BTNAGREGARFACTURA.TabIndex = 44;
            this.BTNAGREGARFACTURA.Text = "AGREGAR";
            this.BTNAGREGARFACTURA.UseVisualStyleBackColor = false;
            // 
            // BTNMENU
            // 
            this.BTNMENU.BackColor = System.Drawing.Color.Salmon;
            this.BTNMENU.ForeColor = System.Drawing.Color.White;
            this.BTNMENU.Location = new System.Drawing.Point(37, 410);
            this.BTNMENU.Name = "BTNMENU";
            this.BTNMENU.Size = new System.Drawing.Size(100, 32);
            this.BTNMENU.TabIndex = 45;
            this.BTNMENU.Text = "MENÚ";
            this.BTNMENU.UseVisualStyleBackColor = false;
            // 
            // BTNCOBRAR
            // 
            this.BTNCOBRAR.BackColor = System.Drawing.Color.Salmon;
            this.BTNCOBRAR.ForeColor = System.Drawing.Color.White;
            this.BTNCOBRAR.Location = new System.Drawing.Point(305, 410);
            this.BTNCOBRAR.Name = "BTNCOBRAR";
            this.BTNCOBRAR.Size = new System.Drawing.Size(100, 32);
            this.BTNCOBRAR.TabIndex = 46;
            this.BTNCOBRAR.Text = "COBRAR";
            this.BTNCOBRAR.UseVisualStyleBackColor = false;
            // 
            // BTNREGISTRARPRODUCTOFACTURA
            // 
            this.BTNREGISTRARPRODUCTOFACTURA.BackColor = System.Drawing.Color.Salmon;
            this.BTNREGISTRARPRODUCTOFACTURA.ForeColor = System.Drawing.Color.White;
            this.BTNREGISTRARPRODUCTOFACTURA.Location = new System.Drawing.Point(697, 292);
            this.BTNREGISTRARPRODUCTOFACTURA.Name = "BTNREGISTRARPRODUCTOFACTURA";
            this.BTNREGISTRARPRODUCTOFACTURA.Size = new System.Drawing.Size(100, 54);
            this.BTNREGISTRARPRODUCTOFACTURA.TabIndex = 47;
            this.BTNREGISTRARPRODUCTOFACTURA.Text = "REGISTRAR PRODUCTO";
            this.BTNREGISTRARPRODUCTOFACTURA.UseVisualStyleBackColor = false;
            // 
            // BTNELIMINARFACTURA
            // 
            this.BTNELIMINARFACTURA.BackColor = System.Drawing.Color.Salmon;
            this.BTNELIMINARFACTURA.ForeColor = System.Drawing.Color.White;
            this.BTNELIMINARFACTURA.Location = new System.Drawing.Point(697, 363);
            this.BTNELIMINARFACTURA.Name = "BTNELIMINARFACTURA";
            this.BTNELIMINARFACTURA.Size = new System.Drawing.Size(100, 32);
            this.BTNELIMINARFACTURA.TabIndex = 48;
            this.BTNELIMINARFACTURA.Text = "ELIMINAR";
            this.BTNELIMINARFACTURA.UseVisualStyleBackColor = false;
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.Salmon;
            this.BTNSALIR.ForeColor = System.Drawing.Color.White;
            this.BTNSALIR.Location = new System.Drawing.Point(170, 410);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(100, 32);
            this.BTNSALIR.TabIndex = 49;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(446, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "TOTAL";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(541, 417);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 50;
            // 
            // DTPFACTURA
            // 
            this.DTPFACTURA.Location = new System.Drawing.Point(71, 41);
            this.DTPFACTURA.Name = "DTPFACTURA";
            this.DTPFACTURA.Size = new System.Drawing.Size(200, 20);
            this.DTPFACTURA.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "CLIENTE";
            // 
            // CBCLIENTEFACTURA
            // 
            this.CBCLIENTEFACTURA.FormattingEnabled = true;
            this.CBCLIENTEFACTURA.Location = new System.Drawing.Point(349, 37);
            this.CBCLIENTEFACTURA.Name = "CBCLIENTEFACTURA";
            this.CBCLIENTEFACTURA.Size = new System.Drawing.Size(163, 21);
            this.CBCLIENTEFACTURA.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "FECHA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "USUARIO";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(591, 37);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 24);
            this.textBox2.TabIndex = 57;
            // 
            // IngresarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(851, 453);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBCLIENTEFACTURA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTPFACTURA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.BTNELIMINARFACTURA);
            this.Controls.Add(this.BTNREGISTRARPRODUCTOFACTURA);
            this.Controls.Add(this.BTNCOBRAR);
            this.Controls.Add(this.BTNMENU);
            this.Controls.Add(this.BTNAGREGARFACTURA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNINGRESARCLIENTE);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTIDESCUENTO);
            this.Controls.Add(this.Apellido_cliente);
            this.Controls.Add(this.Nombre_cliente);
            this.Controls.Add(this.TXT_DESCRIPCION);
            this.Controls.Add(this.TXT_CODIGO);
            this.Controls.Add(this.label1);
            this.Name = "IngresarFactura";
            this.Text = "IngresarFactura";
            this.Load += new System.EventHandler(this.IngresarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTIDESCUENTO;
        private System.Windows.Forms.Label Apellido_cliente;
        private System.Windows.Forms.Label Nombre_cliente;
        private System.Windows.Forms.TextBox TXT_DESCRIPCION;
        private System.Windows.Forms.TextBox TXT_CODIGO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button BTNINGRESARCLIENTE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.Button BTNAGREGARFACTURA;
        private System.Windows.Forms.Button BTNMENU;
        private System.Windows.Forms.Button BTNCOBRAR;
        private System.Windows.Forms.Button BTNREGISTRARPRODUCTOFACTURA;
        private System.Windows.Forms.Button BTNELIMINARFACTURA;
        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker DTPFACTURA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBCLIENTEFACTURA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
    }
}