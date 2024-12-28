namespace WinFormsApp
{
    partial class WarehouseUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseUser));
            customPanel3 = new RoundedBorders.CustomPanel();
            btnSalir = new Button();
            btnGuardar = new Button();
            btnuevo = new Button();
            label5 = new Label();
            customPanel2 = new RoundedBorders.CustomPanel();
            panel2 = new Panel();
            chkLimit = new CheckBox();
            txtCode = new TextBox();
            label8 = new Label();
            txtMin = new TextBox();
            label7 = new Label();
            txtMax = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
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
            customPanel3.Location = new Point(19, 480);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(491, 83);
            customPanel3.TabIndex = 10;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(409, 10);
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
            btnGuardar.Location = new Point(344, 10);
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
            btnuevo.Location = new Point(282, 10);
            btnuevo.Name = "btnuevo";
            btnuevo.Size = new Size(57, 67);
            btnuevo.TabIndex = 16;
            btnuevo.UseVisualStyleBackColor = false;
            btnuevo.Click += Btnuevo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(81, 12);
            label5.Name = "label5";
            label5.Size = new Size(358, 43);
            label5.TabIndex = 0;
            label5.Text = "Registro de Bodega";
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(panel2);
            customPanel2.Controls.Add(chkLimit);
            customPanel2.Controls.Add(txtCode);
            customPanel2.Controls.Add(label8);
            customPanel2.Controls.Add(txtMin);
            customPanel2.Controls.Add(label7);
            customPanel2.Controls.Add(txtMax);
            customPanel2.Controls.Add(label3);
            customPanel2.Controls.Add(txtDescription);
            customPanel2.Controls.Add(label2);
            customPanel2.Controls.Add(txtName);
            customPanel2.Controls.Add(label1);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(19, 32);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(491, 438);
            customPanel2.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(491, 63);
            panel2.TabIndex = 24;
            // 
            // chkLimit
            // 
            chkLimit.AutoSize = true;
            chkLimit.BackColor = Color.Transparent;
            chkLimit.CheckAlign = ContentAlignment.MiddleRight;
            chkLimit.Font = new Font("Arial", 10F, FontStyle.Bold);
            chkLimit.ForeColor = Color.White;
            chkLimit.Location = new Point(49, 187);
            chkLimit.Name = "chkLimit";
            chkLimit.Size = new Size(117, 28);
            chkLimit.TabIndex = 23;
            chkLimit.Text = "Limitado";
            chkLimit.UseVisualStyleBackColor = false;
            chkLimit.CheckedChanged += chkLimit_CheckedChanged;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(171, 97);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(295, 31);
            txtCode.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 10F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(86, 98);
            label8.Name = "label8";
            label8.Size = new Size(77, 24);
            label8.TabIndex = 21;
            label8.Text = "Codigo";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(256, 183);
            txtMin.Name = "txtMin";
            txtMin.ReadOnly = true;
            txtMin.Size = new Size(53, 31);
            txtMin.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 10F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(171, 190);
            label7.Name = "label7";
            label7.Size = new Size(78, 24);
            label7.TabIndex = 19;
            label7.Text = "Minimo";
            // 
            // txtMax
            // 
            txtMax.Location = new Point(414, 183);
            txtMax.Name = "txtMax";
            txtMax.ReadOnly = true;
            txtMax.Size = new Size(53, 31);
            txtMax.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(323, 187);
            label3.Name = "label3";
            label3.Size = new Size(83, 24);
            label3.TabIndex = 8;
            label3.Text = "Maximo";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(171, 227);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Both;
            txtDescription.Size = new Size(295, 182);
            txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 232);
            label2.Name = "label2";
            label2.Size = new Size(122, 24);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // txtName
            // 
            txtName.Location = new Point(171, 140);
            txtName.Name = "txtName";
            txtName.Size = new Size(295, 31);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(81, 145);
            label1.Name = "label1";
            label1.Size = new Size(84, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // WarehouseUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(customPanel3);
            Controls.Add(customPanel2);
            Name = "WarehouseUser";
            Size = new Size(531, 585);
            Load += WarehouseUser_Load;
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
        private Label label5;
        private RoundedBorders.CustomPanel customPanel2;
        private TextBox txtCode;
        private Label label8;
        private TextBox txtMin;
        private Label label7;
        private TextBox txtMax;
        private Label label3;
        private TextBox txtDescription;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private CheckBox chkLimit;
        private Panel panel2;
    }
}
