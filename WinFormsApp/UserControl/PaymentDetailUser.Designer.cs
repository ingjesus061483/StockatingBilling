namespace WinFormsApp
{
    partial class PaymentDetailUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentDetailUser));
            customPanel5 = new RoundedBorders.CustomPanel();
            btnuevo = new Button();
            customPanel1 = new RoundedBorders.CustomPanel();
            comboBox1 = new ComboBox();
            textBox8 = new TextBox();
            label3 = new Label();
            textBox9 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label14 = new Label();
            btnSalir = new Button();
            customPanel5.SuspendLayout();
            customPanel1.SuspendLayout();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel5
            // 
            customPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel5.BackColor = Color.White;
            customPanel5.BorderRadius = 30;
            customPanel5.Controls.Add(btnSalir);
            customPanel5.Controls.Add(btnuevo);
            customPanel5.ForeColor = Color.Black;
            customPanel5.GradientAngle = 90F;
            customPanel5.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel5.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel5.Location = new Point(18, 213);
            customPanel5.Name = "customPanel5";
            customPanel5.Size = new Size(532, 81);
            customPanel5.TabIndex = 9;
            // 
            // btnuevo
            // 
            btnuevo.BackColor = Color.Transparent;
            btnuevo.BackgroundImage = (Image)resources.GetObject("btnuevo.BackgroundImage");
            btnuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnuevo.FlatStyle = FlatStyle.Flat;
            btnuevo.Location = new Point(387, 5);
            btnuevo.Name = "btnuevo";
            btnuevo.Size = new Size(57, 67);
            btnuevo.TabIndex = 18;
            btnuevo.UseVisualStyleBackColor = false;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(comboBox1);
            customPanel1.Controls.Add(textBox8);
            customPanel1.Controls.Add(label3);
            customPanel1.Controls.Add(textBox9);
            customPanel1.Controls.Add(label4);
            customPanel1.Controls.Add(label5);
            customPanel1.Controls.Add(panel1);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel1.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel1.Location = new Point(15, 17);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(535, 187);
            customPanel1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(199, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(313, 33);
            comboBox1.TabIndex = 24;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox8.Font = new Font("Arial", 10F);
            textBox8.Location = new Point(200, 135);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(311, 30);
            textBox8.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(99, 138);
            label3.Name = "label3";
            label3.Size = new Size(92, 24);
            label3.TabIndex = 20;
            label3.Text = "Recibido";
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox9.Font = new Font("Arial", 10F);
            textBox9.Location = new Point(200, 100);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(311, 30);
            textBox9.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(34, 103);
            label4.Name = "label4";
            label4.Size = new Size(156, 24);
            label4.TabIndex = 18;
            label4.Text = "Detalle de pago";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 66);
            label5.Name = "label5";
            label5.Size = new Size(174, 24);
            label5.TabIndex = 16;
            label5.Text = "Metodos de pago";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 113, 163);
            panel1.Controls.Add(label14);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 48);
            panel1.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(86, 3);
            label14.Name = "label14";
            label14.Size = new Size(304, 43);
            label14.TabIndex = 1;
            label14.Text = "Detalle de pagos";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(452, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 67);
            btnSalir.TabIndex = 22;
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // PaymentDetail
            // 
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            this.Controls.Add(customPanel5);
            this.Controls.Add(customPanel1);
            this.Name = "PaymentDetail";
            this.Size = new Size(569, 311);
            customPanel5.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private RoundedBorders.CustomPanel customPanel5;
        private Button btnuevo;
        private RoundedBorders.CustomPanel customPanel1;
        private ComboBox comboBox1;
        private TextBox textBox8;
        private Label label3;
        private TextBox textBox9;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label label14;
        private Button btnSalir;
    }
}
