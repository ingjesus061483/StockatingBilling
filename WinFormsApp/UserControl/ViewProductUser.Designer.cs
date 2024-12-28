namespace WinFormsApp
{
    partial class ViewProductUser
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProductUser));
            customPanel6 = new RoundedBorders.CustomPanel();
            txtStock = new TextBox();
            label8 = new Label();
            txtExit = new TextBox();
            label7 = new Label();
            txtEntrance = new TextBox();
            label6 = new Label();
            customPanel1 = new RoundedBorders.CustomPanel();
            dgExits = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label5 = new Label();
            customPanel4 = new RoundedBorders.CustomPanel();
            btnExit = new Button();
            btnExcel = new Button();
            customPanel3 = new RoundedBorders.CustomPanel();
            dgEntrance = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            bodega = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            entrada = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label4 = new Label();
            customPanel2 = new RoundedBorders.CustomPanel();
            txtCategory = new TextBox();
            txtUnitMeasurement = new TextBox();
            txtCode = new TextBox();
            label1 = new Label();
            txtUnitCost = new TextBox();
            label2 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtPrice = new TextBox();
            label11 = new Label();
            txtDescription = new TextBox();
            label12 = new Label();
            txtName = new TextBox();
            label13 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            customPanel5 = new RoundedBorders.CustomPanel();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            btnWarehouse = new Button();
            txtWarehouse = new TextBox();
            customPanel7 = new RoundedBorders.CustomPanel();
            customPanel6.SuspendLayout();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgExits).BeginInit();
            panel3.SuspendLayout();
            customPanel4.SuspendLayout();
            customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgEntrance).BeginInit();
            panel1.SuspendLayout();
            customPanel2.SuspendLayout();
            panel2.SuspendLayout();
            customPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            customPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel6
            // 
            customPanel6.BackColor = Color.White;
            customPanel6.BorderRadius = 30;
            customPanel6.Controls.Add(txtStock);
            customPanel6.Controls.Add(label8);
            customPanel6.Controls.Add(txtExit);
            customPanel6.Controls.Add(label7);
            customPanel6.Controls.Add(txtEntrance);
            customPanel6.Controls.Add(label6);
            customPanel6.ForeColor = Color.Black;
            customPanel6.GradientAngle = 90F;
            customPanel6.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel6.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel6.Location = new Point(645, 735);
            customPanel6.Name = "customPanel6";
            customPanel6.Size = new Size(349, 147);
            customPanel6.TabIndex = 20;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStock.Font = new Font("Arial", 10F);
            txtStock.Location = new Point(179, 95);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(152, 30);
            txtStock.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 10F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 99);
            label8.Name = "label8";
            label8.Size = new Size(160, 24);
            label8.TabIndex = 10;
            label8.Text = "Total Existencia";
            // 
            // txtExit
            // 
            txtExit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtExit.Font = new Font("Arial", 10F);
            txtExit.Location = new Point(179, 58);
            txtExit.Name = "txtExit";
            txtExit.Size = new Size(153, 30);
            txtExit.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 10F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(52, 62);
            label7.Name = "label7";
            label7.Size = new Size(120, 24);
            label7.TabIndex = 8;
            label7.Text = "Total Salida";
            // 
            // txtEntrance
            // 
            txtEntrance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEntrance.Font = new Font("Arial", 10F);
            txtEntrance.Location = new Point(179, 22);
            txtEntrance.Name = "txtEntrance";
            txtEntrance.Size = new Size(153, 30);
            txtEntrance.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(36, 26);
            label6.Name = "label6";
            label6.Size = new Size(137, 24);
            label6.TabIndex = 6;
            label6.Text = "Total Entrada";
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(dgExits);
            customPanel1.Controls.Add(panel3);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(224, 224, 224);
            customPanel1.GradientTopColor = Color.FromArgb(224, 224, 224);
            customPanel1.Location = new Point(534, 492);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(460, 230);
            customPanel1.TabIndex = 19;
            // 
            // dgExits
            // 
            dgExits.AllowUserToAddRows = false;
            dgExits.AllowUserToDeleteRows = false;
            dgExits.BackgroundColor = Color.FromArgb(42, 46, 50);
            dgExits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgExits.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgExits.Dock = DockStyle.Fill;
            dgExits.Location = new Point(0, 63);
            dgExits.Name = "dgExits";
            dgExits.ReadOnly = true;
            dgExits.RowHeadersVisible = false;
            dgExits.RowHeadersWidth = 62;
            dgExits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgExits.Size = new Size(460, 167);
            dgExits.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewTextBoxColumn1.HeaderText = "id";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "warehouse";
            dataGridViewTextBoxColumn2.HeaderText = "bodega";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "ProductName";
            dataGridViewTextBoxColumn3.HeaderText = "producto";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            dataGridViewTextBoxColumn4.HeaderText = "cantidad";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            dataGridViewTextBoxColumn5.HeaderText = "fecha";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Entrance";
            dataGridViewTextBoxColumn6.HeaderText = "entrada";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(36, 113, 163);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 63);
            panel3.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(87, 12);
            label5.Name = "label5";
            label5.Size = new Size(144, 43);
            label5.TabIndex = 0;
            label5.Text = "Salidas";
            // 
            // customPanel4
            // 
            customPanel4.BackColor = Color.White;
            customPanel4.BorderRadius = 30;
            customPanel4.Controls.Add(btnExit);
            customPanel4.Controls.Add(btnExcel);
            customPanel4.ForeColor = Color.Black;
            customPanel4.GradientAngle = 90F;
            customPanel4.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel4.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel4.Location = new Point(357, 897);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(637, 83);
            customPanel4.TabIndex = 18;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(532, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(57, 67);
            btnExit.TabIndex = 13;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.Transparent;
            btnExcel.BackgroundImage = (Image)resources.GetObject("btnExcel.BackgroundImage");
            btnExcel.BackgroundImageLayout = ImageLayout.Stretch;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Location = new Point(469, 6);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(57, 67);
            btnExcel.TabIndex = 14;
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += this.btnExcel_Click;
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(dgEntrance);
            customPanel3.Controls.Add(panel1);
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(224, 224, 224);
            customPanel3.GradientTopColor = Color.FromArgb(224, 224, 224);
            customPanel3.Location = new Point(28, 634);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(488, 230);
            customPanel3.TabIndex = 17;
            // 
            // dgEntrance
            // 
            dgEntrance.AllowUserToAddRows = false;
            dgEntrance.AllowUserToDeleteRows = false;
            dgEntrance.BackgroundColor = Color.FromArgb(42, 46, 50);
            dgEntrance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEntrance.Columns.AddRange(new DataGridViewColumn[] { id, bodega, producto, cantidad, fecha, entrada });
            dgEntrance.Dock = DockStyle.Fill;
            dgEntrance.Location = new Point(0, 63);
            dgEntrance.Name = "dgEntrance";
            dgEntrance.ReadOnly = true;
            dgEntrance.RowHeadersVisible = false;
            dgEntrance.RowHeadersWidth = 62;
            dgEntrance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgEntrance.Size = new Size(488, 167);
            dgEntrance.TabIndex = 0;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 113, 163);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 63);
            panel1.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(87, 12);
            label4.Name = "label4";
            label4.Size = new Size(173, 43);
            label4.TabIndex = 0;
            label4.Text = "Entradas";
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(txtCategory);
            customPanel2.Controls.Add(txtUnitMeasurement);
            customPanel2.Controls.Add(txtCode);
            customPanel2.Controls.Add(label1);
            customPanel2.Controls.Add(txtUnitCost);
            customPanel2.Controls.Add(label2);
            customPanel2.Controls.Add(label9);
            customPanel2.Controls.Add(label10);
            customPanel2.Controls.Add(txtPrice);
            customPanel2.Controls.Add(label11);
            customPanel2.Controls.Add(txtDescription);
            customPanel2.Controls.Add(label12);
            customPanel2.Controls.Add(txtName);
            customPanel2.Controls.Add(label13);
            customPanel2.Controls.Add(panel2);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(28, 94);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(488, 507);
            customPanel2.TabIndex = 16;
            // 
            // txtCategory
            // 
            txtCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCategory.Location = new Point(193, 279);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(274, 31);
            txtCategory.TabIndex = 41;
            // 
            // txtUnitMeasurement
            // 
            txtUnitMeasurement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitMeasurement.Location = new Point(192, 241);
            txtUnitMeasurement.Name = "txtUnitMeasurement";
            txtUnitMeasurement.ReadOnly = true;
            txtUnitMeasurement.Size = new Size(274, 31);
            txtUnitMeasurement.TabIndex = 40;
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCode.Location = new Point(192, 90);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(274, 31);
            txtCode.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(102, 95);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 38;
            label1.Text = "Codigo";
            // 
            // txtUnitCost
            // 
            txtUnitCost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitCost.Location = new Point(192, 165);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.ReadOnly = true;
            txtUnitCost.Size = new Size(274, 31);
            txtUnitCost.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(117, 169);
            label2.Name = "label2";
            label2.Size = new Size(66, 24);
            label2.TabIndex = 36;
            label2.Text = "Costo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 10F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(25, 248);
            label9.Name = "label9";
            label9.Size = new Size(150, 24);
            label9.TabIndex = 34;
            label9.Text = "Unidad Medida";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 10F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(78, 283);
            label10.Name = "label10";
            label10.Size = new Size(101, 24);
            label10.TabIndex = 32;
            label10.Text = "Categoria";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrice.Location = new Point(192, 203);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(274, 31);
            txtPrice.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial", 10F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(111, 208);
            label11.Name = "label11";
            label11.Size = new Size(70, 24);
            label11.TabIndex = 30;
            label11.Text = "Precio";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(192, 317);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Both;
            txtDescription.Size = new Size(274, 174);
            txtDescription.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Arial", 10F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(55, 323);
            label12.Name = "label12";
            label12.Size = new Size(122, 24);
            label12.TabIndex = 28;
            label12.Text = "Descripcion";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(192, 127);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(274, 31);
            txtName.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Arial", 10F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(95, 132);
            label13.Name = "label13";
            label13.Size = new Size(84, 24);
            label13.TabIndex = 26;
            label13.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 63);
            panel2.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(87, 12);
            label3.Name = "label3";
            label3.Size = new Size(401, 43);
            label3.TabIndex = 0;
            label3.Text = "Registro de Productos";
            // 
            // customPanel5
            // 
            customPanel5.BackColor = Color.White;
            customPanel5.BorderRadius = 30;
            customPanel5.Controls.Add(dataGridView3);
            customPanel5.ForeColor = Color.Black;
            customPanel5.GradientAngle = 90F;
            customPanel5.GradientBottomColor = Color.CadetBlue;
            customPanel5.GradientTopColor = Color.DodgerBlue;
            customPanel5.Location = new Point(534, 94);
            customPanel5.Name = "customPanel5";
            customPanel5.Size = new Size(460, 385);
            customPanel5.TabIndex = 25;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.BackgroundColor = Color.FromArgb(42, 46, 50);
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(460, 385);
            dataGridView3.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "id";
            dataGridViewTextBoxColumn7.HeaderText = "id";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "warehouse";
            dataGridViewTextBoxColumn8.HeaderText = "bodega";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "ProductName";
            dataGridViewTextBoxColumn9.HeaderText = "producto";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "Amount";
            dataGridViewTextBoxColumn10.HeaderText = "cantidad";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "Date";
            dataGridViewTextBoxColumn11.HeaderText = "fecha";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "Entrance";
            dataGridViewTextBoxColumn12.HeaderText = "entrada";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 150;
            // 
            // btnWarehouse
            // 
            btnWarehouse.BackColor = Color.Transparent;
            btnWarehouse.BackgroundImage = (Image)resources.GetObject("btnWarehouse.BackgroundImage");
            btnWarehouse.BackgroundImageLayout = ImageLayout.Stretch;
            btnWarehouse.FlatStyle = FlatStyle.Flat;
            btnWarehouse.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnWarehouse.Location = new Point(16, 16);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(43, 32);
            btnWarehouse.TabIndex = 3;
            btnWarehouse.UseVisualStyleBackColor = false;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // txtWarehouse
            // 
            txtWarehouse.Font = new Font("Arial", 10F);
            txtWarehouse.Location = new Point(62, 16);
            txtWarehouse.Name = "txtWarehouse";
            txtWarehouse.ReadOnly = true;
            txtWarehouse.Size = new Size(404, 30);
            txtWarehouse.TabIndex = 2;
            // 
            // customPanel7
            // 
            customPanel7.BackColor = Color.White;
            customPanel7.BorderRadius = 30;
            customPanel7.Controls.Add(btnWarehouse);
            customPanel7.Controls.Add(txtWarehouse);
            customPanel7.ForeColor = Color.Black;
            customPanel7.GradientAngle = 90F;
            customPanel7.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel7.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel7.Location = new Point(28, 17);
            customPanel7.Name = "customPanel7";
            customPanel7.Size = new Size(488, 60);
            customPanel7.TabIndex = 26;
            // 
            // ViewProductUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(customPanel7);
            Controls.Add(customPanel2);
            Controls.Add(customPanel6);
            Controls.Add(customPanel1);
            Controls.Add(customPanel4);
            Controls.Add(customPanel3);
            Controls.Add(customPanel5);
            Name = "ViewProductUser";
            Size = new Size(1011, 995);
            Load += ViewProductUser_Load;
            customPanel6.ResumeLayout(false);
            customPanel6.PerformLayout();
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgExits).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            customPanel4.ResumeLayout(false);
            customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgEntrance).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            customPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            customPanel7.ResumeLayout(false);
            customPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedBorders.CustomPanel customPanel6;
        private TextBox txtStock;
        private Label label8;
        private TextBox txtExit;
        private Label label7;
        private TextBox txtEntrance;
        private Label label6;
        private RoundedBorders.CustomPanel customPanel1;
        private DataGridView dgExits;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Panel panel3;
        private Label label5;
        private RoundedBorders.CustomPanel customPanel4;
        private Button btnExit;
        private Button btnExcel;
        private RoundedBorders.CustomPanel customPanel3;
        private DataGridView dgEntrance;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn bodega;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn entrada;
        private Panel panel1;
        private Label label4;
        private RoundedBorders.CustomPanel customPanel2;
        private RoundedBorders.CustomPanel customPanel5;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Panel panel2;
        private Label label3;
        private Button btnWarehouse;
        private TextBox txtWarehouse;
        private TextBox txtCode;
        private Label label1;
        private TextBox txtUnitCost;
        private Label label2;
        private Label label9;
        private Label label10;
        private TextBox txtPrice;
        private Label label11;
        private TextBox txtDescription;
        private Label label12;
        private TextBox txtName;
        private Label label13;
        private RoundedBorders.CustomPanel customPanel7;
        private TextBox txtCategory;
        private TextBox txtUnitMeasurement;
    }
}
