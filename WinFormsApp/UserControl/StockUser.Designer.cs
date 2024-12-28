namespace WinFormsApp
{
    partial class StockUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockUser));
            customPanel4 = new RoundedBorders.CustomPanel();
            btnSalir = new Button();
            btnSave = new Button();
            btnuevo = new Button();
            customPanel2 = new RoundedBorders.CustomPanel();
            label4 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            txtAmount = new TextBox();
            label1 = new Label();
            btnWarehouse = new Button();
            txtWarehouse = new TextBox();
            txtProduc = new TextBox();
            customPanel4.SuspendLayout();
            customPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel4
            // 
            customPanel4.BackColor = Color.White;
            customPanel4.BorderRadius = 30;
            customPanel4.Controls.Add(btnSalir);
            customPanel4.Controls.Add(btnSave);
            customPanel4.Controls.Add(btnuevo);
            customPanel4.ForeColor = Color.Black;
            customPanel4.GradientAngle = 90F;
            customPanel4.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel4.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel4.Location = new Point(21, 309);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(531, 80);
            customPanel4.TabIndex = 17;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(459, 8);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 67);
            btnSalir.TabIndex = 13;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(396, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(57, 67);
            btnSave.TabIndex = 15;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnuevo
            // 
            btnuevo.BackColor = Color.Transparent;
            btnuevo.BackgroundImage = (Image)resources.GetObject("btnuevo.BackgroundImage");
            btnuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnuevo.FlatStyle = FlatStyle.Flat;
            btnuevo.Location = new Point(333, 8);
            btnuevo.Name = "btnuevo";
            btnuevo.Size = new Size(57, 67);
            btnuevo.TabIndex = 16;
            btnuevo.UseVisualStyleBackColor = false;
            btnuevo.Click += btnuevo_Click;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(label4);
            customPanel2.Controls.Add(txtProduc);
            customPanel2.Controls.Add(panel2);
            customPanel2.Controls.Add(dtpDate);
            customPanel2.Controls.Add(label2);
            customPanel2.Controls.Add(txtAmount);
            customPanel2.Controls.Add(label1);
            customPanel2.Controls.Add(btnWarehouse);
            customPanel2.Controls.Add(txtWarehouse);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(19, 24);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(531, 273);
            customPanel2.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(11, 99);
            label4.Name = "label4";
            label4.Size = new Size(97, 24);
            label4.TabIndex = 5;
            label4.Text = "Producto";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 63);
            panel2.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(87, 12);
            label3.Name = "label3";
            label3.Size = new Size(401, 43);
            label3.TabIndex = 0;
            label3.Text = "Registro de Productos";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "yyyy-MM-dd";
            dtpDate.Font = new Font("Arial", 10F);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(116, 203);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(395, 30);
            dtpDate.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 208);
            label2.Name = "label2";
            label2.Size = new Size(67, 24);
            label2.TabIndex = 6;
            label2.Text = "Fecha";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Arial", 10F);
            txtAmount.Location = new Point(115, 167);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(395, 30);
            txtAmount.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 170);
            label1.Name = "label1";
            label1.Size = new Size(94, 24);
            label1.TabIndex = 4;
            label1.Text = "Cantidad";
            // 
            // btnWarehouse
            // 
            btnWarehouse.BackColor = Color.Transparent;
            btnWarehouse.BackgroundImage = (Image)resources.GetObject("btnWarehouse.BackgroundImage");
            btnWarehouse.BackgroundImageLayout = ImageLayout.Stretch;
            btnWarehouse.FlatStyle = FlatStyle.Flat;
            btnWarehouse.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnWarehouse.Location = new Point(74, 129);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(38, 33);
            btnWarehouse.TabIndex = 3;
            btnWarehouse.UseVisualStyleBackColor = false;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // txtWarehouse
            // 
            txtWarehouse.Font = new Font("Arial", 10F);
            txtWarehouse.Location = new Point(115, 131);
            txtWarehouse.Name = "txtWarehouse";
            txtWarehouse.ReadOnly = true;
            txtWarehouse.Size = new Size(395, 30);
            txtWarehouse.TabIndex = 2;
            // 
            // txtProduc
            // 
            txtProduc.Font = new Font("Arial", 10F);
            txtProduc.Location = new Point(114, 95);
            txtProduc.Name = "txtProduc";
            txtProduc.ReadOnly = true;
            txtProduc.Size = new Size(395, 30);
            txtProduc.TabIndex = 0;
            // 
            // StockUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(customPanel4);
            Controls.Add(customPanel2);
            Name = "StockUser";
            Size = new Size(569, 406);
            Load += StockUser_Load;
            customPanel4.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RoundedBorders.CustomPanel customPanel4;
        private Button btnSalir;
        private Button btnSave;
        private Button btnuevo;
        private RoundedBorders.CustomPanel customPanel2;
        private Panel panel2;
        private Label label3;
        private DateTimePicker dtpDate;
        private Label label2;
        private TextBox txtAmount;
        private Label label1;
        private Button btnWarehouse;
        private TextBox txtWarehouse;
        private TextBox txtProduc;
        private Label label4;
    }
}
