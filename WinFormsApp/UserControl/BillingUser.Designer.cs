namespace WinFormsApp
{
    partial class BillingUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingUser));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            customPanelRemark = new RoundedBorders.CustomPanel();
            txtRemark = new TextBox();
            panel4 = new Panel();
            label15 = new Label();
            customPanel6 = new RoundedBorders.CustomPanel();
            btnSalir = new Button();
            btnSave = new Button();
            btnNew = new Button();
            customPanel5 = new RoundedBorders.CustomPanel();
            btnBilllDetail = new Button();
            customPanelTotal = new RoundedBorders.CustomPanel();
            TxtTotalPay = new TextBox();
            label9 = new Label();
            txtSubtotal = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            customPanelDtagrid = new RoundedBorders.CustomPanel();
            dgDetail = new DataGridView();
            Delete = new DataGridViewButtonColumn();
            customPanelHeder = new RoundedBorders.CustomPanel();
            chkCredit = new CheckBox();
            dtpDate = new DateTimePicker();
            label16 = new Label();
            cmbDocumentType = new ComboBox();
            label14 = new Label();
            btnEmployee = new Button();
            txtEmployee = new TextBox();
            btnClient = new Button();
            txtClient = new TextBox();
            txtCode = new TextBox();
            label13 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            customPanelRemark.SuspendLayout();
            panel4.SuspendLayout();
            customPanel6.SuspendLayout();
            customPanel5.SuspendLayout();
            customPanelTotal.SuspendLayout();
            panel3.SuspendLayout();
            customPanelDtagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDetail).BeginInit();
            customPanelHeder.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // customPanelRemark
            // 
            customPanelRemark.BackColor = Color.White;
            customPanelRemark.BorderRadius = 30;
            customPanelRemark.Controls.Add(txtRemark);
            customPanelRemark.Controls.Add(panel4);
            customPanelRemark.ForeColor = Color.Black;
            customPanelRemark.GradientAngle = 90F;
            customPanelRemark.GradientBottomColor = Color.CadetBlue;
            customPanelRemark.GradientTopColor = Color.DodgerBlue;
            customPanelRemark.Location = new Point(32, 658);
            customPanelRemark.Name = "customPanelRemark";
            customPanelRemark.Size = new Size(275, 151);
            customPanelRemark.TabIndex = 13;
            // 
            // txtRemark
            // 
            txtRemark.Dock = DockStyle.Fill;
            txtRemark.Location = new Point(0, 48);
            txtRemark.Multiline = true;
            txtRemark.Name = "txtRemark";
            txtRemark.ScrollBars = ScrollBars.Both;
            txtRemark.Size = new Size(275, 103);
            txtRemark.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(36, 113, 163);
            panel4.Controls.Add(label15);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(275, 48);
            panel4.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(2, 3);
            label15.Name = "label15";
            label15.Size = new Size(252, 43);
            label15.TabIndex = 1;
            label15.Text = "Observciones";
            // 
            // customPanel6
            // 
            customPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel6.BackColor = Color.White;
            customPanel6.BorderRadius = 30;
            customPanel6.Controls.Add(btnSalir);
            customPanel6.Controls.Add(btnSave);
            customPanel6.Controls.Add(btnNew);
            customPanel6.ForeColor = Color.Black;
            customPanel6.GradientAngle = 90F;
            customPanel6.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel6.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel6.Location = new Point(25, 822);
            customPanel6.Name = "customPanel6";
            customPanel6.Size = new Size(579, 81);
            customPanel6.TabIndex = 12;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(488, 9);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 67);
            btnSalir.TabIndex = 19;
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(425, 9);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(57, 67);
            btnSave.TabIndex = 17;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Transparent;
            btnNew.BackgroundImage = (Image)resources.GetObject("btnNew.BackgroundImage");
            btnNew.BackgroundImageLayout = ImageLayout.Stretch;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Location = new Point(362, 9);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(57, 67);
            btnNew.TabIndex = 18;
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // customPanel5
            // 
            customPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel5.BackColor = Color.White;
            customPanel5.BorderRadius = 30;
            customPanel5.Controls.Add(btnBilllDetail);
            customPanel5.ForeColor = Color.Black;
            customPanel5.GradientAngle = 90F;
            customPanel5.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel5.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel5.Location = new Point(32, 314);
            customPanel5.Name = "customPanel5";
            customPanel5.Size = new Size(579, 81);
            customPanel5.TabIndex = 11;
            // 
            // btnBilllDetail
            // 
            btnBilllDetail.BackColor = Color.Transparent;
            btnBilllDetail.BackgroundImage = (Image)resources.GetObject("btnBilllDetail.BackgroundImage");
            btnBilllDetail.BackgroundImageLayout = ImageLayout.Stretch;
            btnBilllDetail.FlatStyle = FlatStyle.Flat;
            btnBilllDetail.Location = new Point(488, 5);
            btnBilllDetail.Name = "btnBilllDetail";
            btnBilllDetail.Size = new Size(57, 67);
            btnBilllDetail.TabIndex = 17;
            btnBilllDetail.UseVisualStyleBackColor = false;
            btnBilllDetail.Click += btnBilllDetail_Click;
            // 
            // customPanelTotal
            // 
            customPanelTotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanelTotal.BackColor = Color.White;
            customPanelTotal.BorderRadius = 30;
            customPanelTotal.Controls.Add(TxtTotalPay);
            customPanelTotal.Controls.Add(label9);
            customPanelTotal.Controls.Add(txtSubtotal);
            customPanelTotal.Controls.Add(label6);
            customPanelTotal.Controls.Add(panel3);
            customPanelTotal.ForeColor = Color.Black;
            customPanelTotal.GradientAngle = 90F;
            customPanelTotal.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanelTotal.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanelTotal.Location = new Point(322, 658);
            customPanelTotal.Name = "customPanelTotal";
            customPanelTotal.Size = new Size(289, 151);
            customPanelTotal.TabIndex = 10;
            // 
            // TxtTotalPay
            // 
            TxtTotalPay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtTotalPay.Font = new Font("Arial", 10F);
            TxtTotalPay.Location = new Point(145, 102);
            TxtTotalPay.Name = "TxtTotalPay";
            TxtTotalPay.Size = new Size(120, 30);
            TxtTotalPay.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 10F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 105);
            label9.Name = "label9";
            label9.Size = new Size(134, 24);
            label9.TabIndex = 18;
            label9.Text = "Total a pagar";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSubtotal.Font = new Font("Arial", 10F);
            txtSubtotal.Location = new Point(145, 68);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(120, 30);
            txtSubtotal.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(48, 71);
            label6.Name = "label6";
            label6.Size = new Size(89, 24);
            label6.TabIndex = 12;
            label6.Text = "Subtotal";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(36, 113, 163);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 48);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(86, 3);
            label2.Name = "label2";
            label2.Size = new Size(142, 43);
            label2.TabIndex = 1;
            label2.Text = "Totales";
            // 
            // customPanelDtagrid
            // 
            customPanelDtagrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanelDtagrid.BackColor = Color.White;
            customPanelDtagrid.BorderRadius = 30;
            customPanelDtagrid.Controls.Add(dgDetail);
            customPanelDtagrid.ForeColor = Color.Black;
            customPanelDtagrid.GradientAngle = 90F;
            customPanelDtagrid.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanelDtagrid.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanelDtagrid.Location = new Point(32, 404);
            customPanelDtagrid.Name = "customPanelDtagrid";
            customPanelDtagrid.Size = new Size(579, 243);
            customPanelDtagrid.TabIndex = 9;
            // 
            // dgDetail
            // 
            dgDetail.AllowUserToAddRows = false;
            dgDetail.AllowUserToDeleteRows = false;
            dgDetail.BackgroundColor = Color.FromArgb(42, 46, 50);
            dgDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDetail.Columns.AddRange(new DataGridViewColumn[] { Delete });
            dgDetail.Dock = DockStyle.Fill;
            dgDetail.Location = new Point(0, 0);
            dgDetail.Name = "dgDetail";
            dgDetail.ReadOnly = true;
            dgDetail.RowHeadersVisible = false;
            dgDetail.RowHeadersWidth = 62;
            dgDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDetail.Size = new Size(579, 243);
            dgDetail.TabIndex = 1;
            // 
            // Delete
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            Delete.DefaultCellStyle = dataGridViewCellStyle1;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.HeaderText = "";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Eliminar";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 150;
            // 
            // customPanelHeder
            // 
            customPanelHeder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanelHeder.BackColor = Color.White;
            customPanelHeder.BorderRadius = 30;
            customPanelHeder.Controls.Add(chkCredit);
            customPanelHeder.Controls.Add(dtpDate);
            customPanelHeder.Controls.Add(label16);
            customPanelHeder.Controls.Add(cmbDocumentType);
            customPanelHeder.Controls.Add(label14);
            customPanelHeder.Controls.Add(btnEmployee);
            customPanelHeder.Controls.Add(txtEmployee);
            customPanelHeder.Controls.Add(btnClient);
            customPanelHeder.Controls.Add(txtClient);
            customPanelHeder.Controls.Add(txtCode);
            customPanelHeder.Controls.Add(label13);
            customPanelHeder.Controls.Add(panel1);
            customPanelHeder.ForeColor = Color.Black;
            customPanelHeder.GradientAngle = 90F;
            customPanelHeder.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanelHeder.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanelHeder.Location = new Point(30, 27);
            customPanelHeder.Name = "customPanelHeder";
            customPanelHeder.Size = new Size(581, 275);
            customPanelHeder.TabIndex = 8;
            // 
            // chkCredit
            // 
            chkCredit.AutoSize = true;
            chkCredit.BackColor = Color.Transparent;
            chkCredit.CheckAlign = ContentAlignment.MiddleRight;
            chkCredit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkCredit.ForeColor = Color.White;
            chkCredit.Location = new Point(70, 217);
            chkCredit.Name = "chkCredit";
            chkCredit.Size = new Size(107, 32);
            chkCredit.TabIndex = 37;
            chkCredit.Text = "Credito";
            chkCredit.UseVisualStyleBackColor = false;
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDate.CustomFormat = "yyyy-MM-dd";
            dtpDate.Font = new Font("Arial", 10F);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(325, 217);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(230, 30);
            dtpDate.TabIndex = 36;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Arial", 10F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(249, 221);
            label16.Name = "label16";
            label16.Size = new Size(67, 24);
            label16.TabIndex = 35;
            label16.Text = "Fecha";
            // 
            // cmbDocumentType
            // 
            cmbDocumentType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbDocumentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDocumentType.FormattingEnabled = true;
            cmbDocumentType.Location = new Point(154, 180);
            cmbDocumentType.Name = "cmbDocumentType";
            cmbDocumentType.Size = new Size(401, 33);
            cmbDocumentType.TabIndex = 34;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial", 10F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(28, 184);
            label14.Name = "label14";
            label14.Size = new Size(118, 24);
            label14.TabIndex = 33;
            label14.Text = "Documento";
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.Transparent;
            btnEmployee.BackgroundImage = (Image)resources.GetObject("btnEmployee.BackgroundImage");
            btnEmployee.BackgroundImageLayout = ImageLayout.Stretch;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnEmployee.Location = new Point(109, 144);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(38, 32);
            btnEmployee.TabIndex = 32;
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // txtEmployee
            // 
            txtEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmployee.Font = new Font("Arial", 10F);
            txtEmployee.Location = new Point(155, 145);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.ReadOnly = true;
            txtEmployee.Size = new Size(401, 30);
            txtEmployee.TabIndex = 31;
            // 
            // btnClient
            // 
            btnClient.BackColor = Color.Transparent;
            btnClient.BackgroundImage = (Image)resources.GetObject("btnClient.BackgroundImage");
            btnClient.BackgroundImageLayout = ImageLayout.Stretch;
            btnClient.FlatStyle = FlatStyle.Flat;
            btnClient.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnClient.Location = new Point(110, 109);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(37, 32);
            btnClient.TabIndex = 30;
            btnClient.UseVisualStyleBackColor = false;
            btnClient.Click += btnClient_Click;
            // 
            // txtClient
            // 
            txtClient.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClient.Font = new Font("Arial", 10F);
            txtClient.Location = new Point(156, 110);
            txtClient.Name = "txtClient";
            txtClient.ReadOnly = true;
            txtClient.Size = new Size(401, 30);
            txtClient.TabIndex = 29;
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCode.Font = new Font("Arial", 10F);
            txtCode.Location = new Point(156, 75);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(401, 30);
            txtCode.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Arial", 10F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(70, 78);
            label13.Name = "label13";
            label13.Size = new Size(77, 24);
            label13.TabIndex = 25;
            label13.Text = "Codigo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 113, 163);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 48);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(144, 3);
            label5.Name = "label5";
            label5.Size = new Size(230, 43);
            label5.TabIndex = 1;
            label5.Text = "Encabezado";
            // 
            // BillingUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(customPanelRemark);
            Controls.Add(customPanel6);
            Controls.Add(customPanel5);
            Controls.Add(customPanelTotal);
            Controls.Add(customPanelDtagrid);
            Controls.Add(customPanelHeder);
            Name = "BillingUser";
            Size = new Size(646, 924);
            Load += this.BillingUser_Load;
            customPanelRemark.ResumeLayout(false);
            customPanelRemark.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            customPanel6.ResumeLayout(false);
            customPanel5.ResumeLayout(false);
            customPanelTotal.ResumeLayout(false);
            customPanelTotal.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            customPanelDtagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDetail).EndInit();
            customPanelHeder.ResumeLayout(false);
            customPanelHeder.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedBorders.CustomPanel customPanelRemark;
        private TextBox txtRemark;
        private Panel panel4;
        private Label label15;
        private RoundedBorders.CustomPanel customPanel6;
        private Button btnSalir;
        private Button btnSave;
        private Button btnNew;
        private RoundedBorders.CustomPanel customPanel5;
        private Button btnBilllDetail;
        private RoundedBorders.CustomPanel customPanelTotal;
        private TextBox TxtTotalPay;
        private Label label9;
        private TextBox txtSubtotal;
        private Label label6;
        private Panel panel3;
        private Label label2;
        private RoundedBorders.CustomPanel customPanelDtagrid;
        private DataGridView dgDetail;
        private DataGridViewButtonColumn Delete;
        private RoundedBorders.CustomPanel customPanelHeder;
        private CheckBox chkCredit;
        private DateTimePicker dtpDate;
        private Label label16;
        private ComboBox cmbDocumentType;
        private Label label14;
        private Button btnEmployee;
        private TextBox txtEmployee;
        private Button btnClient;
        private TextBox txtClient;
        private TextBox txtCode;
        private Label label13;
        private Panel panel1;
        private Label label5;
    }
}
