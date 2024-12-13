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
            customPanel1 = new RoundedBorders.CustomPanel();
            label5 = new Label();
            customPanel2 = new RoundedBorders.CustomPanel();
            cmbfields = new ComboBox();
            label6 = new Label();
            txtValue = new TextBox();
            label3 = new Label();
            customPanel3 = new RoundedBorders.CustomPanel();
            dataGridView1 = new DataGridView();
            customPanel4 = new RoundedBorders.CustomPanel();
            btnSalir = new Button();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            customPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            customPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(label5);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(224, 224, 224);
            customPanel1.GradientTopColor = Color.FromArgb(224, 224, 224);
            customPanel1.Location = new Point(11, 11);
            customPanel1.Margin = new Padding(2);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(344, 46);
            customPanel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(99, 8);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 29);
            label5.TabIndex = 0;
            label5.Text = "Busqueda";
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(cmbfields);
            customPanel2.Controls.Add(label6);
            customPanel2.Controls.Add(txtValue);
            customPanel2.Controls.Add(label3);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(224, 224, 224);
            customPanel2.GradientTopColor = Color.FromArgb(224, 224, 224);
            customPanel2.Location = new Point(11, 60);
            customPanel2.Margin = new Padding(2);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(344, 78);
            customPanel2.TabIndex = 7;
            // 
            // cmbfields
            // 
            cmbfields.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbfields.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbfields.FormattingEnabled = true;
            cmbfields.Location = new Point(84, 15);
            cmbfields.Margin = new Padding(2);
            cmbfields.Name = "cmbfields";
            cmbfields.Size = new Size(240, 23);
            cmbfields.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10F, FontStyle.Bold);
            label6.Location = new Point(16, 19);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 16);
            label6.TabIndex = 17;
            label6.Text = "Campos";
            // 
            // txtValue
            // 
            txtValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtValue.Location = new Point(84, 40);
            txtValue.Margin = new Padding(2);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(240, 23);
            txtValue.TabIndex = 9;
            txtValue.TextChanged += txtValue_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.Location = new Point(37, 43);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 16);
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
            customPanel3.Location = new Point(11, 142);
            customPanel3.Margin = new Padding(2);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(344, 138);
            customPanel3.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(344, 138);
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
            customPanel4.GradientBottomColor = Color.FromArgb(224, 224, 224);
            customPanel4.GradientTopColor = Color.FromArgb(224, 224, 224);
            customPanel4.Location = new Point(11, 284);
            customPanel4.Margin = new Padding(2);
            customPanel4.Name = "customPanel4";
            customPanel4.Size = new Size(344, 50);
            customPanel4.TabIndex = 14;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(292, 5);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(40, 40);
            btnSalir.TabIndex = 13;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(366, 340);
            Controls.Add(customPanel4);
            Controls.Add(customPanel3);
            Controls.Add(customPanel1);
            Controls.Add(customPanel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmSearch";
            Text = "Buscar";
            Load += frmSearch_Load;
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            customPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            customPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RoundedBorders.CustomPanel customPanel1;
        private Label label5;
        private RoundedBorders.CustomPanel customPanel2;
        private ComboBox cmbfields;
        private Label label6;
        private TextBox txtValue;
        private Label label3;
        private RoundedBorders.CustomPanel customPanel3;
        private DataGridView dataGridView1;
        private RoundedBorders.CustomPanel customPanel4;
        private Button btnSalir;
    }
}