﻿namespace WinFormsApp
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
            btnStock = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
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
            customPanel3.Controls.Add(btnStock);
            customPanel3.Controls.Add(btnSalir);
            customPanel3.Controls.Add(btnEliminar);
            customPanel3.Controls.Add(btnGuardar);
            customPanel3.Controls.Add(btnuevo);
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel3.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel3.Location = new Point(13, 288);
            customPanel3.Margin = new Padding(2, 2, 2, 2);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(344, 50);
            customPanel3.TabIndex = 10;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.Transparent;
            btnStock.BackgroundImage = (Image)resources.GetObject("btnStock.BackgroundImage");
            btnStock.BackgroundImageLayout = ImageLayout.Stretch;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Location = new Point(122, 6);
            btnStock.Margin = new Padding(2, 2, 2, 2);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(40, 40);
            btnStock.TabIndex = 26;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(299, 6);
            btnSalir.Margin = new Padding(2, 2, 2, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(40, 40);
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
            btnEliminar.Location = new Point(255, 6);
            btnEliminar.Margin = new Padding(2, 2, 2, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(40, 40);
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
            btnGuardar.Location = new Point(211, 6);
            btnGuardar.Margin = new Padding(2, 2, 2, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(40, 40);
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
            btnuevo.Location = new Point(167, 6);
            btnuevo.Margin = new Padding(2, 2, 2, 2);
            btnuevo.Name = "btnuevo";
            btnuevo.Size = new Size(40, 40);
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
            label5.Location = new Point(57, 7);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(240, 29);
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
            customPanel2.Location = new Point(13, 19);
            customPanel2.Margin = new Padding(2, 2, 2, 2);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(344, 263);
            customPanel2.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(344, 38);
            panel2.TabIndex = 24;
            // 
            // chkLimit
            // 
            chkLimit.AutoSize = true;
            chkLimit.BackColor = Color.Transparent;
            chkLimit.CheckAlign = ContentAlignment.MiddleRight;
            chkLimit.Font = new Font("Arial", 10F, FontStyle.Bold);
            chkLimit.ForeColor = Color.White;
            chkLimit.Location = new Point(34, 112);
            chkLimit.Margin = new Padding(2, 2, 2, 2);
            chkLimit.Name = "chkLimit";
            chkLimit.Size = new Size(85, 20);
            chkLimit.TabIndex = 23;
            chkLimit.Text = "Limitado";
            chkLimit.UseVisualStyleBackColor = false;
            chkLimit.CheckedChanged += chkLimit_CheckedChanged;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(120, 58);
            txtCode.Margin = new Padding(2, 2, 2, 2);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(208, 23);
            txtCode.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 10F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(60, 59);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(57, 16);
            label8.TabIndex = 21;
            label8.Text = "Codigo";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(179, 110);
            txtMin.Margin = new Padding(2, 2, 2, 2);
            txtMin.Name = "txtMin";
            txtMin.ReadOnly = true;
            txtMin.Size = new Size(38, 23);
            txtMin.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 10F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(120, 114);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 16);
            label7.TabIndex = 19;
            label7.Text = "Minimo";
            // 
            // txtMax
            // 
            txtMax.Location = new Point(290, 110);
            txtMax.Margin = new Padding(2, 2, 2, 2);
            txtMax.Name = "txtMax";
            txtMax.ReadOnly = true;
            txtMax.Size = new Size(38, 23);
            txtMax.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(226, 112);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 16);
            label3.TabIndex = 8;
            label3.Text = "Maximo";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 136);
            txtDescription.Margin = new Padding(2, 2, 2, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Both;
            txtDescription.Size = new Size(208, 111);
            txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 139);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 16);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 84);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 87);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 16);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // WarehouseUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(customPanel3);
            Controls.Add(customPanel2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "WarehouseUser";
            Size = new Size(372, 351);
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
        private Button btnStock;
        private Button btnSalir;
        private Button btnEliminar;
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
