using DataAccess.Repositories;

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
            toolStripButtonEmployee = new ToolStripButton();
            toolStripButtonCompany = new ToolStripButton();
            toolStripButtonProvider = new ToolStripButton();
            panel1 = new Panel();
            pnlSecond = new Panel();
            customPanel2 = new RoundedBorders.CustomPanel();
            panel3 = new Panel();
            label6 = new Label();
            cmbfields = new ComboBox();
            txtValue = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            pnlDatagrid = new RoundedBorders.CustomPanel();
            pnlPrincipal = new Panel();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            pnlSecond.SuspendLayout();
            customPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(36, 113, 163);
            toolStrip1.ImageScalingSize = new Size(40, 40);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonRole, toolStripButtonUnitMeasurement, toolStripButtonCategory, toolStripButtonProduct, toolStripButtonWarehouse, toolStripButtonClient, toolStripButtonEmployee, toolStripButtonCompany, toolStripButtonProvider });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(800, 49);
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
            // toolStripButtonEmployee
            // 
            toolStripButtonEmployee.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEmployee.Image = (Image)resources.GetObject("toolStripButtonEmployee.Image");
            toolStripButtonEmployee.ImageTransparentColor = Color.Magenta;
            toolStripButtonEmployee.Name = "toolStripButtonEmployee";
            toolStripButtonEmployee.Size = new Size(44, 44);
            toolStripButtonEmployee.Text = "toolStripButton1";
            toolStripButtonEmployee.ToolTipText = "Empleados";
            toolStripButtonEmployee.Click += toolStripButtonEmployee_Click;
            // 
            // toolStripButtonCompany
            // 
            toolStripButtonCompany.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCompany.Image = (Image)resources.GetObject("toolStripButtonCompany.Image");
            toolStripButtonCompany.ImageTransparentColor = Color.Magenta;
            toolStripButtonCompany.Name = "toolStripButtonCompany";
            toolStripButtonCompany.Size = new Size(44, 44);
            toolStripButtonCompany.Text = "toolStripButton1";
            toolStripButtonCompany.ToolTipText = "Empresas";
            toolStripButtonCompany.Click += toolStripButtonCompany_Click;
            // 
            // toolStripButtonProvider
            // 
            toolStripButtonProvider.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonProvider.Image = (Image)resources.GetObject("toolStripButtonProvider.Image");
            toolStripButtonProvider.ImageTransparentColor = Color.Magenta;
            toolStripButtonProvider.Name = "toolStripButtonProvider";
            toolStripButtonProvider.Size = new Size(44, 44);
            toolStripButtonProvider.Text = "toolStripButton1";
            toolStripButtonProvider.ToolTipText = "Proveedor";
            toolStripButtonProvider.Click += toolStripButtonProvider_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlSecond);
            panel1.Controls.Add(pnlPrincipal);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 401);
            panel1.TabIndex = 1;
            // 
            // pnlSecond
            // 
            pnlSecond.BackColor = Color.Black;
            pnlSecond.Controls.Add(customPanel2);
            pnlSecond.Controls.Add(pnlDatagrid);
            pnlSecond.Dock = DockStyle.Fill;
            pnlSecond.Location = new Point(561, 0);
            pnlSecond.Name = "pnlSecond";
            pnlSecond.Size = new Size(239, 401);
            pnlSecond.TabIndex = 1;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(panel3);
            customPanel2.Controls.Add(panel2);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(23, 18);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(200, 212);
            customPanel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(cmbfields);
            panel3.Controls.Add(txtValue);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 148);
            panel3.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 42);
            label6.Name = "label6";
            label6.Size = new Size(87, 24);
            label6.TabIndex = 17;
            label6.Text = "Campos";
            // 
            // cmbfields
            // 
            cmbfields.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbfields.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbfields.FormattingEnabled = true;
            cmbfields.Location = new Point(118, 35);
            cmbfields.Name = "cmbfields";
            cmbfields.Size = new Size(63, 33);
            cmbfields.TabIndex = 18;
            // 
            // txtValue
            // 
            txtValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValue.Location = new Point(118, 77);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(63, 31);
            txtValue.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 82);
            label3.Name = "label3";
            label3.Size = new Size(58, 24);
            label3.TabIndex = 8;
            label3.Text = "Valor";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 64);
            panel2.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(39, 11);
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
            pnlDatagrid.ForeColor = Color.Black;
            pnlDatagrid.GradientAngle = 90F;
            pnlDatagrid.GradientBottomColor = Color.FromArgb(42, 46, 50);
            pnlDatagrid.GradientTopColor = Color.FromArgb(42, 46, 50);
            pnlDatagrid.Location = new Point(23, 238);
            pnlDatagrid.Margin = new Padding(4, 5, 4, 5);
            pnlDatagrid.Name = "pnlDatagrid";
            pnlDatagrid.Size = new Size(199, 146);
            pnlDatagrid.TabIndex = 0;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.BackColor = Color.Black;
            pnlPrincipal.Dock = DockStyle.Left;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(561, 401);
            pnlPrincipal.TabIndex = 0;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "FrmMain";
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmMain_FormClosing;
            Shown += FrmMain_Shown;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            pnlSecond.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Label label5;
        private RoundedBorders.CustomPanel customPanel2;
        private ComboBox cmbfields;
        private Label label6;
        private TextBox txtValue;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private ToolStripButton toolStripButtonEmployee;
        CompanyRepository companyRepository;
        EmployeeRepository employeeRepository;
        IdentificationTypeRepository IdentificationTypeRepository;
        ClientRepository clientRepository;
        RoleRepository roleRepository;
        UnitMeasurementRepository unitMeasurementRepository;
        DataGridView DataGridView;
        StockRepository StockRepository;
        CategoryRepository categoryRepository;
        ProductRepository productRepository;
        PictureRepository pictureRepository;
        WarehouseRepository warehouseRepository;
        UserRepository userRepository;
        ProviderRepository providerRepository;
        RegimenTypeRepository RegimenTypeRepository;
        private ToolStripButton toolStripButtonCompany;
        private ToolStripButton toolStripButtonProvider;
    }
}