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
            pnlButtons = new Panel();
            btnBilling = new Button();
            btnAdministration = new Button();
            pnlMain = new Panel();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(36, 113, 163);
            pnlButtons.Controls.Add(btnBilling);
            pnlButtons.Controls.Add(btnAdministration);
            pnlButtons.Dock = DockStyle.Left;
            pnlButtons.Location = new Point(0, 0);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(172, 450);
            pnlButtons.TabIndex = 0;
            // 
            // btnBilling
            // 
            btnBilling.BackgroundImage = (Image)resources.GetObject("btnBilling.BackgroundImage");
            btnBilling.BackgroundImageLayout = ImageLayout.Stretch;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Location = new Point(24, 176);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(112, 85);
            btnBilling.TabIndex = 1;
            btnBilling.UseVisualStyleBackColor = true;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnAdministration
            // 
            btnAdministration.BackgroundImage = (Image)resources.GetObject("btnAdministration.BackgroundImage");
            btnAdministration.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdministration.FlatStyle = FlatStyle.Flat;
            btnAdministration.Location = new Point(23, 42);
            btnAdministration.Name = "btnAdministration";
            btnAdministration.Size = new Size(112, 85);
            btnAdministration.TabIndex = 0;
            btnAdministration.UseVisualStyleBackColor = true;
            btnAdministration.Click += btnAdministration_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.Black;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(172, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(628, 450);
            pnlMain.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Controls.Add(pnlButtons);
            Name = "FrmMain";
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            Shown += FrmMain_Shown;
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        TaxRepository taxRepository;
        StateRepository stateRepository;
        DocumentTypeRepository documetTypeRepository;
        BillingRepository billingRepository;
        private Panel pnlButtons;
        private Button btnAdministration;
        private Panel pnlMain;
        private Button btnBilling;
    }
}