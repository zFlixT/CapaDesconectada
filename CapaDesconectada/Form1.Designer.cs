namespace CapaDesconectada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarNt = new System.Windows.Forms.Button();
            this.tbxBusquedaNt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtenerNoTipado = new System.Windows.Forms.Button();
            this.gridNoTipado = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarTipado = new System.Windows.Forms.Button();
            this.tbxBusquedaTipado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObtenerTipado = new System.Windows.Forms.Button();
            this.gridTipado = new System.Windows.Forms.DataGridView();
            this.tbxContactTitle = new System.Windows.Forms.TextBox();
            this.tbxContactName = new System.Windows.Forms.TextBox();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.tbxCustomerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsertarCliente = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxAddres = new System.Windows.Forms.TextBox();
            this.btnInsertarT = new System.Windows.Forms.Button();
            this.btnActualizarNT = new System.Windows.Forms.Button();
            this.btnActualizarT = new System.Windows.Forms.Button();
            this.btnEliminarClienteNt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarClienteNt);
            this.groupBox1.Controls.Add(this.btnActualizarNT);
            this.groupBox1.Controls.Add(this.btnBuscarNt);
            this.groupBox1.Controls.Add(this.tbxBusquedaNt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnObtenerNoTipado);
            this.groupBox1.Controls.Add(this.gridNoTipado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DaraSet No Tipado";
            // 
            // btnBuscarNt
            // 
            this.btnBuscarNt.Location = new System.Drawing.Point(97, 301);
            this.btnBuscarNt.Name = "btnBuscarNt";
            this.btnBuscarNt.Size = new System.Drawing.Size(76, 36);
            this.btnBuscarNt.TabIndex = 5;
            this.btnBuscarNt.Text = "Enviar";
            this.btnBuscarNt.UseVisualStyleBackColor = true;
            this.btnBuscarNt.Click += new System.EventHandler(this.btnBuscarNt_Click);
            // 
            // tbxBusquedaNt
            // 
            this.tbxBusquedaNt.Location = new System.Drawing.Point(145, 259);
            this.tbxBusquedaNt.Name = "tbxBusquedaNt";
            this.tbxBusquedaNt.Size = new System.Drawing.Size(138, 20);
            this.tbxBusquedaNt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar ";
            // 
            // btnObtenerNoTipado
            // 
            this.btnObtenerNoTipado.Location = new System.Drawing.Point(73, 190);
            this.btnObtenerNoTipado.Name = "btnObtenerNoTipado";
            this.btnObtenerNoTipado.Size = new System.Drawing.Size(251, 36);
            this.btnObtenerNoTipado.TabIndex = 2;
            this.btnObtenerNoTipado.Text = "Obtener datos no tipados";
            this.btnObtenerNoTipado.UseVisualStyleBackColor = true;
            this.btnObtenerNoTipado.Click += new System.EventHandler(this.btnObtenerNoTipado_Click);
            // 
            // gridNoTipado
            // 
            this.gridNoTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNoTipado.Location = new System.Drawing.Point(6, 19);
            this.gridNoTipado.Name = "gridNoTipado";
            this.gridNoTipado.Size = new System.Drawing.Size(367, 150);
            this.gridNoTipado.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActualizarT);
            this.groupBox2.Controls.Add(this.btnInsertarT);
            this.groupBox2.Controls.Add(this.btnBuscarTipado);
            this.groupBox2.Controls.Add(this.tbxBusquedaTipado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnObtenerTipado);
            this.groupBox2.Controls.Add(this.gridTipado);
            this.groupBox2.Location = new System.Drawing.Point(406, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 396);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DaraSet Tipado";
            // 
            // btnBuscarTipado
            // 
            this.btnBuscarTipado.Location = new System.Drawing.Point(106, 301);
            this.btnBuscarTipado.Name = "btnBuscarTipado";
            this.btnBuscarTipado.Size = new System.Drawing.Size(76, 36);
            this.btnBuscarTipado.TabIndex = 6;
            this.btnBuscarTipado.Text = "Enviar";
            this.btnBuscarTipado.UseVisualStyleBackColor = true;
            this.btnBuscarTipado.Click += new System.EventHandler(this.btnBuscarTipado_Click);
            // 
            // tbxBusquedaTipado
            // 
            this.tbxBusquedaTipado.Location = new System.Drawing.Point(152, 258);
            this.tbxBusquedaTipado.Name = "tbxBusquedaTipado";
            this.tbxBusquedaTipado.Size = new System.Drawing.Size(145, 20);
            this.tbxBusquedaTipado.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar ";
            // 
            // btnObtenerTipado
            // 
            this.btnObtenerTipado.Location = new System.Drawing.Point(81, 190);
            this.btnObtenerTipado.Name = "btnObtenerTipado";
            this.btnObtenerTipado.Size = new System.Drawing.Size(251, 36);
            this.btnObtenerTipado.TabIndex = 3;
            this.btnObtenerTipado.Text = "Obtener datos tipados";
            this.btnObtenerTipado.UseVisualStyleBackColor = true;
            this.btnObtenerTipado.Click += new System.EventHandler(this.btnObtenerTipado_Click);
            // 
            // gridTipado
            // 
            this.gridTipado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipado.Location = new System.Drawing.Point(12, 19);
            this.gridTipado.Name = "gridTipado";
            this.gridTipado.Size = new System.Drawing.Size(364, 150);
            this.gridTipado.TabIndex = 1;
            // 
            // tbxContactTitle
            // 
            this.tbxContactTitle.Location = new System.Drawing.Point(1032, 218);
            this.tbxContactTitle.Name = "tbxContactTitle";
            this.tbxContactTitle.Size = new System.Drawing.Size(145, 20);
            this.tbxContactTitle.TabIndex = 7;
            // 
            // tbxContactName
            // 
            this.tbxContactName.Location = new System.Drawing.Point(1032, 170);
            this.tbxContactName.Name = "tbxContactName";
            this.tbxContactName.Size = new System.Drawing.Size(145, 20);
            this.tbxContactName.TabIndex = 8;
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.Location = new System.Drawing.Point(1032, 120);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.Size = new System.Drawing.Size(145, 20);
            this.tbxCompanyName.TabIndex = 9;
            // 
            // tbxCustomerID
            // 
            this.tbxCustomerID.Location = new System.Drawing.Point(1032, 75);
            this.tbxCustomerID.Name = "tbxCustomerID";
            this.tbxCustomerID.Size = new System.Drawing.Size(145, 20);
            this.tbxCustomerID.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(947, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(947, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contact Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(947, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Company Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(947, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Customer ID";
            // 
            // btnInsertarCliente
            // 
            this.btnInsertarCliente.Location = new System.Drawing.Point(981, 328);
            this.btnInsertarCliente.Name = "btnInsertarCliente";
            this.btnInsertarCliente.Size = new System.Drawing.Size(186, 36);
            this.btnInsertarCliente.TabIndex = 7;
            this.btnInsertarCliente.Text = "Insertar";
            this.btnInsertarCliente.UseVisualStyleBackColor = true;
            this.btnInsertarCliente.Click += new System.EventHandler(this.btnInsertarCliente_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(947, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Addres";
            // 
            // tbxAddres
            // 
            this.tbxAddres.Location = new System.Drawing.Point(1032, 267);
            this.tbxAddres.Name = "tbxAddres";
            this.tbxAddres.Size = new System.Drawing.Size(145, 20);
            this.tbxAddres.TabIndex = 12;
            // 
            // btnInsertarT
            // 
            this.btnInsertarT.Location = new System.Drawing.Point(106, 343);
            this.btnInsertarT.Name = "btnInsertarT";
            this.btnInsertarT.Size = new System.Drawing.Size(76, 36);
            this.btnInsertarT.TabIndex = 7;
            this.btnInsertarT.Text = "Insertar";
            this.btnInsertarT.UseVisualStyleBackColor = true;
            this.btnInsertarT.Click += new System.EventHandler(this.btnInsertarT_Click);
            // 
            // btnActualizarNT
            // 
            this.btnActualizarNT.Location = new System.Drawing.Point(207, 301);
            this.btnActualizarNT.Name = "btnActualizarNT";
            this.btnActualizarNT.Size = new System.Drawing.Size(76, 36);
            this.btnActualizarNT.TabIndex = 8;
            this.btnActualizarNT.Text = "Actualizar";
            this.btnActualizarNT.UseVisualStyleBackColor = true;
            this.btnActualizarNT.Click += new System.EventHandler(this.btnActualizarNT_Click);
            // 
            // btnActualizarT
            // 
            this.btnActualizarT.Location = new System.Drawing.Point(221, 301);
            this.btnActualizarT.Name = "btnActualizarT";
            this.btnActualizarT.Size = new System.Drawing.Size(76, 36);
            this.btnActualizarT.TabIndex = 8;
            this.btnActualizarT.Text = "Actualizar";
            this.btnActualizarT.UseVisualStyleBackColor = true;
            this.btnActualizarT.Click += new System.EventHandler(this.btnActualizarT_Click);
            // 
            // btnEliminarClienteNt
            // 
            this.btnEliminarClienteNt.Location = new System.Drawing.Point(157, 343);
            this.btnEliminarClienteNt.Name = "btnEliminarClienteNt";
            this.btnEliminarClienteNt.Size = new System.Drawing.Size(76, 36);
            this.btnEliminarClienteNt.TabIndex = 9;
            this.btnEliminarClienteNt.Text = "Eliminar";
            this.btnEliminarClienteNt.UseVisualStyleBackColor = true;
            this.btnEliminarClienteNt.Click += new System.EventHandler(this.btnEliminarClienteNt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 487);
            this.Controls.Add(this.tbxAddres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInsertarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxContactTitle);
            this.Controls.Add(this.tbxContactName);
            this.Controls.Add(this.tbxCompanyName);
            this.Controls.Add(this.tbxCustomerID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNoTipado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridNoTipado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObtenerNoTipado;
        private System.Windows.Forms.Button btnObtenerTipado;
        private System.Windows.Forms.DataGridView gridTipado;
        private System.Windows.Forms.Button btnBuscarNt;
        private System.Windows.Forms.TextBox tbxBusquedaNt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarTipado;
        private System.Windows.Forms.TextBox tbxBusquedaTipado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxContactTitle;
        private System.Windows.Forms.TextBox tbxContactName;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.TextBox tbxCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsertarCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxAddres;
        private System.Windows.Forms.Button btnInsertarT;
        private System.Windows.Forms.Button btnActualizarNT;
        private System.Windows.Forms.Button btnActualizarT;
        private System.Windows.Forms.Button btnEliminarClienteNt;
    }
}

