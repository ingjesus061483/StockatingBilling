namespace WinFormsApp
{
    partial class ClientUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientUser));
            customPanel3 = new RoundedBorders.CustomPanel();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnuevo = new Button();
            label5 = new Label();
            customPanel2 = new RoundedBorders.CustomPanel();
            txtPhone = new TextBox();
            txtIdentification = new TextBox();
            label8 = new Label();
            txtLastName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            cmbIdentificationType = new ComboBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
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
            customPanel3.Controls.Add(btnEliminar);
            customPanel3.Controls.Add(btnGuardar);
            customPanel3.Controls.Add(btnuevo);
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel3.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel3.Location = new Point(17, 452);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(491, 87);
            customPanel3.TabIndex = 10;
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
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(353, 10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(57, 67);
            btnEliminar.TabIndex = 14;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(290, 10);
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
            btnuevo.Location = new Point(227, 10);
            btnuevo.Name = "btnuevo";
            btnuevo.Size = new Size(57, 67);
            btnuevo.TabIndex = 16;
            btnuevo.UseVisualStyleBackColor = false;
            btnuevo.Click += btnuevo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(93, 9);
            label5.Name = "label5";
            label5.Size = new Size(355, 43);
            label5.TabIndex = 0;
            label5.Text = "Registro de clientes";
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(panel2);
            customPanel2.Controls.Add(txtPhone);
            customPanel2.Controls.Add(txtIdentification);
            customPanel2.Controls.Add(label8);
            customPanel2.Controls.Add(txtLastName);
            customPanel2.Controls.Add(label7);
            customPanel2.Controls.Add(label6);
            customPanel2.Controls.Add(cmbIdentificationType);
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
            customPanel2.Location = new Point(17, 28);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(491, 406);
            customPanel2.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(246, 301);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(223, 31);
            txtPhone.TabIndex = 23;
            // 
            // txtIdentification
            // 
            txtIdentification.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdentification.Location = new Point(246, 128);
            txtIdentification.Name = "txtIdentification";
            txtIdentification.Size = new Size(223, 31);
            txtIdentification.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 10F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(93, 133);
            label8.Name = "label8";
            label8.Size = new Size(136, 24);
            label8.TabIndex = 21;
            label8.Text = "Identificacion";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(246, 214);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(223, 31);
            txtLastName.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 10F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(149, 218);
            label7.Name = "label7";
            label7.Size = new Size(85, 24);
            label7.TabIndex = 19;
            label7.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(141, 306);
            label6.Name = "label6";
            label6.Size = new Size(92, 24);
            label6.TabIndex = 17;
            label6.Text = "Telefono";
            // 
            // cmbIdentificationType
            // 
            cmbIdentificationType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbIdentificationType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdentificationType.FormattingEnabled = true;
            cmbIdentificationType.Location = new Point(246, 84);
            cmbIdentificationType.Name = "cmbIdentificationType";
            cmbIdentificationType.Size = new Size(223, 33);
            cmbIdentificationType.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 89);
            label4.Name = "label4";
            label4.Size = new Size(208, 24);
            label4.TabIndex = 10;
            label4.Text = "Tipo de identifcacion";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.Location = new Point(246, 258);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(223, 31);
            txtAddress.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(134, 263);
            label3.Name = "label3";
            label3.Size = new Size(99, 24);
            label3.TabIndex = 8;
            label3.Text = "Direccion";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(246, 344);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 31);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(177, 349);
            label2.Name = "label2";
            label2.Size = new Size(61, 24);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(246, 171);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 31);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(150, 176);
            label1.Name = "label1";
            label1.Size = new Size(84, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(491, 64);
            panel2.TabIndex = 24;
            // 
            // ClientUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(customPanel3);
            Controls.Add(customPanel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ClientUser";
            Size = new Size(526, 568);
            Load += ClientUser_Load;
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
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnuevo;
        private Label label5;
        private RoundedBorders.CustomPanel customPanel2;
        private TextBox txtIdentification;
        private Label label8;
        private TextBox txtLastName;
        private Label label7;
        private Label label6;
        private ComboBox cmbIdentificationType;
        private Label label4;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private TextBox txtPhone;
        private Panel panel2;
    }
}
