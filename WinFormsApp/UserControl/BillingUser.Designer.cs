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
            customPanel2 = new RoundedBorders.CustomPanel();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            cmbRegimeType = new ComboBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            txtAmount = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            pnlDatagrid = new RoundedBorders.CustomPanel();
            dataGridView1 = new DataGridView();
            customPanel3 = new RoundedBorders.CustomPanel();
            btnSalir = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            colPrint = new DataGridViewButtonColumn();
            customPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            pnlDatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            customPanel3.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(panel3);
            customPanel2.Controls.Add(panel2);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(25, 73);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(753, 275);
            customPanel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(cmbRegimeType);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(dtpDate);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtAmount);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(753, 212);
            panel3.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Arial", 10F);
            textBox1.Location = new Point(154, 142);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(559, 30);
            textBox1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(18, 145);
            label6.Name = "label6";
            label6.Size = new Size(127, 24);
            label6.TabIndex = 18;
            label6.Text = "Total Ventas";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Font = new Font("Arial", 10F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(556, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(157, 30);
            dateTimePicker1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(452, 27);
            label3.Name = "label3";
            label3.Size = new Size(97, 24);
            label3.TabIndex = 16;
            label3.Text = "Fecha fin";
            // 
            // cmbRegimeType
            // 
            cmbRegimeType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbRegimeType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRegimeType.FormattingEnabled = true;
            cmbRegimeType.Location = new Point(154, 63);
            cmbRegimeType.Name = "cmbRegimeType";
            cmbRegimeType.Size = new Size(559, 33);
            cmbRegimeType.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(67, 68);
            label4.Name = "label4";
            label4.Size = new Size(76, 24);
            label4.TabIndex = 14;
            label4.Text = "Estado";
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
            checkBox1.Location = new Point(36, 25);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(109, 28);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Periodo";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "yyyy-MM-dd";
            dtpDate.Font = new Font("Arial", 10F);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(276, 23);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(159, 30);
            dtpDate.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(154, 26);
            label2.Name = "label2";
            label2.Size = new Size(123, 24);
            label2.TabIndex = 11;
            label2.Text = "Fecha inicio";
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAmount.Font = new Font("Arial", 10F);
            txtAmount.Location = new Point(154, 104);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(559, 30);
            txtAmount.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 108);
            label1.Name = "label1";
            label1.Size = new Size(120, 24);
            label1.TabIndex = 9;
            label1.Text = "Factura No.";
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
            // pnlDatagrid
            // 
            pnlDatagrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDatagrid.BackColor = Color.White;
            pnlDatagrid.BorderRadius = 30;
            pnlDatagrid.Controls.Add(dataGridView1);
            pnlDatagrid.ForeColor = Color.Black;
            pnlDatagrid.GradientAngle = 90F;
            pnlDatagrid.GradientBottomColor = Color.FromArgb(42, 46, 50);
            pnlDatagrid.GradientTopColor = Color.FromArgb(42, 46, 50);
            pnlDatagrid.Location = new Point(25, 460);
            pnlDatagrid.Margin = new Padding(4, 5, 4, 5);
            pnlDatagrid.Name = "pnlDatagrid";
            pnlDatagrid.Size = new Size(757, 327);
            pnlDatagrid.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(42, 46, 50);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colPrint });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(757, 327);
            dataGridView1.TabIndex = 0;
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(btnSalir);
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel3.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel3.Location = new Point(25, 361);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(753, 87);
            customPanel3.TabIndex = 15;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(640, 9);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 67);
            btnSalir.TabIndex = 13;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(36, 113, 163);
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(798, 49);
            toolStrip1.TabIndex = 16;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(44, 44);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(44, 44);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(44, 44);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(44, 44);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(44, 44);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // colPrint
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.ForeColor = Color.White;
            colPrint.DefaultCellStyle = dataGridViewCellStyle1;
            colPrint.FlatStyle = FlatStyle.Flat;
            colPrint.HeaderText = "";
            colPrint.MinimumWidth = 8;
            colPrint.Name = "colPrint";
            colPrint.Text = "Imprimir";
            colPrint.UseColumnTextForButtonValue = true;
            colPrint.Width = 150;
            // 
            // BillingUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(toolStrip1);
            Controls.Add(customPanel3);
            Controls.Add(customPanel2);
            Controls.Add(pnlDatagrid);
            Name = "BillingUser";
            Size = new Size(798, 808);
            customPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlDatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            customPanel3.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundedBorders.CustomPanel customPanel2;
        private Panel panel3;
        private Panel panel2;
        private Label label5;
        private RoundedBorders.CustomPanel pnlDatagrid;
        private CheckBox checkBox1;
        private DateTimePicker dtpDate;
        private Label label2;
        private TextBox txtAmount;
        private Label label1;
        private ComboBox cmbRegimeType;
        private Label label4;
        private TextBox textBox1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private RoundedBorders.CustomPanel customPanel3;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private DataGridViewButtonColumn colPrint;
    }
}
