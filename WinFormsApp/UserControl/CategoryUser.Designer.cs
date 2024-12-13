﻿namespace WinFormsApp
{
    partial class CategoryUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryUser));
            customPanel2 = new RoundedBorders.CustomPanel();
            txtDescription = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            btnNevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            customPanel1 = new RoundedBorders.CustomPanel();
            label5 = new Label();
            customPanel3 = new RoundedBorders.CustomPanel();
            customPanel2.SuspendLayout();
            customPanel1.SuspendLayout();
            customPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(txtDescription);
            customPanel2.Controls.Add(label2);
            customPanel2.Controls.Add(txtName);
            customPanel2.Controls.Add(label1);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(10, 61);
            customPanel2.Margin = new Padding(2);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(316, 164);
            customPanel2.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(104, 38);
            txtDescription.Margin = new Padding(2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Both;
            txtDescription.Size = new Size(199, 116);
            txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 16);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(104, 13);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 16);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // btnNevo
            // 
            btnNevo.BackColor = Color.Transparent;
            btnNevo.BackgroundImage = (Image)resources.GetObject("btnNevo.BackgroundImage");
            btnNevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNevo.FlatStyle = FlatStyle.Flat;
            btnNevo.Location = new Point(133, 4);
            btnNevo.Margin = new Padding(2);
            btnNevo.Name = "btnNevo";
            btnNevo.Size = new Size(40, 40);
            btnNevo.TabIndex = 7;
            btnNevo.UseVisualStyleBackColor = false;
            btnNevo.Click += btnNevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(178, 4);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(40, 40);
            btnGuardar.TabIndex = 6;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(225, 4);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(40, 40);
            btnEliminar.TabIndex = 5;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(270, 4);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(40, 40);
            btnSalir.TabIndex = 4;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += BtnSalir_Click;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(label5);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel1.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel1.Location = new Point(10, 11);
            customPanel1.Margin = new Padding(2);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(316, 46);
            customPanel1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 10);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(271, 29);
            label5.TabIndex = 0;
            label5.Text = "Registro de categorias";
            // 
            // customPanel3
            // 
            customPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(btnNevo);
            customPanel3.Controls.Add(btnSalir);
            customPanel3.Controls.Add(btnGuardar);
            customPanel3.Controls.Add(btnEliminar);
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel3.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel3.Location = new Point(13, 230);
            customPanel3.Margin = new Padding(2);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(314, 47);
            customPanel3.TabIndex = 8;
            // 
            // CategoryUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(customPanel3);
            Controls.Add(customPanel1);
            Controls.Add(customPanel2);
            Margin = new Padding(2);
            Name = "CategoryUser";
            Size = new Size(337, 288);
            Load += CategoryUser_Load;
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            customPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private RoundedBorders.CustomPanel customPanel2;
        private Button btnNevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnSalir;
        private TextBox txtDescription;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private RoundedBorders.CustomPanel customPanel1;
        private Label label5;
        private RoundedBorders.CustomPanel customPanel3;
    }
}
