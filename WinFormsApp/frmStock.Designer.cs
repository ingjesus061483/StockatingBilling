﻿namespace WinFormsApp
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            customPanel1 = new RoundedBorders.CustomPanel();
            label5 = new Label();
            customPanel2 = new RoundedBorders.CustomPanel();
            checkBox1 = new CheckBox();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            txtAmount = new TextBox();
            label1 = new Label();
            btnWarehouse = new Button();
            txtWarehouse = new TextBox();
            btnProduct = new Button();
            txtProduc = new TextBox();
            customPanel3 = new RoundedBorders.CustomPanel();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            bodega = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            entrada = new DataGridViewTextBoxColumn();
            customPanel4 = new RoundedBorders.CustomPanel();
            btnOpen = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnuevo = new Button();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            customPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(label5);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(224, 224, 224);
            customPanel1.GradientTopColor = Color.FromArgb(224, 224, 224);
            customPanel1.Location = new Point(15, 7);
            customPanel1.Margin = new Padding(2);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(372, 46);
            customPanel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 11);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(336, 29);
            label5.TabIndex = 0;
            label5.Text = "Registro de Entrada y salida";
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(checkBox1);
            customPanel2.Controls.Add(dtpDate);
            customPanel2.Controls.Add(label2);
            customPanel2.Controls.Add(txtAmount);
            customPanel2.Controls.Add(label1);
            customPanel2.Controls.Add(btnWarehouse);
            customPanel2.Controls.Add(txtWarehouse);
            customPanel2.Controls.Add(btnProduct);
            customPanel2.Controls.Add(txtProduc);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(224, 224, 224);
            customPanel2.GradientTopColor = Color.FromArgb(224, 224, 224);
            customPanel2.Location = new Point(15, 58);
            customPanel2.Margin = new Padding(2);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(372, 120);
            customPanel2.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Arial", 10F, FontStyle.Bold);
            checkBox1.Location = new Point(272, 94);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(80, 20);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Entrada";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "yyyy-MM-dd";
            dtpDate.Font = new Font("Arial", 10F);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(80, 93);
            dtpDate.Margin = new Padding(2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(145, 23);
            dtpDate.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.Location = new Point(31, 96);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 16);
            label2.TabIndex = 6;
            label2.Text = "Fecha";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Arial", 10F);
            txtAmount.Location = new Point(82, 67);
            txtAmount.Margin = new Padding(2);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(268, 23);
            txtAmount.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.Location = new Point(11, 69);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 16);
            label1.TabIndex = 4;
            label1.Text = "Cantidad";
            // 
            // btnWarehouse
            // 
            btnWarehouse.BackColor = Color.Transparent;
            btnWarehouse.BackgroundImage = (Image)resources.GetObject("btnWarehouse.BackgroundImage");
            btnWarehouse.BackgroundImageLayout = ImageLayout.Stretch;
            btnWarehouse.FlatStyle = FlatStyle.Flat;
            btnWarehouse.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnWarehouse.Location = new Point(51, 40);
            btnWarehouse.Margin = new Padding(2);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(30, 24);
            btnWarehouse.TabIndex = 3;
            btnWarehouse.UseVisualStyleBackColor = false;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // txtWarehouse
            // 
            txtWarehouse.Font = new Font("Arial", 10F);
            txtWarehouse.Location = new Point(82, 41);
            txtWarehouse.Margin = new Padding(2);
            txtWarehouse.Name = "txtWarehouse";
            txtWarehouse.ReadOnly = true;
            txtWarehouse.Size = new Size(268, 23);
            txtWarehouse.TabIndex = 2;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Transparent;
            btnProduct.BackgroundImage = (Image)resources.GetObject("btnProduct.BackgroundImage");
            btnProduct.BackgroundImageLayout = ImageLayout.Stretch;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnProduct.Location = new Point(51, 14);
            btnProduct.Margin = new Padding(2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(30, 23);
            btnProduct.TabIndex = 1;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // txtProduc
            // 
            txtProduc.Font = new Font("Arial", 10F);
            txtProduc.Location = new Point(83, 15);
            txtProduc.Margin = new Padding(2);
            txtProduc.Name = "txtProduc";
            txtProduc.ReadOnly = true;
            txtProduc.Size = new Size(268, 23);
            txtProduc.TabIndex = 0;
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(dataGridView1);
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(224, 224, 224);
            customPanel3.GradientTopColor = Color.FromArgb(224, 224, 224);
            customPanel3.Location = new Point(15, 236);
            customPanel3.Margin = new Padding(2);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(372, 138);
            customPanel3.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, bodega, producto, cantidad, fecha, entrada });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(372, 138);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // bodega
            // 
            bodega.DataPropertyName = "warehouse";
            bodega.HeaderText = "bodega";
            bodega.Name = "bodega";
            bodega.ReadOnly = true;
            // 
            // producto
            // 
            producto.DataPropertyName = "ProductName";
            producto.HeaderText = "producto";
            producto.Name = "producto";
            producto.ReadOnly = true;
            // 
            // cantidad
            // 
            cantidad.DataPropertyName = "Amount";
            cantidad.HeaderText = "cantidad";
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            // 
            // fecha
            // 
            fecha.DataPropertyName = "Date";
            fecha.HeaderText = "fecha";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // entrada
            // 
            entrada.DataPropertyName = "Entrance";
            entrada.HeaderText = "entrada";
            entrada.Name = "entrada";
            entrada.ReadOnly = true;
            // 
            // customPanel4
            // 
            customPanel4.BackColor = Color.White;
            customPanel4.BorderRadius = 30;
            customPanel4.Controls.Add(btnOpen);
            customPanel4.Controls.Add(btnSalir);
            customPanel4.Controls.Add(btnEliminar);
            customPanel4.Controls.Add(btnGuardar);
            customPanel4.Controls.Add(btnuevo);
            customPanel4.ForeColor = Color.Black;
            customPanel4.GradientAngle = 90F;
            customPanel4.GradientBottomColor = Color.FromArgb(224, 224, 224);
            customPanel4.GradientTopColor = Color.FromArgb(224, 224, 224);
            customPanel4.Location = new Point(16, 182);
            customPanel4.Margin = new Padding(2);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(372, 50);
            customPanel4.TabIndex = 13;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Transparent;
            btnOpen.BackgroundImage = (Image)resources.GetObject("btnOpen.BackgroundImage");
            btnOpen.BackgroundImageLayout = ImageLayout.Stretch;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Location = new Point(145, 5);
            btnOpen.Margin = new Padding(2);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(40, 40);
            btnOpen.TabIndex = 26;
            btnOpen.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(321, 5);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(40, 40);
            btnSalir.TabIndex = 13;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(277, 5);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(40, 40);
            btnEliminar.TabIndex = 14;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(233, 5);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(40, 40);
            btnGuardar.TabIndex = 15;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnuevo
            // 
            btnuevo.BackColor = Color.Transparent;
            btnuevo.BackgroundImage = (Image)resources.GetObject("btnuevo.BackgroundImage");
            btnuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnuevo.FlatStyle = FlatStyle.Flat;
            btnuevo.Location = new Point(189, 5);
            btnuevo.Margin = new Padding(2);
            btnuevo.Name = "btnuevo";
            btnuevo.Size = new Size(40, 40);
            btnuevo.TabIndex = 16;
            btnuevo.UseVisualStyleBackColor = false;
            btnuevo.Click += btnuevo_Click;
            // 
            // frmStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(399, 380);
            Controls.Add(customPanel4);
            Controls.Add(customPanel3);
            Controls.Add(customPanel2);
            Controls.Add(customPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "frmStock";
            Text = "Registro de entrada y salida";
            Load += frmStock_Load;
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            customPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RoundedBorders.CustomPanel customPanel1;
        private Label label5;
        private RoundedBorders.CustomPanel customPanel2;
        private RoundedBorders.CustomPanel customPanel3;
        private TextBox txtProduc;
        private DataGridView dataGridView1;
        private RoundedBorders.CustomPanel customPanel4;
        private Button btnOpen;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnuevo;
        private Button btnWarehouse;
        private TextBox txtWarehouse;
        private Button btnProduct;
        private DateTimePicker dtpDate;
        private Label label2;
        private TextBox txtAmount;
        private Label label1;
        private CheckBox checkBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn bodega;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn entrada;
    }
}