namespace WinFormsApp
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
            panel2 = new Panel();
            label3 = new Label();
            customPanel2.SuspendLayout();
            customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            customPanel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(panel2);
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
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(21, 12);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(531, 285);
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
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(389, 223);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(110, 28);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Entrada";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "yyyy-MM-dd";
            dtpDate.Font = new Font("Arial", 10F);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(114, 221);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(205, 30);
            dtpDate.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 226);
            label2.Name = "label2";
            label2.Size = new Size(67, 24);
            label2.TabIndex = 6;
            label2.Text = "Fecha";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Arial", 10F);
            txtAmount.Location = new Point(117, 178);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(381, 30);
            txtAmount.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 181);
            label1.Name = "label1";
            label1.Size = new Size(94, 24);
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
            btnWarehouse.Location = new Point(73, 133);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(43, 40);
            btnWarehouse.TabIndex = 3;
            btnWarehouse.UseVisualStyleBackColor = false;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // txtWarehouse
            // 
            txtWarehouse.Font = new Font("Arial", 10F);
            txtWarehouse.Location = new Point(117, 134);
            txtWarehouse.Name = "txtWarehouse";
            txtWarehouse.ReadOnly = true;
            txtWarehouse.Size = new Size(381, 30);
            txtWarehouse.TabIndex = 2;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Transparent;
            btnProduct.BackgroundImage = (Image)resources.GetObject("btnProduct.BackgroundImage");
            btnProduct.BackgroundImageLayout = ImageLayout.Stretch;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnProduct.Location = new Point(73, 89);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(43, 38);
            btnProduct.TabIndex = 1;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // txtProduc
            // 
            txtProduc.Font = new Font("Arial", 10F);
            txtProduc.Location = new Point(119, 91);
            txtProduc.Name = "txtProduc";
            txtProduc.ReadOnly = true;
            txtProduc.Size = new Size(381, 30);
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
            customPanel3.Location = new Point(21, 403);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(531, 230);
            customPanel3.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(42, 46, 50);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, bodega, producto, cantidad, fecha, entrada });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(531, 230);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 150;
            // 
            // bodega
            // 
            bodega.DataPropertyName = "warehouse";
            bodega.HeaderText = "bodega";
            bodega.MinimumWidth = 8;
            bodega.Name = "bodega";
            bodega.ReadOnly = true;
            bodega.Width = 150;
            // 
            // producto
            // 
            producto.DataPropertyName = "ProductName";
            producto.HeaderText = "producto";
            producto.MinimumWidth = 8;
            producto.Name = "producto";
            producto.ReadOnly = true;
            producto.Width = 150;
            // 
            // cantidad
            // 
            cantidad.DataPropertyName = "Amount";
            cantidad.HeaderText = "cantidad";
            cantidad.MinimumWidth = 8;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Width = 150;
            // 
            // fecha
            // 
            fecha.DataPropertyName = "Date";
            fecha.HeaderText = "fecha";
            fecha.MinimumWidth = 8;
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            fecha.Width = 150;
            // 
            // entrada
            // 
            entrada.DataPropertyName = "Entrance";
            entrada.HeaderText = "entrada";
            entrada.MinimumWidth = 8;
            entrada.Name = "entrada";
            entrada.ReadOnly = true;
            entrada.Width = 150;
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
            customPanel4.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel4.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel4.Location = new Point(23, 308);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(531, 83);
            customPanel4.TabIndex = 13;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Transparent;
            btnOpen.BackgroundImage = (Image)resources.GetObject("btnOpen.BackgroundImage");
            btnOpen.BackgroundImageLayout = ImageLayout.Stretch;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Location = new Point(207, 8);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(57, 67);
            btnOpen.TabIndex = 26;
            btnOpen.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(459, 8);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 67);
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
            btnEliminar.Location = new Point(396, 8);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(57, 67);
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
            btnGuardar.Location = new Point(333, 8);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(57, 67);
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
            btnuevo.Location = new Point(270, 8);
            btnuevo.Name = "btnuevo";
            btnuevo.Size = new Size(57, 67);
            btnuevo.TabIndex = 16;
            btnuevo.UseVisualStyleBackColor = false;
            btnuevo.Click += btnuevo_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 64);
            panel2.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(87, 11);
            label3.Name = "label3";
            label3.Size = new Size(401, 43);
            label3.TabIndex = 0;
            label3.Text = "Registro de Productos";
            // 
            // frmStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(570, 643);
            Controls.Add(customPanel4);
            Controls.Add(customPanel3);
            Controls.Add(customPanel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmStock";
            Text = "Registro de entrada y salida";
            Load += frmStock_Load;
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            customPanel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private Panel panel2;
        private Label label3;
    }
}