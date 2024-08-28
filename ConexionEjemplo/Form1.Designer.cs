namespace ConexionEjemplo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tboxCustomerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxContactTitle = new System.Windows.Forms.TextBox();
            this.lbContactTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.tboxContacName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(16, 102);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.Size = new System.Drawing.Size(1020, 334);
            this.dataGrid.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(105, 476);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(128, 42);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar Informaciòn";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Location = new System.Drawing.Point(105, 36);
            this.tbFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(132, 22);
            this.tbFiltro.TabIndex = 2;
            this.tbFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar";
            this.label1.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1233, 96);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(265, 28);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar Cliente";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1229, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customers ID";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(1331, 30);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(167, 22);
            this.txtBuscar.TabIndex = 6;
            // 
            // tboxCustomerID
            // 
            this.tboxCustomerID.Location = new System.Drawing.Point(1331, 181);
            this.tboxCustomerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxCustomerID.Name = "tboxCustomerID";
            this.tboxCustomerID.Size = new System.Drawing.Size(167, 22);
            this.tboxCustomerID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1229, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customers ID";
            // 
            // tboxCompanyName
            // 
            this.tboxCompanyName.Location = new System.Drawing.Point(1331, 224);
            this.tboxCompanyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxCompanyName.Name = "tboxCompanyName";
            this.tboxCompanyName.Size = new System.Drawing.Size(167, 22);
            this.tboxCompanyName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1217, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "CompanyName";
            // 
            // tboxContactTitle
            // 
            this.tboxContactTitle.Location = new System.Drawing.Point(1331, 336);
            this.tboxContactTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxContactTitle.Name = "tboxContactTitle";
            this.tboxContactTitle.Size = new System.Drawing.Size(167, 22);
            this.tboxContactTitle.TabIndex = 12;
            // 
            // lbContactTitle
            // 
            this.lbContactTitle.AutoSize = true;
            this.lbContactTitle.Location = new System.Drawing.Point(1217, 340);
            this.lbContactTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContactTitle.Name = "lbContactTitle";
            this.lbContactTitle.Size = new System.Drawing.Size(78, 16);
            this.lbContactTitle.TabIndex = 11;
            this.lbContactTitle.Text = "ContactTitle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customers ID";
            // 
            // tboxAddress
            // 
            this.tboxAddress.Location = new System.Drawing.Point(1331, 388);
            this.tboxAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(167, 22);
            this.tboxAddress.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1229, 396);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address";
            // 
            // tboxCity
            // 
            this.tboxCity.Location = new System.Drawing.Point(1331, 437);
            this.tboxCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxCity.Name = "tboxCity";
            this.tboxCity.Size = new System.Drawing.Size(167, 22);
            this.tboxCity.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1229, 437);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "City";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(1060, 490);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(265, 28);
            this.btnInsertar.TabIndex = 19;
            this.btnInsertar.Text = "Ingresar ";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // tboxContacName
            // 
            this.tboxContacName.Location = new System.Drawing.Point(1331, 284);
            this.tboxContacName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxContacName.Name = "tboxContacName";
            this.tboxContacName.Size = new System.Drawing.Size(167, 22);
            this.tboxContacName.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1212, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "ContactName";
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(1385, 490);
            this.btModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(265, 28);
            this.btModificar.TabIndex = 22;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1081, 549);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(569, 48);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar usuario ";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 633);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.tboxContacName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.tboxCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tboxAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxContactTitle);
            this.Controls.Add(this.lbContactTitle);
            this.Controls.Add(this.tboxCompanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxCustomerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox tboxCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxCompanyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxContactTitle;
        private System.Windows.Forms.Label lbContactTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox tboxContacName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

