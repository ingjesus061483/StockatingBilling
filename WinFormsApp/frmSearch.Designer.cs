namespace WinFormsApp
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            customPanel2 = new RoundedBorders.CustomPanel();
            cmbfields = new ComboBox();
            label6 = new Label();
            txtValue = new TextBox();
            label3 = new Label();
            customPanel3 = new RoundedBorders.CustomPanel();
            dataGridView1 = new DataGridView();
            customPanel4 = new RoundedBorders.CustomPanel();
            btnSalir = new Button();
            panel2 = new Panel();
            label1 = new Label();
            customPanel2.SuspendLayout();
            customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            customPanel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(panel2);
            customPanel2.Controls.Add(cmbfields);
            customPanel2.Controls.Add(label6);
            customPanel2.Controls.Add(txtValue);
            customPanel2.Controls.Add(label3);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(16, 26);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(491, 204);
            customPanel2.TabIndex = 7;
            // 
            // cmbfields
            // 
            cmbfields.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbfields.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbfields.FormattingEnabled = true;
            cmbfields.Location = new Point(119, 99);
            cmbfields.Name = "cmbfields";
            cmbfields.Size = new Size(341, 33);
            cmbfields.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 106);
            label6.Name = "label6";
            label6.Size = new Size(87, 24);
            label6.TabIndex = 17;
            label6.Text = "Campos";
            // 
            // txtValue
            // 
            txtValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValue.Location = new Point(119, 141);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(341, 31);
            txtValue.TabIndex = 9;
            txtValue.TextChanged += txtValue_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 146);
            label3.Name = "label3";
            label3.Size = new Size(58, 24);
            label3.TabIndex = 8;
            label3.Text = "Valor";
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(dataGridView1);
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(224, 224, 224);
            customPanel3.GradientTopColor = Color.FromArgb(224, 224, 224);
            customPanel3.Location = new Point(16, 243);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(491, 230);
            customPanel3.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(42, 46, 50);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(491, 230);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // customPanel4
            // 
            customPanel4.BackColor = Color.White;
            customPanel4.BorderRadius = 30;
            customPanel4.Controls.Add(btnSalir);
            customPanel4.ForeColor = Color.Black;
            customPanel4.GradientAngle = 90F;
            customPanel4.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel4.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel4.Location = new Point(16, 485);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(491, 83);
            customPanel4.TabIndex = 14;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(417, 8);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 67);
            btnSalir.TabIndex = 13;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(491, 64);
            panel2.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(81, 12);
            label1.Name = "label1";
            label1.Size = new Size(358, 43);
            label1.TabIndex = 0;
            label1.Text = "Registro de Bodega";
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(523, 578);
            Controls.Add(customPanel4);
            Controls.Add(customPanel3);
            Controls.Add(customPanel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmSearch";
            Text = "Buscar";
            Load += frmSearch_Load;
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            customPanel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RoundedBorders.CustomPanel customPanel2;
        private ComboBox cmbfields;
        private Label label6;
        private TextBox txtValue;
        private Label label3;
        private RoundedBorders.CustomPanel customPanel3;
        private DataGridView dataGridView1;
        private RoundedBorders.CustomPanel customPanel4;
        private Button btnSalir;
        private Panel panel2;
        private Label label1;
    }
}