namespace venta
{
    partial class Cliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.bttnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasHDataSet1 = new venta.VentasHDataSet1();
            this.ventasHDataSet = new venta.VentasHDataSet();
            this.ventasHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasTableAdapter = new venta.VentasHDataSet1TableAdapters.FacturasTableAdapter();
            this.bttnModificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdfactura = new System.Windows.Forms.TextBox();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ventasHDataSet2 = new venta.VentasHDataSet2();
            this.facturasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.facturasTableAdapter1 = new venta.VentasHDataSet2TableAdapters.FacturasTableAdapter();
            this.dtgFaturas = new System.Windows.Forms.DataGridView();
            this.ventasHDataSet3 = new venta.VentasHDataSet3();
            this.facturasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.facturasTableAdapter2 = new venta.VentasHDataSet3TableAdapters.FacturasTableAdapter();
            this.iDfacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasHDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasHDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(97, 24);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "\"\"\"\"\"\"\"\"\"";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // bttnSalir
            // 
            this.bttnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.bttnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSalir.Image = ((System.Drawing.Image)(resources.GetObject("bttnSalir.Image")));
            this.bttnSalir.Location = new System.Drawing.Point(502, -4);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(90, 41);
            this.bttnSalir.TabIndex = 2;
            this.bttnSalir.Text = " Volver";
            this.bttnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttnSalir.UseVisualStyleBackColor = false;
            this.bttnSalir.Click += new System.EventHandler(this.bttnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero de factura";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(123, 61);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(237, 20);
            this.txtFactura.TabIndex = 4;
            this.txtFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnAgregar.Location = new System.Drawing.Point(381, 61);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(193, 73);
            this.bttnAgregar.TabIndex = 5;
            this.bttnAgregar.Text = "Agregar";
            this.bttnAgregar.UseVisualStyleBackColor = true;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de factura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de emision:";
            // 
            // dpFecha
            // 
            this.dpFecha.Location = new System.Drawing.Point(123, 114);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(237, 20);
            this.dpFecha.TabIndex = 8;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbTipo.Location = new System.Drawing.Point(123, 87);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(237, 21);
            this.cmbTipo.TabIndex = 9;
            // 
            // facturasBindingSource
            // 
            this.facturasBindingSource.DataMember = "Facturas";
            this.facturasBindingSource.DataSource = this.ventasHDataSet1;
            // 
            // ventasHDataSet1
            // 
            this.ventasHDataSet1.DataSetName = "VentasHDataSet1";
            this.ventasHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasHDataSet
            // 
            this.ventasHDataSet.DataSetName = "VentasHDataSet";
            this.ventasHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasHDataSetBindingSource
            // 
            this.ventasHDataSetBindingSource.DataSource = this.ventasHDataSet;
            this.ventasHDataSetBindingSource.Position = 0;
            // 
            // facturasTableAdapter
            // 
            this.facturasTableAdapter.ClearBeforeFill = true;
            // 
            // bttnModificar
            // 
            this.bttnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnModificar.Image = ((System.Drawing.Image)(resources.GetObject("bttnModificar.Image")));
            this.bttnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnModificar.Location = new System.Drawing.Point(341, 153);
            this.bttnModificar.Name = "bttnModificar";
            this.bttnModificar.Size = new System.Drawing.Size(90, 36);
            this.bttnModificar.TabIndex = 16;
            this.bttnModificar.Text = "Modificar";
            this.bttnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnModificar.UseVisualStyleBackColor = true;
            this.bttnModificar.Click += new System.EventHandler(this.bttnModificar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Id de la factura";
            // 
            // txtIdfactura
            // 
            this.txtIdfactura.Location = new System.Drawing.Point(179, 169);
            this.txtIdfactura.Name = "txtIdfactura";
            this.txtIdfactura.Size = new System.Drawing.Size(113, 20);
            this.txtIdfactura.TabIndex = 18;
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("bttnEliminar.Image")));
            this.bttnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnEliminar.Location = new System.Drawing.Point(477, 153);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(83, 36);
            this.bttnEliminar.TabIndex = 19;
            this.bttnEliminar.Text = "Eliminar";
            this.bttnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnEliminar.UseVisualStyleBackColor = true;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Seleccionar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ventasHDataSet2
            // 
            this.ventasHDataSet2.DataSetName = "VentasHDataSet2";
            this.ventasHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturasBindingSource1
            // 
            this.facturasBindingSource1.DataMember = "Facturas";
            this.facturasBindingSource1.DataSource = this.ventasHDataSet2;
            // 
            // facturasTableAdapter1
            // 
            this.facturasTableAdapter1.ClearBeforeFill = true;
            // 
            // dtgFaturas
            // 
            this.dtgFaturas.AutoGenerateColumns = false;
            this.dtgFaturas.BackgroundColor = System.Drawing.Color.White;
            this.dtgFaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDfacturaDataGridViewTextBoxColumn,
            this.numFacturaDataGridViewTextBoxColumn,
            this.fechaEmisionDataGridViewTextBoxColumn,
            this.tipoFacturaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.dtgFaturas.DataSource = this.facturasBindingSource2;
            this.dtgFaturas.Location = new System.Drawing.Point(16, 199);
            this.dtgFaturas.Name = "dtgFaturas";
            this.dtgFaturas.Size = new System.Drawing.Size(558, 199);
            this.dtgFaturas.TabIndex = 21;
            // 
            // ventasHDataSet3
            // 
            this.ventasHDataSet3.DataSetName = "VentasHDataSet3";
            this.ventasHDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturasBindingSource2
            // 
            this.facturasBindingSource2.DataMember = "Facturas";
            this.facturasBindingSource2.DataSource = this.ventasHDataSet3;
            // 
            // facturasTableAdapter2
            // 
            this.facturasTableAdapter2.ClearBeforeFill = true;
            // 
            // iDfacturaDataGridViewTextBoxColumn
            // 
            this.iDfacturaDataGridViewTextBoxColumn.DataPropertyName = "IDfactura";
            this.iDfacturaDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDfacturaDataGridViewTextBoxColumn.Name = "iDfacturaDataGridViewTextBoxColumn";
            this.iDfacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDfacturaDataGridViewTextBoxColumn.Width = 65;
            // 
            // numFacturaDataGridViewTextBoxColumn
            // 
            this.numFacturaDataGridViewTextBoxColumn.DataPropertyName = "NumFactura";
            this.numFacturaDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numFacturaDataGridViewTextBoxColumn.Name = "numFacturaDataGridViewTextBoxColumn";
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            this.fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.HeaderText = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            this.fechaEmisionDataGridViewTextBoxColumn.Width = 190;
            // 
            // tipoFacturaDataGridViewTextBoxColumn
            // 
            this.tipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "TipoFactura";
            this.tipoFacturaDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoFacturaDataGridViewTextBoxColumn.Name = "tipoFacturaDataGridViewTextBoxColumn";
            this.tipoFacturaDataGridViewTextBoxColumn.Width = 60;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 411);
            this.Controls.Add(this.dtgFaturas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.txtIdfactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttnModificar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnSalir);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasHDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasHDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button bttnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpFecha;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.BindingSource ventasHDataSetBindingSource;
        private VentasHDataSet ventasHDataSet;
        private VentasHDataSet1 ventasHDataSet1;
        private System.Windows.Forms.BindingSource facturasBindingSource;
        private VentasHDataSet1TableAdapters.FacturasTableAdapter facturasTableAdapter;
        private System.Windows.Forms.Button bttnModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdfactura;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button button1;
        private VentasHDataSet2 ventasHDataSet2;
        private System.Windows.Forms.BindingSource facturasBindingSource1;
        private VentasHDataSet2TableAdapters.FacturasTableAdapter facturasTableAdapter1;
        private System.Windows.Forms.DataGridView dtgFaturas;
        private VentasHDataSet3 ventasHDataSet3;
        private System.Windows.Forms.BindingSource facturasBindingSource2;
        private VentasHDataSet3TableAdapters.FacturasTableAdapter facturasTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDfacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
    }
}