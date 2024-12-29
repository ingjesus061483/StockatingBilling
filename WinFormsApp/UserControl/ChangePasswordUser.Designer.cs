namespace WinFormsApp
{
    partial class ChangePasswordUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordUser));
            customPanel3 = new RoundedBorders.CustomPanel();
            btnSalir = new Button();
            btnUpdate = new Button();
            customPanel2 = new RoundedBorders.CustomPanel();
            txtConfirmPassword = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtUserName = new TextBox();
            txtNewPassword = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            label2 = new Label();
            customPanel3.SuspendLayout();
            customPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel3
            // 
            customPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(btnSalir);
            customPanel3.Controls.Add(btnUpdate);
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel3.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel3.Location = new Point(17, 278);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(516, 80);
            customPanel3.TabIndex = 14;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(386, 7);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 67);
            btnSalir.TabIndex = 4;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += this.btnSalir_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.BackgroundImage = (Image)resources.GetObject("btnUpdate.BackgroundImage");
            btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(321, 7);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(57, 67);
            btnUpdate.TabIndex = 5;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(txtConfirmPassword);
            customPanel2.Controls.Add(label3);
            customPanel2.Controls.Add(label1);
            customPanel2.Controls.Add(txtUserName);
            customPanel2.Controls.Add(txtNewPassword);
            customPanel2.Controls.Add(panel2);
            customPanel2.Controls.Add(label2);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(17, 25);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(518, 236);
            customPanel2.TabIndex = 13;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmPassword.Location = new Point(223, 170);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(272, 31);
            txtConfirmPassword.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(203, 24);
            label3.TabIndex = 21;
            label3.Text = "Confirmar Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(133, 100);
            label1.Name = "label1";
            label1.Size = new Size(83, 24);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.Location = new Point(223, 96);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(272, 31);
            txtUserName.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNewPassword.Location = new Point(223, 133);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(272, 31);
            txtNewPassword.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 64);
            panel2.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(69, 12);
            label5.Name = "label5";
            label5.Size = new Size(382, 43);
            label5.TabIndex = 0;
            label5.Text = "Cambio de password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 136);
            label2.Name = "label2";
            label2.Size = new Size(168, 24);
            label2.TabIndex = 2;
            label2.Text = "Nueva Password";
            // 
            // ChangePasswordUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(customPanel3);
            Controls.Add(customPanel2);
            Name = "ChangePasswordUser";
            Size = new Size(552, 380);
            Load += ChangePasswordUser_Load;
            customPanel3.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedBorders.CustomPanel customPanel3;
        private Button btnSalir;
        private Button btnUpdate;
        private RoundedBorders.CustomPanel customPanel2;
        private TextBox txtConfirmPassword;
        private Label label3;
        private Label label1;
        private TextBox txtUserName;
        private TextBox txtNewPassword;
        private Panel panel2;
        private Label label5;
        private Label label2;
    }
}
