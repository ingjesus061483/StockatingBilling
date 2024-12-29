namespace WinFormsApp
{
    partial class LoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUser));
            customPanel3 = new RoundedBorders.CustomPanel();
            btnSalir = new Button();
            btnLogin = new Button();
            customPanel2 = new RoundedBorders.CustomPanel();
            label1 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
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
            customPanel3.Controls.Add(btnLogin);
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel3.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel3.Location = new Point(22, 247);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(511, 80);
            customPanel3.TabIndex = 12;
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
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(321, 7);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(57, 67);
            btnLogin.TabIndex = 5;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(label1);
            customPanel2.Controls.Add(txtUserName);
            customPanel2.Controls.Add(txtPassword);
            customPanel2.Controls.Add(panel2);
            customPanel2.Controls.Add(label2);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(20, 24);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(513, 208);
            customPanel2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 102);
            label1.Name = "label1";
            label1.Size = new Size(83, 24);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.Location = new Point(173, 96);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(312, 31);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(173, 137);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(312, 31);
            txtPassword.TabIndex = 3;
            txtPassword.KeyPress += txtDescription_KeyPress;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(513, 64);
            panel2.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(174, 12);
            label5.Name = "label5";
            label5.Size = new Size(115, 43);
            label5.TabIndex = 0;
            label5.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 140);
            label2.Name = "label2";
            label2.Size = new Size(103, 24);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // LoginUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(customPanel3);
            Controls.Add(customPanel2);
            Name = "LoginUser";
            Size = new Size(554, 346);
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
        private Button btnLogin;
        private RoundedBorders.CustomPanel customPanel2;
        private Label label1;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Panel panel2;
        private Label label5;
        private Label label2;
    }
}
