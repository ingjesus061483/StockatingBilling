namespace WinFormsApp
{
    partial class FrmReport
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customPanel2 = new RoundedBorders.CustomPanel();
            SuspendLayout();
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.FromArgb(224, 224, 224);
            customPanel2.GradientTopColor = Color.FromArgb(224, 224, 224);
            customPanel2.Location = new Point(9, 10);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(457, 410);
            customPanel2.TabIndex = 4;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(476, 430);
            Controls.Add(customPanel2);
            Name = "FrmProduct";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RoundedBorders.CustomPanel customPanel2;
    }
}
