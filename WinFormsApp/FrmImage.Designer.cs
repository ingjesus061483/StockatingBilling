namespace WinFormsApp
{
    partial class FrmImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImage));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            customPanel2 = new RoundedBorders.CustomPanel();
            panel2 = new Panel();
            btnUpload = new Button();
            btnSalir = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            customPanel1 = new RoundedBorders.CustomPanel();
            dgImages = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            btnVer = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            customPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgImages).BeginInit();
            SuspendLayout();
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(panel2);
            customPanel2.Controls.Add(panel1);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(224, 224, 224);
            customPanel2.GradientTopColor = Color.FromArgb(224, 224, 224);
            customPanel2.Location = new Point(9, 222);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(764, 575);
            customPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(42, 46, 50);
            panel2.Controls.Add(btnUpload);
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 478);
            panel2.Name = "panel2";
            panel2.Size = new Size(764, 97);
            panel2.TabIndex = 2;
            // 
            // btnUpload
            // 
            btnUpload.BackgroundImage = (Image)resources.GetObject("btnUpload.BackgroundImage");
            btnUpload.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Location = new Point(630, 15);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(57, 67);
            btnUpload.TabIndex = 20;
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(693, 15);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 67);
            btnSalir.TabIndex = 17;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 478);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(764, 478);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(dgImages);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.Location = new Point(9, 12);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(766, 205);
            customPanel1.TabIndex = 3;
            // 
            // dgImages
            // 
            dgImages.AllowUserToAddRows = false;
            dgImages.AllowUserToDeleteRows = false;
            dgImages.BackgroundColor = Color.FromArgb(42, 46, 50);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgImages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgImages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgImages.Columns.AddRange(new DataGridViewColumn[] { Id, Codigo, Nombre, Tipo, Data, btnVer, Eliminar });
            dgImages.Dock = DockStyle.Fill;
            dgImages.Location = new Point(0, 0);
            dgImages.Name = "dgImages";
            dgImages.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgImages.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgImages.RowHeadersVisible = false;
            dgImages.RowHeadersWidth = 62;
            dgImages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgImages.Size = new Size(766, 205);
            dgImages.TabIndex = 0;
            dgImages.CellContentClick += dgImages_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 150;
            // 
            // Codigo
            // 
            Codigo.DataPropertyName = "Codigo";
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 8;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 150;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 150;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "Tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 8;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 150;
            // 
            // Data
            // 
            Data.DataPropertyName = "Data";
            Data.HeaderText = "Data";
            Data.MinimumWidth = 8;
            Data.Name = "Data";
            Data.ReadOnly = true;
            Data.Visible = false;
            Data.Width = 150;
            // 
            // btnVer
            // 
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.HeaderText = "";
            btnVer.MinimumWidth = 8;
            btnVer.Name = "btnVer";
            btnVer.ReadOnly = true;
            btnVer.Text = "Ver";
            btnVer.UseColumnTextForButtonValue = true;
            btnVer.Width = 150;
            // 
            // Eliminar
            // 
            Eliminar.FlatStyle = FlatStyle.Flat;
            Eliminar.HeaderText = "";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            Eliminar.Width = 150;
            // 
            // FrmImage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(786, 808);
            Controls.Add(customPanel1);
            Controls.Add(customPanel2);
            Name = "FrmImage";
            Text = "FrmImagenes";
            Load += FrmImage_Load;
            customPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgImages).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RoundedBorders.CustomPanel customPanel2;
        private PictureBox pictureBox1;
        private RoundedBorders.CustomPanel customPanel1;
        private DataGridView dgImages;
        private Panel panel1;
        private Panel panel2;
        private Button btnSalir;
        private Button btnUpload;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewButtonColumn btnVer;
        private DataGridViewButtonColumn Eliminar;
    }
}