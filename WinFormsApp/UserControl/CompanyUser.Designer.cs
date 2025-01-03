﻿namespace WinFormsApp
{
    partial class CompanyUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyUser));
            customPanel3 = new RoundedBorders.CustomPanel();
            btnSalir = new Button();
            btnGuardar = new Button();
            btnuevo = new Button();
            customPanel2 = new RoundedBorders.CustomPanel();
            txtSlogan = new TextBox();
            label10 = new Label();
            txtContact = new TextBox();
            label9 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            txtPhone = new TextBox();
            txtNit = new TextBox();
            label8 = new Label();
            txtTradeCamera = new TextBox();
            label7 = new Label();
            label6 = new Label();
            cmbRegimeType = new ComboBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
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
            customPanel3.Controls.Add(btnGuardar);
            customPanel3.Controls.Add(btnuevo);
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel3.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel3.Location = new Point(19, 598);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(489, 87);
            customPanel3.TabIndex = 14;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(417, 10);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 67);
            btnSalir.TabIndex = 13;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(348, 10);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(57, 67);
            btnGuardar.TabIndex = 15;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnuevo
            // 
            btnuevo.BackColor = Color.Transparent;
            btnuevo.BackgroundImage = (Image)resources.GetObject("btnuevo.BackgroundImage");
            btnuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnuevo.FlatStyle = FlatStyle.Flat;
            btnuevo.Location = new Point(285, 10);
            btnuevo.Name = "btnuevo";
            btnuevo.Size = new Size(57, 67);
            btnuevo.TabIndex = 16;
            btnuevo.UseVisualStyleBackColor = false;
            btnuevo.Click += btnuevo_Click;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(txtSlogan);
            customPanel2.Controls.Add(label10);
            customPanel2.Controls.Add(txtContact);
            customPanel2.Controls.Add(label9);
            customPanel2.Controls.Add(panel2);
            customPanel2.Controls.Add(txtPhone);
            customPanel2.Controls.Add(txtNit);
            customPanel2.Controls.Add(label8);
            customPanel2.Controls.Add(txtTradeCamera);
            customPanel2.Controls.Add(label7);
            customPanel2.Controls.Add(label6);
            customPanel2.Controls.Add(cmbRegimeType);
            customPanel2.Controls.Add(label4);
            customPanel2.Controls.Add(txtAddress);
            customPanel2.Controls.Add(label3);
            customPanel2.Controls.Add(txtEmail);
            customPanel2.Controls.Add(label2);
            customPanel2.Controls.Add(txtName);
            customPanel2.Controls.Add(label1);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(19, 32);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(489, 553);
            customPanel2.TabIndex = 13;
            // 
            // txtSlogan
            // 
            txtSlogan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSlogan.Location = new Point(246, 433);
            txtSlogan.Multiline = true;
            txtSlogan.Name = "txtSlogan";
            txtSlogan.ScrollBars = ScrollBars.Vertical;
            txtSlogan.Size = new Size(213, 97);
            txtSlogan.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 10F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(154, 438);
            label10.Name = "label10";
            label10.Size = new Size(75, 24);
            label10.TabIndex = 27;
            label10.Text = "Slogan";
            // 
            // txtContact
            // 
            txtContact.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContact.Location = new Point(246, 390);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(213, 31);
            txtContact.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 10F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(133, 395);
            label9.Name = "label9";
            label9.Size = new Size(96, 24);
            label9.TabIndex = 25;
            label9.Text = "Contacto";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(489, 63);
            panel2.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(46, 8);
            label5.Name = "label5";
            label5.Size = new Size(374, 43);
            label5.TabIndex = 0;
            label5.Text = "Registro de empresa";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(246, 303);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(213, 31);
            txtPhone.TabIndex = 23;
            // 
            // txtNit
            // 
            txtNit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNit.Location = new Point(246, 128);
            txtNit.Name = "txtNit";
            txtNit.Size = new Size(213, 31);
            txtNit.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 10F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(196, 133);
            label8.Name = "label8";
            label8.Size = new Size(36, 24);
            label8.TabIndex = 21;
            label8.Text = "Nit";
            // 
            // txtTradeCamera
            // 
            txtTradeCamera.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTradeCamera.Location = new Point(246, 215);
            txtTradeCamera.Name = "txtTradeCamera";
            txtTradeCamera.Size = new Size(213, 31);
            txtTradeCamera.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 10F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(23, 220);
            label7.Name = "label7";
            label7.Size = new Size(204, 24);
            label7.TabIndex = 19;
            label7.Text = "Camara de comercio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(137, 310);
            label6.Name = "label6";
            label6.Size = new Size(92, 24);
            label6.TabIndex = 17;
            label6.Text = "Telefono";
            // 
            // cmbRegimeType
            // 
            cmbRegimeType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbRegimeType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRegimeType.FormattingEnabled = true;
            cmbRegimeType.Location = new Point(246, 83);
            cmbRegimeType.Name = "cmbRegimeType";
            cmbRegimeType.Size = new Size(213, 33);
            cmbRegimeType.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(93, 88);
            label4.Name = "label4";
            label4.Size = new Size(134, 24);
            label4.TabIndex = 10;
            label4.Text = "Tipo regimen";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(246, 260);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(213, 31);
            txtAddress.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(129, 265);
            label3.Name = "label3";
            label3.Size = new Size(99, 24);
            label3.TabIndex = 8;
            label3.Text = "Direccion";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(246, 347);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 31);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(170, 352);
            label2.Name = "label2";
            label2.Size = new Size(61, 24);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(246, 172);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 31);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(146, 177);
            label1.Name = "label1";
            label1.Size = new Size(84, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // CompanyUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(customPanel3);
            Controls.Add(customPanel2);
            Name = "CompanyUser";
            Size = new Size(524, 717);
            Load += CompanyUser_Load;
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
        private Button btnGuardar;
        private Button btnuevo;
        private RoundedBorders.CustomPanel customPanel2;
        private TextBox txtSlogan;
        private Label label10;
        private TextBox txtContact;
        private Label label9;
        private Panel panel2;
        private Label label5;
        private TextBox txtPhone;
        private TextBox txtNit;
        private Label label8;
        private TextBox txtTradeCamera;
        private Label label7;
        private Label label6;
        private ComboBox cmbRegimeType;
        private Label label4;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtName;
        private Label label1;
    }
}
