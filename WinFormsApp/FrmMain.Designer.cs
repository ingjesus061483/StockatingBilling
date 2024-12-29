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
            customPanel1 = new RoundedBorders.CustomPanel();
            lblUser = new Label();
            btnChangePassword = new Button();
            button1 = new Button();
            lblRole = new Label();
            btnBilling = new Button();
            btnAdministration = new Button();
            pnlMain = new Panel();
            pnlButtons.SuspendLayout();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(36, 113, 163);
            pnlButtons.Controls.Add(customPanel1);
            pnlButtons.Controls.Add(btnBilling);
            pnlButtons.Controls.Add(btnAdministration);
            pnlButtons.Dock = DockStyle.Left;
            pnlButtons.Location = new Point(0, 0);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(260, 450);
            pnlButtons.TabIndex = 0;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(lblUser);
            customPanel1.Controls.Add(btnChangePassword);
            customPanel1.Controls.Add(button1);
            customPanel1.Controls.Add(lblRole);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel1.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel1.Location = new Point(23, 278);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(178, 139);
            customPanel1.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Arial", 8F, FontStyle.Bold);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(21, 17);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(69, 19);
            lblUser.TabIndex = 33;
            lblUser.Text = "Usuario";
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackgroundImage = (Image)resources.GetObject("btnChangePassword.BackgroundImage");
            btnChangePassword.BackgroundImageLayout = ImageLayout.Stretch;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Location = new Point(85, 68);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(58, 44);
            btnChangePassword.TabIndex = 32;
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(21, 68);
            button1.Name = "button1";
            button1.Size = new Size(58, 44);
            button1.TabIndex = 31;
            button1.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Arial", 8F, FontStyle.Bold);
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(21, 44);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(69, 19);
            lblRole.TabIndex = 27;
            lblRole.Text = "Usuario";
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
            pnlMain.Location = new Point(260, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(709, 450);
            pnlMain.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(969, 450);
            Controls.Add(pnlMain);
            Controls.Add(pnlButtons);
            Name = "FrmMain";
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            Shown += FrmMain_Shown;
            pnlButtons.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        CompanyRepository companyRepository;
        EmployeeRepository employeeRepository;
        IdentificationTypeRepository IdentificationTypeRepository;
        ClientRepository clientRepository;
        RoleRepository roleRepository;
        UnitMeasurementRepository unitMeasurementRepository;
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
        private RoundedBorders.CustomPanel customPanel1;
        private Button button1;
        private Label label1;
        private TextBox txtUserName;
        private Label lblRole;
        private Button btnChangePassword;
        private Label lblUser;
    }
}