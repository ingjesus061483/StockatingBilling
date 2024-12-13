namespace WinFormsApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            toolStrip1 = new ToolStrip();
            toolStripButtonRole = new ToolStripButton();
            toolStripButtonUnitMeasurement = new ToolStripButton();
            toolStripButtonCategory = new ToolStripButton();
            toolStripButtonProduct = new ToolStripButton();
            toolStripButtonWarehouse = new ToolStripButton();
            toolStripButtonClient = new ToolStripButton();
            panel1 = new Panel();
            pnlSecond = new Panel();
            customPanel1 = new RoundedBorders.CustomPanel();
            label5 = new Label();
            customPanel2 = new RoundedBorders.CustomPanel();
            cmbfields = new ComboBox();
            label6 = new Label();
            txtValue = new TextBox();
            label3 = new Label();
            pnlDatagrid = new RoundedBorders.CustomPanel();
            pnlPrincipal = new Panel();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            pnlSecond.SuspendLayout();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(42, 46, 50);
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonRole, toolStripButtonUnitMeasurement, toolStripButtonCategory, toolStripButtonProduct, toolStripButtonWarehouse, toolStripButtonClient });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(560, 47);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonRole
            // 
            toolStripButtonRole.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonRole.Image = (Image)resources.GetObject("toolStripButtonRole.Image");
            toolStripButtonRole.ImageTransparentColor = Color.Magenta;
            toolStripButtonRole.Name = "toolStripButtonRole";
            toolStripButtonRole.Size = new Size(44, 44);
            toolStripButtonRole.Text = "toolStripButton1";
            toolStripButtonRole.ToolTipText = "Roles";
            toolStripButtonRole.Click += toolStripButtonRole_Click;
            // 
            // toolStripButtonUnitMeasurement
            // 
            toolStripButtonUnitMeasurement.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonUnitMeasurement.Image = (Image)resources.GetObject("toolStripButtonUnitMeasurement.Image");
            toolStripButtonUnitMeasurement.ImageTransparentColor = Color.Magenta;
            toolStripButtonUnitMeasurement.Name = "toolStripButtonUnitMeasurement";
            toolStripButtonUnitMeasurement.Size = new Size(44, 44);
            toolStripButtonUnitMeasurement.Text = "Unidad de medida";
            toolStripButtonUnitMeasurement.Click += toolStripButtonUnitMeasurement_Click;
            // 
            // toolStripButtonCategory
            // 
            toolStripButtonCategory.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCategory.Image = (Image)resources.GetObject("toolStripButtonCategory.Image");
            toolStripButtonCategory.ImageTransparentColor = Color.Magenta;
            toolStripButtonCategory.Name = "toolStripButtonCategory";
            toolStripButtonCategory.Size = new Size(44, 44);
            toolStripButtonCategory.Text = "toolStripButton2";
            toolStripButtonCategory.ToolTipText = "Categorias";
            toolStripButtonCategory.Click += toolStripButtonCategory_Click;
            // 
            // toolStripButtonProduct
            // 
            toolStripButtonProduct.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonProduct.Image = (Image)resources.GetObject("toolStripButtonProduct.Image");
            toolStripButtonProduct.ImageTransparentColor = Color.Magenta;
            toolStripButtonProduct.Name = "toolStripButtonProduct";
            toolStripButtonProduct.Size = new Size(44, 44);
            toolStripButtonProduct.Text = "toolStripButton1";
            toolStripButtonProduct.ToolTipText = "Productos";
            toolStripButtonProduct.Click += toolStripButtonProduct_Click;
            // 
            // toolStripButtonWarehouse
            // 
            toolStripButtonWarehouse.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonWarehouse.Image = (Image)resources.GetObject("toolStripButtonWarehouse.Image");
            toolStripButtonWarehouse.ImageTransparentColor = Color.Magenta;
            toolStripButtonWarehouse.Name = "toolStripButtonWarehouse";
            toolStripButtonWarehouse.Size = new Size(44, 44);
            toolStripButtonWarehouse.Text = "toolStripButton1";
            toolStripButtonWarehouse.ToolTipText = "Bodegas";
            toolStripButtonWarehouse.Click += toolStripButtonWarehouse_Click;
            // 
            // toolStripButtonClient
            // 
            toolStripButtonClient.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonClient.Image = (Image)resources.GetObject("toolStripButtonClient.Image");
            toolStripButtonClient.ImageTransparentColor = Color.Magenta;
            toolStripButtonClient.Name = "toolStripButtonClient";
            toolStripButtonClient.Size = new Size(44, 44);
            toolStripButtonClient.Text = "toolStripButton1";
            toolStripButtonClient.ToolTipText = "Clientes";
            toolStripButtonClient.Click += toolStripButtonClient_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlSecond);
            panel1.Controls.Add(pnlPrincipal);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 47);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 223);
            panel1.TabIndex = 1;
            // 
            // pnlSecond
            // 
            pnlSecond.BackColor = Color.Black;
            pnlSecond.Controls.Add(customPanel1);
            pnlSecond.Controls.Add(customPanel2);
            pnlSecond.Controls.Add(pnlDatagrid);
            pnlSecond.Dock = DockStyle.Fill;
            pnlSecond.Location = new Point(393, 0);
            pnlSecond.Margin = new Padding(2);
            pnlSecond.Name = "pnlSecond";
            pnlSecond.Size = new Size(167, 223);
            pnlSecond.TabIndex = 1;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(label5);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel1.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel1.Location = new Point(16, 11);
            customPanel1.Margin = new Padding(2);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(139, 46);
            customPanel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(99, 8);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 29);
            label5.TabIndex = 0;
            label5.Text = "Filtrar por";
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(cmbfields);
            customPanel2.Controls.Add(label6);
            customPanel2.Controls.Add(txtValue);
            customPanel2.Controls.Add(label3);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(16, 60);
            customPanel2.Margin = new Padding(2);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(140, 78);
            customPanel2.TabIndex = 9;
            // 
            // cmbfields
            // 
            cmbfields.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbfields.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbfields.FormattingEnabled = true;
            cmbfields.Location = new Point(84, 15);
            cmbfields.Margin = new Padding(2);
            cmbfields.Name = "cmbfields";
            cmbfields.Size = new Size(45, 23);
            cmbfields.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(16, 19);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 16);
            label6.TabIndex = 17;
            label6.Text = "Campos";
            // 
            // txtValue
            // 
            txtValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValue.Location = new Point(84, 40);
            txtValue.Margin = new Padding(2);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(45, 23);
            txtValue.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(37, 43);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 16);
            label3.TabIndex = 8;
            label3.Text = "Valor";
            // 
            // pnlDatagrid
            // 
            pnlDatagrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDatagrid.BackColor = Color.White;
            pnlDatagrid.BorderRadius = 30;
            pnlDatagrid.ForeColor = Color.Black;
            pnlDatagrid.GradientAngle = 90F;
            pnlDatagrid.GradientBottomColor = Color.FromArgb(42, 46, 50);
            pnlDatagrid.GradientTopColor = Color.FromArgb(42, 46, 50);
            pnlDatagrid.Location = new Point(16, 143);
            pnlDatagrid.Name = "pnlDatagrid";
            pnlDatagrid.Size = new Size(139, 70);
            pnlDatagrid.TabIndex = 0;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.Black;
            pnlPrincipal.Dock = DockStyle.Left;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Margin = new Padding(2);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(393, 223);
            pnlPrincipal.TabIndex = 0;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Margin = new Padding(2);
            Name = "FrmMain";
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            pnlSecond.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonProduct;
        private ToolStripButton toolStripButtonCategory;
        private Panel panel1;
        private Panel pnlSecond;
        private Panel pnlPrincipal;
        private ToolStripButton toolStripButtonUnitMeasurement;
        private ToolStripButton toolStripButtonWarehouse;
        private ToolStripButton toolStripButtonClient;
        private ToolStripButton toolStripButtonRole;
        private RoundedBorders.CustomPanel pnlDatagrid;
        private RoundedBorders.CustomPanel customPanel1;
        private Label label5;
        private RoundedBorders.CustomPanel customPanel2;
        private ComboBox cmbfields;
        private Label label6;
        private TextBox txtValue;
        private Label label3;
    }
}