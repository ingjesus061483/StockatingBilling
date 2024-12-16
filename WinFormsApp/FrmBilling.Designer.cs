namespace WinFormsApp
{
    partial class FrmBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilling));
            customPanel1 = new RoundedBorders.CustomPanel();
            customPanel3 = new RoundedBorders.CustomPanel();
            customPanel4 = new RoundedBorders.CustomPanel();
            panel1 = new Panel();
            customPanel2 = new RoundedBorders.CustomPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtAmount = new TextBox();
            label3 = new Label();
            btnWarehouse = new Button();
            txtWarehouse = new TextBox();
            btnProduct = new Button();
            txtProduc = new TextBox();
            txtStock = new TextBox();
            label4 = new Label();
            customPanel5 = new RoundedBorders.CustomPanel();
            btnGuardar = new Button();
            btnuevo = new Button();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            cmbIdentificationType = new ComboBox();
            customPanel6 = new RoundedBorders.CustomPanel();
            button1 = new Button();
            button2 = new Button();
            txtUnitPrice = new TextBox();
            comboBox1 = new ComboBox();
            label12 = new Label();
            txtcode = new TextBox();
            label13 = new Label();
            btnClient = new Button();
            txtClient = new TextBox();
            btnEmployee = new Button();
            txtEmployee = new TextBox();
            comboBox2 = new ComboBox();
            label14 = new Label();
            customPanel7 = new RoundedBorders.CustomPanel();
            textBox12 = new TextBox();
            panel4 = new Panel();
            label15 = new Label();
            dtpDate = new DateTimePicker();
            label16 = new Label();
            customPanel1.SuspendLayout();
            customPanel3.SuspendLayout();
            customPanel4.SuspendLayout();
            panel1.SuspendLayout();
            customPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            customPanel5.SuspendLayout();
            customPanel6.SuspendLayout();
            customPanel7.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(dtpDate);
            customPanel1.Controls.Add(label16);
            customPanel1.Controls.Add(comboBox2);
            customPanel1.Controls.Add(label14);
            customPanel1.Controls.Add(btnEmployee);
            customPanel1.Controls.Add(txtEmployee);
            customPanel1.Controls.Add(btnClient);
            customPanel1.Controls.Add(txtClient);
            customPanel1.Controls.Add(comboBox1);
            customPanel1.Controls.Add(label12);
            customPanel1.Controls.Add(txtcode);
            customPanel1.Controls.Add(label13);
            customPanel1.Controls.Add(panel1);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel1.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel1.Location = new Point(16, 22);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(563, 309);
            customPanel1.TabIndex = 0;
            // 
            // customPanel3
            // 
            customPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(dataGridView1);
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel3.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel3.Location = new Point(16, 631);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(563, 134);
            customPanel3.TabIndex = 2;
            // 
            // customPanel4
            // 
            customPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel4.BackColor = Color.White;
            customPanel4.BorderRadius = 30;
            customPanel4.Controls.Add(cmbIdentificationType);
            customPanel4.Controls.Add(textBox7);
            customPanel4.Controls.Add(label11);
            customPanel4.Controls.Add(textBox6);
            customPanel4.Controls.Add(label10);
            customPanel4.Controls.Add(textBox5);
            customPanel4.Controls.Add(label9);
            customPanel4.Controls.Add(textBox4);
            customPanel4.Controls.Add(label8);
            customPanel4.Controls.Add(textBox3);
            customPanel4.Controls.Add(label7);
            customPanel4.Controls.Add(textBox2);
            customPanel4.Controls.Add(label6);
            customPanel4.Controls.Add(panel3);
            customPanel4.ForeColor = Color.Black;
            customPanel4.GradientAngle = 90F;
            customPanel4.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel4.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel4.Location = new Point(280, 774);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(299, 292);
            customPanel4.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 113, 163);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(563, 48);
            panel1.TabIndex = 0;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(txtUnitPrice);
            customPanel2.Controls.Add(txtStock);
            customPanel2.Controls.Add(label4);
            customPanel2.Controls.Add(txtAmount);
            customPanel2.Controls.Add(label3);
            customPanel2.Controls.Add(btnWarehouse);
            customPanel2.Controls.Add(txtWarehouse);
            customPanel2.Controls.Add(btnProduct);
            customPanel2.Controls.Add(txtProduc);
            customPanel2.Controls.Add(panel2);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(16, 344);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(563, 187);
            customPanel2.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(563, 48);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(36, 113, 163);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(299, 48);
            panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(42, 46, 50);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(563, 134);
            dataGridView1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(144, 3);
            label5.Name = "label5";
            label5.Size = new Size(230, 43);
            label5.TabIndex = 1;
            label5.Text = "Encabezado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(182, 3);
            label1.Name = "label1";
            label1.Size = new Size(155, 43);
            label1.TabIndex = 1;
            label1.Text = "Detalles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(86, 3);
            label2.Name = "label2";
            label2.Size = new Size(142, 43);
            label2.TabIndex = 1;
            label2.Text = "Totales";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Arial", 10F);
            txtAmount.Location = new Point(124, 137);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(113, 30);
            txtAmount.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 140);
            label3.Name = "label3";
            label3.Size = new Size(94, 24);
            label3.TabIndex = 10;
            label3.Text = "Cantidad";
            // 
            // btnWarehouse
            // 
            btnWarehouse.BackColor = Color.Transparent;
            btnWarehouse.BackgroundImage = (Image)resources.GetObject("btnWarehouse.BackgroundImage");
            btnWarehouse.BackgroundImageLayout = ImageLayout.Stretch;
            btnWarehouse.FlatStyle = FlatStyle.Flat;
            btnWarehouse.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnWarehouse.Location = new Point(17, 101);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(43, 31);
            btnWarehouse.TabIndex = 9;
            btnWarehouse.UseVisualStyleBackColor = false;
            // 
            // txtWarehouse
            // 
            txtWarehouse.Font = new Font("Arial", 10F);
            txtWarehouse.Location = new Point(63, 102);
            txtWarehouse.Name = "txtWarehouse";
            txtWarehouse.ReadOnly = true;
            txtWarehouse.Size = new Size(477, 30);
            txtWarehouse.TabIndex = 8;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Transparent;
            btnProduct.BackgroundImage = (Image)resources.GetObject("btnProduct.BackgroundImage");
            btnProduct.BackgroundImageLayout = ImageLayout.Stretch;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnProduct.Location = new Point(17, 67);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(43, 31);
            btnProduct.TabIndex = 7;
            btnProduct.UseVisualStyleBackColor = false;
            // 
            // txtProduc
            // 
            txtProduc.Font = new Font("Arial", 10F);
            txtProduc.Location = new Point(65, 67);
            txtProduc.Name = "txtProduc";
            txtProduc.ReadOnly = true;
            txtProduc.Size = new Size(228, 30);
            txtProduc.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Arial", 10F);
            txtStock.Location = new Point(374, 136);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(166, 30);
            txtStock.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(259, 139);
            label4.Name = "label4";
            label4.Size = new Size(107, 24);
            label4.TabIndex = 12;
            label4.Text = "Existencia";
            // 
            // customPanel5
            // 
            customPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel5.BackColor = Color.White;
            customPanel5.BorderRadius = 30;
            customPanel5.Controls.Add(btnGuardar);
            customPanel5.Controls.Add(btnuevo);
            customPanel5.ForeColor = Color.Black;
            customPanel5.GradientAngle = 90F;
            customPanel5.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel5.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel5.Location = new Point(16, 541);
            customPanel5.Name = "customPanel5";
            customPanel5.Size = new Size(563, 81);
            customPanel5.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(446, 7);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(57, 67);
            btnGuardar.TabIndex = 17;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnuevo
            // 
            btnuevo.BackColor = Color.Transparent;
            btnuevo.BackgroundImage = (Image)resources.GetObject("btnuevo.BackgroundImage");
            btnuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnuevo.FlatStyle = FlatStyle.Flat;
            btnuevo.Location = new Point(383, 7);
            btnuevo.Name = "btnuevo";
            btnuevo.Size = new Size(57, 67);
            btnuevo.TabIndex = 18;
            btnuevo.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 10F);
            textBox2.Location = new Point(145, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 30);
            textBox2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(48, 63);
            label6.Name = "label6";
            label6.Size = new Size(89, 24);
            label6.TabIndex = 12;
            label6.Text = "Subtotal";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 10F);
            textBox3.Location = new Point(145, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 30);
            textBox3.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 10F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(29, 99);
            label7.Name = "label7";
            label7.Size = new Size(108, 24);
            label7.TabIndex = 14;
            label7.Text = "Impuestos";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 10F);
            textBox4.Location = new Point(204, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(71, 30);
            textBox4.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 10F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(26, 134);
            label8.Name = "label8";
            label8.Size = new Size(111, 24);
            label8.TabIndex = 16;
            label8.Text = "Descuento";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial", 10F);
            textBox5.Location = new Point(145, 166);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(130, 30);
            textBox5.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 10F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 169);
            label9.Name = "label9";
            label9.Size = new Size(134, 24);
            label9.TabIndex = 18;
            label9.Text = "Total a pagar";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial", 10F);
            textBox6.Location = new Point(145, 201);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(130, 30);
            textBox6.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 10F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(44, 204);
            label10.Name = "label10";
            label10.Size = new Size(92, 24);
            label10.TabIndex = 20;
            label10.Text = "Recibido";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Arial", 10F);
            textBox7.Location = new Point(145, 236);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(130, 30);
            textBox7.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial", 10F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(55, 239);
            label11.Name = "label11";
            label11.Size = new Size(81, 24);
            label11.TabIndex = 22;
            label11.Text = "Cambio";
            // 
            // cmbIdentificationType
            // 
            cmbIdentificationType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbIdentificationType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdentificationType.FormattingEnabled = true;
            cmbIdentificationType.Location = new Point(143, 130);
            cmbIdentificationType.Name = "cmbIdentificationType";
            cmbIdentificationType.Size = new Size(58, 33);
            cmbIdentificationType.TabIndex = 24;
            // 
            // customPanel6
            // 
            customPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel6.BackColor = Color.White;
            customPanel6.BorderRadius = 30;
            customPanel6.Controls.Add(button1);
            customPanel6.Controls.Add(button2);
            customPanel6.ForeColor = Color.Black;
            customPanel6.GradientAngle = 90F;
            customPanel6.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel6.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel6.Location = new Point(16, 1077);
            customPanel6.Name = "customPanel6";
            customPanel6.Size = new Size(563, 81);
            customPanel6.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(446, 7);
            button1.Name = "button1";
            button1.Size = new Size(57, 67);
            button1.TabIndex = 17;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(383, 7);
            button2.Name = "button2";
            button2.Size = new Size(57, 67);
            button2.TabIndex = 18;
            button2.UseVisualStyleBackColor = false;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Arial", 10F);
            txtUnitPrice.Location = new Point(299, 67);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(241, 30);
            txtUnitPrice.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(182, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(358, 33);
            comboBox1.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Arial", 10F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(22, 175);
            label12.Name = "label12";
            label12.Size = new Size(152, 24);
            label12.TabIndex = 27;
            label12.Text = "Forma de pago";
            // 
            // txtcode
            // 
            txtcode.Font = new Font("Arial", 10F);
            txtcode.Location = new Point(182, 66);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(358, 30);
            txtcode.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Arial", 10F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(96, 69);
            label13.Name = "label13";
            label13.Size = new Size(77, 24);
            label13.TabIndex = 25;
            label13.Text = "Codigo";
            // 
            // btnClient
            // 
            btnClient.BackColor = Color.Transparent;
            btnClient.BackgroundImage = (Image)resources.GetObject("btnClient.BackgroundImage");
            btnClient.BackgroundImageLayout = ImageLayout.Stretch;
            btnClient.FlatStyle = FlatStyle.Flat;
            btnClient.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnClient.Location = new Point(136, 100);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(37, 32);
            btnClient.TabIndex = 30;
            btnClient.UseVisualStyleBackColor = false;
            // 
            // txtClient
            // 
            txtClient.Font = new Font("Arial", 10F);
            txtClient.Location = new Point(182, 101);
            txtClient.Name = "txtClient";
            txtClient.ReadOnly = true;
            txtClient.Size = new Size(358, 30);
            txtClient.TabIndex = 29;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.Transparent;
            btnEmployee.BackgroundImage = (Image)resources.GetObject("btnEmployee.BackgroundImage");
            btnEmployee.BackgroundImageLayout = ImageLayout.Stretch;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnEmployee.Location = new Point(135, 135);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(38, 32);
            btnEmployee.TabIndex = 32;
            btnEmployee.UseVisualStyleBackColor = false;
            // 
            // txtEmployee
            // 
            txtEmployee.Font = new Font("Arial", 10F);
            txtEmployee.Location = new Point(181, 136);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.ReadOnly = true;
            txtEmployee.Size = new Size(358, 30);
            txtEmployee.TabIndex = 31;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(183, 209);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(357, 33);
            comboBox2.TabIndex = 34;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial", 10F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(57, 213);
            label14.Name = "label14";
            label14.Size = new Size(118, 24);
            label14.TabIndex = 33;
            label14.Text = "Documento";
            // 
            // customPanel7
            // 
            customPanel7.BackColor = Color.White;
            customPanel7.BorderRadius = 30;
            customPanel7.Controls.Add(textBox12);
            customPanel7.Controls.Add(panel4);
            customPanel7.ForeColor = Color.Black;
            customPanel7.GradientAngle = 90F;
            customPanel7.GradientBottomColor = Color.CadetBlue;
            customPanel7.GradientTopColor = Color.DodgerBlue;
            customPanel7.Location = new Point(16, 774);
            customPanel7.Name = "customPanel7";
            customPanel7.Size = new Size(254, 292);
            customPanel7.TabIndex = 7;
            // 
            // textBox12
            // 
            textBox12.Dock = DockStyle.Fill;
            textBox12.Location = new Point(0, 48);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.ScrollBars = ScrollBars.Both;
            textBox12.Size = new Size(254, 244);
            textBox12.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(36, 113, 163);
            panel4.Controls.Add(label15);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(254, 48);
            panel4.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(2, 3);
            label15.Name = "label15";
            label15.Size = new Size(252, 43);
            label15.TabIndex = 1;
            label15.Text = "Observciones";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "yyyy-MM-dd";
            dtpDate.Font = new Font("Arial", 10F);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(183, 246);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(357, 30);
            dtpDate.TabIndex = 36;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Arial", 10F, FontStyle.Bold);
            label16.ForeColor = Color.White;
            label16.Location = new Point(107, 250);
            label16.Name = "label16";
            label16.Size = new Size(67, 24);
            label16.TabIndex = 35;
            label16.Text = "Fecha";
            // 
            // FrmBilling
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(620, 1050);
            Controls.Add(customPanel7);
            Controls.Add(customPanel6);
            Controls.Add(customPanel5);
            Controls.Add(customPanel2);
            Controls.Add(customPanel4);
            Controls.Add(customPanel3);
            Controls.Add(customPanel1);
            Name = "FrmBilling";
            Text = "FrmBilling";
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            customPanel3.ResumeLayout(false);
            customPanel4.ResumeLayout(false);
            customPanel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            customPanel5.ResumeLayout(false);
            customPanel6.ResumeLayout(false);
            customPanel7.ResumeLayout(false);
            customPanel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedBorders.CustomPanel customPanel1;
        private RoundedBorders.CustomPanel customPanel3;
        private RoundedBorders.CustomPanel customPanel4;
        private Panel panel1;
        private Panel panel3;
        private RoundedBorders.CustomPanel customPanel2;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtAmount;
        private Label label3;
        private Button btnWarehouse;
        private TextBox txtWarehouse;
        private Button btnProduct;
        private TextBox txtProduc;
        private RoundedBorders.CustomPanel customPanel5;
        private Button btnGuardar;
        private Button btnuevo;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox5;
        private Label label9;
        private ComboBox cmbIdentificationType;
        private RoundedBorders.CustomPanel customPanel6;
        private Button button1;
        private Button button2;
        private TextBox txtUnitPrice;
        private Button btnClient;
        private TextBox txtClient;
        private ComboBox comboBox1;
        private Label label12;
        private TextBox txtcode;
        private Label label13;
        private Button btnEmployee;
        private TextBox txtEmployee;
        private ComboBox comboBox2;
        private Label label14;
        private RoundedBorders.CustomPanel customPanel7;
        private Panel panel4;
        private Label label15;
        private TextBox textBox12;
        private DateTimePicker dtpDate;
        private Label label16;
    }
}