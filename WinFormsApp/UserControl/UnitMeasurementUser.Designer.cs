﻿namespace WinFormsApp
{
    partial class UnitMeasurementUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitMeasurementUser));
            label5 = new Label();
            customPanel2 = new RoundedBorders.CustomPanel();
            panel2 = new Panel();
            txtDescription = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            btnNevo = new Button();
            btnGuardar = new Button();
            btnSalir = new Button();
            customPanel3 = new RoundedBorders.CustomPanel();
            customPanel2.SuspendLayout();
            panel2.SuspendLayout();
            customPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(77, 13);
            label5.Name = "label5";
            label5.Size = new Size(371, 43);
            label5.TabIndex = 0;
            label5.Text = "Registro de medidas";
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(panel2);
            customPanel2.Controls.Add(txtDescription);
            customPanel2.Controls.Add(label2);
            customPanel2.Controls.Add(txtName);
            customPanel2.Controls.Add(label1);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel2.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel2.Location = new Point(14, 20);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(451, 353);
            customPanel2.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 63);
            panel2.TabIndex = 24;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(157, 133);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Both;
            txtDescription.Size = new Size(274, 191);
            txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 140);
            label2.Name = "label2";
            label2.Size = new Size(122, 24);
            label2.TabIndex = 2;
            label2.Text = "Descripcion";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(157, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(274, 31);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 95);
            label1.Name = "label1";
            label1.Size = new Size(84, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // btnNevo
            // 
            btnNevo.BackColor = Color.Transparent;
            btnNevo.BackgroundImage = (Image)resources.GetObject("btnNevo.BackgroundImage");
            btnNevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNevo.FlatStyle = FlatStyle.Flat;
            btnNevo.Location = new Point(265, 7);
            btnNevo.Name = "btnNevo";
            btnNevo.Size = new Size(57, 67);
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
            btnGuardar.Location = new Point(326, 7);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(57, 67);
            btnGuardar.TabIndex = 6;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(390, 7);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 67);
            btnSalir.TabIndex = 4;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // customPanel3
            // 
            customPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(btnNevo);
            customPanel3.Controls.Add(btnSalir);
            customPanel3.Controls.Add(btnGuardar);
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel3.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel3.Location = new Point(14, 382);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(451, 78);
            customPanel3.TabIndex = 10;
            // 
            // UnitMeasurementUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(customPanel3);
            Controls.Add(customPanel2);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "UnitMeasurementUser";
            Size = new Size(481, 483);
            Load += UnitMeasurementUser_Load;
            customPanel2.ResumeLayout(false);
            customPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            customPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label5;
        private RoundedBorders.CustomPanel customPanel2;
        private Button btnNevo;
        private Button btnGuardar;
        private Button btnSalir;
        private TextBox txtDescription;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private RoundedBorders.CustomPanel customPanel3;
        private Panel panel2;
    }
}
