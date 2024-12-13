namespace WinFormsApp
{
    partial class ProductUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUser));
            btnuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            btnOpen = new Button();
            btnStock = new Button();
            customPanel3 = new RoundedBorders.CustomPanel();
            label5 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            cmbCategory = new ComboBox();
            label6 = new Label();
            cmbUnitMeasurement = new ComboBox();
            label7 = new Label();
            txtUnitCost = new TextBox();
            label8 = new Label();
            txtCode = new TextBox();
            customPanel2 = new RoundedBorders.CustomPanel();
            panel2 = new Panel();
            customPanel3.SuspendLayout();
            customPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnuevo
            // 
            btnuevo.BackColor = Color.Transparent;
            btnuevo.BackgroundImage = (Image)resources.GetObject("btnuevo.BackgroundImage");
            btnuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnuevo.FlatStyle = FlatStyle.Flat;
            btnuevo.Location = new Point(261, 10);
            btnuevo.Name = "btnuevo";
            btnuevo.Size = new Size(57, 67);
            btnuevo.TabIndex = 16;
            btnuevo.UseVisualStyleBackColor = false;
            btnuevo.Click += Btnuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(324, 10);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(57, 67);
            btnGuardar.TabIndex = 15;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(387, 10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(57, 67);
            btnEliminar.TabIndex = 14;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(451, 10);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 67);
            btnSalir.TabIndex = 13;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Transparent;
            btnOpen.BackgroundImage = (Image)resources.GetObject("btnOpen.BackgroundImage");
            btnOpen.BackgroundImageLayout = ImageLayout.Stretch;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Location = new Point(199, 10);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(57, 67);
            btnOpen.TabIndex = 26;
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.Transparent;
            btnStock.BackgroundImage = (Image)resources.GetObject("btnStock.BackgroundImage");
            btnStock.BackgroundImageLayout = ImageLayout.Stretch;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Location = new Point(137, 10);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(57, 67);
            btnStock.TabIndex = 27;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // customPanel3
            // 
            customPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(btnStock);
            customPanel3.Controls.Add(btnOpen);
            customPanel3.Controls.Add(btnSalir);
            customPanel3.Controls.Add(btnEliminar);
            customPanel3.Controls.Add(btnGuardar);
            customPanel3.Controls.Add(btnuevo);
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel3.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel3.Location = new Point(14, 587);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(491, 87);
            customPanel3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(87, 11);
            label5.Name = "label5";
            label5.Size = new Size(401, 43);
            label5.TabIndex = 0;
            label5.Text = "Registro de Productos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 132);
            label1.Name = "label1";
            label1.Size = new Size(84, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(172, 127);
            txtName.Name = "txtName";
            txtName.Size = new Size(293, 31);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 350);
            label2.Name = "label2";
            label2.Size = new Size(122, 24);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(172, 344);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Both;
            txtDescription.Size = new Size(293, 174);
            txtDescription.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(91, 219);
            label3.Name = "label3";
            label3.Size = new Size(70, 24);
            label3.TabIndex = 8;
            label3.Text = "Precio";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrice.Location = new Point(172, 214);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(293, 31);
            txtPrice.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(58, 305);
            label4.Name = "label4";
            label4.Size = new Size(101, 24);
            label4.TabIndex = 10;
            label4.Text = "Categoria";
            // 
            // cmbCategory
            // 
            cmbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(172, 300);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(293, 33);
            cmbCategory.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(5, 264);
            label6.Name = "label6";
            label6.Size = new Size(150, 24);
            label6.TabIndex = 17;
            label6.Text = "Unidad Medida";
            // 
            // cmbUnitMeasurement
            // 
            cmbUnitMeasurement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbUnitMeasurement.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnitMeasurement.FormattingEnabled = true;
            cmbUnitMeasurement.Location = new Point(172, 257);
            cmbUnitMeasurement.Name = "cmbUnitMeasurement";
            cmbUnitMeasurement.Size = new Size(293, 33);
            cmbUnitMeasurement.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 10F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(97, 174);
            label7.Name = "label7";
            label7.Size = new Size(66, 24);
            label7.TabIndex = 19;
            label7.Text = "Costo";
            // 
            // txtUnitCost
            // 
            txtUnitCost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitCost.Location = new Point(172, 170);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.Size = new Size(293, 31);
            txtUnitCost.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 10F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(82, 89);
            label8.Name = "label8";
            label8.Size = new Size(77, 24);
            label8.TabIndex = 21;
            label8.Text = "Codigo";
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCode.Location = new Point(172, 84);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(293, 31);
            txtCode.TabIndex = 22;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(panel2);
            customPanel2.Controls.Add(txtCode);
            customPanel2.Controls.Add(label8);
            customPanel2.Controls.Add(txtUnitCost);
            customPanel2.Controls.Add(label7);
            customPanel2.Controls.Add(cmbUnitMeasurement);
            customPanel2.Controls.Add(label6);
            customPanel2.Controls.Add(cmbCategory);
            customPanel2.Controls.Add(label4);
            customPanel2.Controls.Add(txtPrice);
            customPanel2.Controls.Add(label3);
            customPanel2.Controls.Add(txtDescription);
            customPanel2.Controls.Add(label2);
            customPanel2.Controls.Add(txtName);
            customPanel2.Controls.Add(label1);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(14, 28);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(491, 546);
            customPanel2.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(491, 64);
            panel2.TabIndex = 23;
            // 
            // ProductUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(customPanel3);
            Controls.Add(customPanel2);
            Name = "ProductUser";
            Size = new Size(526, 717);
            Load += ProductUser_Load;
            customPanel3.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnSalir;
        private Button btnOpen;
        private Button btnStock;
        private RoundedBorders.CustomPanel customPanel3;
        private Label label5;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private ComboBox cmbCategory;
        private Label label6;
        private ComboBox cmbUnitMeasurement;
        private Label label7;
        private TextBox txtUnitCost;
        private Label label8;
        private TextBox txtCode;
        private RoundedBorders.CustomPanel customPanel2;
        private Panel panel2;
    }
}
