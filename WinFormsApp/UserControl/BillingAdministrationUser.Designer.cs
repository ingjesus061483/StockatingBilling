namespace WinFormsApp
{
    partial class BillingAdministrationUser
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingAdministrationUser));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            customPanel2 = new RoundedBorders.CustomPanel();
            txtTotal = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            dtpDateEnd = new DateTimePicker();
            chkPeriodo = new CheckBox();
            label3 = new Label();
            label1 = new Label();
            cmbState = new ComboBox();
            txtCode = new TextBox();
            label4 = new Label();
            label2 = new Label();
            dtpDateStar = new DateTimePicker();
            pnlDatagrid = new RoundedBorders.CustomPanel();
            dgBilling = new DataGridView();
            toolStrip1 = new ToolStrip();
            toolStripButtonNew = new ToolStripButton();
            toolStripButtonSearch = new ToolStripButton();
            toolStripButtonPrint = new ToolStripButton();
            toolStripButtonExcel = new ToolStripButton();
            toolStripButtonExit = new ToolStripButton();
            colPrint = new DataGridViewButtonColumn();
            entregar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            ver = new DataGridViewButtonColumn();
            pagar = new DataGridViewButtonColumn();
            customPanel2.SuspendLayout();
            panel2.SuspendLayout();
            pnlDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgBilling).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(txtTotal);
            customPanel2.Controls.Add(label6);
            customPanel2.Controls.Add(panel2);
            customPanel2.Controls.Add(dtpDateEnd);
            customPanel2.Controls.Add(chkPeriodo);
            customPanel2.Controls.Add(label3);
            customPanel2.Controls.Add(label1);
            customPanel2.Controls.Add(cmbState);
            customPanel2.Controls.Add(txtCode);
            customPanel2.Controls.Add(label4);
            customPanel2.Controls.Add(label2);
            customPanel2.Controls.Add(dtpDateStar);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(25, 73);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(753, 248);
            customPanel2.TabIndex = 11;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotal.Font = new Font("Arial", 10F);
            txtTotal.Location = new Point(157, 195);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(559, 30);
            txtTotal.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 198);
            label6.Name = "label6";
            label6.Size = new Size(127, 24);
            label6.TabIndex = 18;
            label6.Text = "Total Ventas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(753, 63);
            panel2.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(39, 12);
            label5.Name = "label5";
            label5.Size = new Size(188, 43);
            label5.TabIndex = 0;
            label5.Text = "Filtrar por";
            // 
            // dtpDateEnd
            // 
            dtpDateEnd.CustomFormat = "yyyy-MM-dd";
            dtpDateEnd.Enabled = false;
            dtpDateEnd.Font = new Font("Arial", 10F);
            dtpDateEnd.Format = DateTimePickerFormat.Custom;
            dtpDateEnd.Location = new Point(559, 86);
            dtpDateEnd.Name = "dtpDateEnd";
            dtpDateEnd.Size = new Size(157, 30);
            dtpDateEnd.TabIndex = 17;
            dtpDateEnd.ValueChanged += dtpDateEnd_ValueChanged;
            // 
            // chkPeriodo
            // 
            chkPeriodo.AutoSize = true;
            chkPeriodo.BackColor = Color.Transparent;
            chkPeriodo.CheckAlign = ContentAlignment.MiddleRight;
            chkPeriodo.Font = new Font("Arial", 10F, FontStyle.Bold);
            chkPeriodo.ForeColor = Color.White;
            chkPeriodo.Location = new Point(39, 89);
            chkPeriodo.Name = "chkPeriodo";
            chkPeriodo.Size = new Size(109, 28);
            chkPeriodo.TabIndex = 13;
            chkPeriodo.Text = "Periodo";
            chkPeriodo.UseVisualStyleBackColor = false;
            chkPeriodo.CheckedChanged += chkPeriodo_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(455, 91);
            label3.Name = "label3";
            label3.Size = new Size(97, 24);
            label3.TabIndex = 16;
            label3.Text = "Fecha fin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 164);
            label1.Name = "label1";
            label1.Size = new Size(120, 24);
            label1.TabIndex = 9;
            label1.Text = "Factura No.";
            // 
            // cmbState
            // 
            cmbState.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbState.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(157, 122);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(559, 33);
            cmbState.TabIndex = 15;
            cmbState.SelectedValueChanged += cmbState_SelectedValueChanged;
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCode.Font = new Font("Arial", 10F);
            txtCode.Location = new Point(157, 160);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(559, 30);
            txtCode.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(70, 127);
            label4.Name = "label4";
            label4.Size = new Size(76, 24);
            label4.TabIndex = 14;
            label4.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(157, 90);
            label2.Name = "label2";
            label2.Size = new Size(123, 24);
            label2.TabIndex = 11;
            label2.Text = "Fecha inicio";
            // 
            // dtpDateStar
            // 
            dtpDateStar.CustomFormat = "yyyy-MM-dd";
            dtpDateStar.Enabled = false;
            dtpDateStar.Font = new Font("Arial", 10F);
            dtpDateStar.Format = DateTimePickerFormat.Custom;
            dtpDateStar.Location = new Point(279, 87);
            dtpDateStar.Name = "dtpDateStar";
            dtpDateStar.Size = new Size(159, 30);
            dtpDateStar.TabIndex = 12;
            dtpDateStar.ValueChanged += dtpDateStar_ValueChanged;
            // 
            // pnlDatagrid
            // 
            pnlDatagrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDatagrid.BackColor = Color.White;
            pnlDatagrid.BorderRadius = 30;
            pnlDatagrid.Controls.Add(dgBilling);
            pnlDatagrid.ForeColor = Color.Black;
            pnlDatagrid.GradientAngle = 90F;
            pnlDatagrid.GradientBottomColor = Color.FromArgb(42, 46, 50);
            pnlDatagrid.GradientTopColor = Color.FromArgb(42, 46, 50);
            pnlDatagrid.Location = new Point(21, 337);
            pnlDatagrid.Margin = new Padding(4, 5, 4, 5);
            pnlDatagrid.Name = "pnlDatagrid";
            pnlDatagrid.Size = new Size(757, 454);
            pnlDatagrid.TabIndex = 10;
            // 
            // dgBilling
            // 
            dgBilling.AllowUserToAddRows = false;
            dgBilling.AllowUserToDeleteRows = false;
            dgBilling.BackgroundColor = Color.FromArgb(42, 46, 50);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(36, 113, 163);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgBilling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgBilling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBilling.Columns.AddRange(new DataGridViewColumn[] { colPrint, entregar, Eliminar, ver, pagar });
            dgBilling.Dock = DockStyle.Fill;
            dgBilling.Location = new Point(0, 0);
            dgBilling.Name = "dgBilling";
            dgBilling.ReadOnly = true;
            dgBilling.RowHeadersVisible = false;
            dgBilling.RowHeadersWidth = 62;
            dgBilling.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgBilling.Size = new Size(757, 454);
            dgBilling.TabIndex = 0;
            dgBilling.CellContentClick += dataGridView1_CellContentClick;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(36, 113, 163);
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNew, toolStripButtonSearch, toolStripButtonPrint, toolStripButtonExcel, toolStripButtonExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(798, 49);
            toolStrip1.TabIndex = 16;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            toolStripButtonNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNew.Image = (Image)resources.GetObject("toolStripButtonNew.Image");
            toolStripButtonNew.ImageTransparentColor = Color.Magenta;
            toolStripButtonNew.Name = "toolStripButtonNew";
            toolStripButtonNew.Size = new Size(44, 44);
            toolStripButtonNew.Text = "toolStripButton1";
            toolStripButtonNew.Click += toolStripButtonNew_Click;
            // 
            // toolStripButtonSearch
            // 
            toolStripButtonSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSearch.Image = (Image)resources.GetObject("toolStripButtonSearch.Image");
            toolStripButtonSearch.ImageTransparentColor = Color.Magenta;
            toolStripButtonSearch.Name = "toolStripButtonSearch";
            toolStripButtonSearch.Size = new Size(44, 44);
            toolStripButtonSearch.Text = "toolStripButton2";
            toolStripButtonSearch.Click += toolStripButtonSearch_Click;
            // 
            // toolStripButtonPrint
            // 
            toolStripButtonPrint.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonPrint.Image = (Image)resources.GetObject("toolStripButtonPrint.Image");
            toolStripButtonPrint.ImageTransparentColor = Color.Magenta;
            toolStripButtonPrint.Name = "toolStripButtonPrint";
            toolStripButtonPrint.Size = new Size(44, 44);
            toolStripButtonPrint.Text = "toolStripButton3";
            // 
            // toolStripButtonExcel
            // 
            toolStripButtonExcel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonExcel.Image = (Image)resources.GetObject("toolStripButtonExcel.Image");
            toolStripButtonExcel.ImageTransparentColor = Color.Magenta;
            toolStripButtonExcel.Name = "toolStripButtonExcel";
            toolStripButtonExcel.Size = new Size(44, 44);
            toolStripButtonExcel.Text = "toolStripButton4";
            toolStripButtonExcel.Click += toolStripButtonExcel_Click;
            // 
            // toolStripButtonExit
            // 
            toolStripButtonExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonExit.Image = (Image)resources.GetObject("toolStripButtonExit.Image");
            toolStripButtonExit.ImageTransparentColor = Color.Magenta;
            toolStripButtonExit.Name = "toolStripButtonExit";
            toolStripButtonExit.Size = new Size(44, 44);
            toolStripButtonExit.Text = "toolStripButton5";
            toolStripButtonExit.Click += toolStripButtonExit_Click;
            // 
            // colPrint
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 147, 60);
            dataGridViewCellStyle2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            colPrint.DefaultCellStyle = dataGridViewCellStyle2;
            colPrint.FlatStyle = FlatStyle.Flat;
            colPrint.HeaderText = "";
            colPrint.MinimumWidth = 8;
            colPrint.Name = "colPrint";
            colPrint.ReadOnly = true;
            colPrint.Text = "Imprimir";
            colPrint.UseColumnTextForButtonValue = true;
            colPrint.Width = 150;
            // 
            // entregar
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entregar.DefaultCellStyle = dataGridViewCellStyle3;
            entregar.FlatStyle = FlatStyle.Flat;
            entregar.HeaderText = "";
            entregar.MinimumWidth = 8;
            entregar.Name = "entregar";
            entregar.ReadOnly = true;
            entregar.Text = "Entregar producto";
            entregar.UseColumnTextForButtonValue = true;
            entregar.Width = 150;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle4.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            Eliminar.DefaultCellStyle = dataGridViewCellStyle4;
            Eliminar.FlatStyle = FlatStyle.Flat;
            Eliminar.HeaderText = "";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            Eliminar.Width = 150;
            // 
            // ver
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Navy;
            dataGridViewCellStyle5.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            ver.DefaultCellStyle = dataGridViewCellStyle5;
            ver.FlatStyle = FlatStyle.Flat;
            ver.HeaderText = "";
            ver.MinimumWidth = 8;
            ver.Name = "ver";
            ver.ReadOnly = true;
            ver.Text = "Ver";
            ver.UseColumnTextForButtonValue = true;
            ver.Width = 150;
            // 
            // pagar
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.Silver;
            dataGridViewCellStyle6.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pagar.DefaultCellStyle = dataGridViewCellStyle6;
            pagar.FlatStyle = FlatStyle.Flat;
            pagar.HeaderText = "";
            pagar.MinimumWidth = 8;
            pagar.Name = "pagar";
            pagar.ReadOnly = true;
            pagar.Text = "Pagar";
            pagar.UseColumnTextForButtonValue = true;
            pagar.Width = 150;
            // 
            // BillingUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(toolStrip1);
            Controls.Add(customPanel2);
            Controls.Add(pnlDatagrid);
            Name = "BillingUser";
            Size = new Size(798, 808);
            Load += BillingUser_Load;
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlDatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgBilling).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedBorders.CustomPanel customPanel2;
        private Panel panel2;
        private Label label5;
        private RoundedBorders.CustomPanel pnlDatagrid;
        private CheckBox chkPeriodo;
        private DateTimePicker dtpDateStar;
        private Label label2;
        private TextBox txtCode;
        private Label label1;
        private ComboBox cmbState;
        private Label label4;
        private TextBox txtTotal;
        private Label label6;
        private DateTimePicker dtpDateEnd;
        private Label label3;
        private DataGridView dgBilling;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonNew;
        private ToolStripButton toolStripButtonSearch;
        private ToolStripButton toolStripButtonPrint;
        private ToolStripButton toolStripButtonExcel;
        private ToolStripButton toolStripButtonExit;
        private DataGridViewButtonColumn colPrint;
        private DataGridViewButtonColumn entregar;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewButtonColumn ver;
        private DataGridViewButtonColumn pagar;
    }
}
