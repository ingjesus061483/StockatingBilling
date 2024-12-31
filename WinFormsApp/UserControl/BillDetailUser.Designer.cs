namespace WinFormsApp
{
    partial class BillDetailUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillDetailUser));
            customPanel5 = new RoundedBorders.CustomPanel();
            btnSalir = new Button();
            btnAdd = new Button();
            customPanelDetail = new RoundedBorders.CustomPanel();
            txtUnitPrice = new TextBox();
            label2 = new Label();
            txtStock = new TextBox();
            txtAmount = new TextBox();
            label3 = new Label();
            btnWarehouse = new Button();
            txtWarehouse = new TextBox();
            btnProduct = new Button();
            txtProduc = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            label4 = new Label();
            customPanel5.SuspendLayout();
            customPanelDetail.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel5
            // 
            customPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanel5.BackColor = Color.White;
            customPanel5.BorderRadius = 30;
            customPanel5.Controls.Add(btnSalir);
            customPanel5.Controls.Add(btnAdd);
            customPanel5.ForeColor = Color.Black;
            customPanel5.GradientAngle = 90F;
            customPanel5.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanel5.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanel5.Location = new Point(26, 217);
            customPanel5.Name = "customPanel5";
            customPanel5.Size = new Size(599, 81);
            customPanel5.TabIndex = 7;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = (Image)resources.GetObject("btnSalir.BackgroundImage");
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(526, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(57, 67);
            btnSalir.TabIndex = 19;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(463, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(57, 67);
            btnAdd.TabIndex = 18;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // customPanelDetail
            // 
            customPanelDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customPanelDetail.BackColor = Color.White;
            customPanelDetail.BorderRadius = 30;
            customPanelDetail.Controls.Add(txtUnitPrice);
            customPanelDetail.Controls.Add(label2);
            customPanelDetail.Controls.Add(txtStock);
            customPanelDetail.Controls.Add(txtAmount);
            customPanelDetail.Controls.Add(label3);
            customPanelDetail.Controls.Add(btnWarehouse);
            customPanelDetail.Controls.Add(txtWarehouse);
            customPanelDetail.Controls.Add(btnProduct);
            customPanelDetail.Controls.Add(txtProduc);
            customPanelDetail.Controls.Add(panel2);
            customPanelDetail.Controls.Add(label4);
            customPanelDetail.ForeColor = Color.Black;
            customPanelDetail.GradientAngle = 90F;
            customPanelDetail.GradientBottomColor = Color.FromArgb(42, 46, 50);
            customPanelDetail.GradientTopColor = Color.FromArgb(42, 46, 50);
            customPanelDetail.Location = new Point(26, 19);
            customPanelDetail.Name = "customPanelDetail";
            customPanelDetail.Size = new Size(599, 187);
            customPanelDetail.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitPrice.Font = new Font("Arial", 10F);
            txtUnitPrice.Location = new Point(478, 100);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(92, 30);
            txtUnitPrice.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(364, 139);
            label2.Name = "label2";
            label2.Size = new Size(107, 24);
            label2.TabIndex = 14;
            label2.Text = "Existencia";
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStock.Font = new Font("Arial", 10F);
            txtStock.Location = new Point(478, 135);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(92, 30);
            txtStock.TabIndex = 13;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Arial", 10F);
            txtAmount.Location = new Point(125, 136);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(237, 30);
            txtAmount.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 139);
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
            btnWarehouse.Location = new Point(18, 64);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(43, 31);
            btnWarehouse.TabIndex = 9;
            btnWarehouse.UseVisualStyleBackColor = false;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // txtWarehouse
            // 
            txtWarehouse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtWarehouse.Font = new Font("Arial", 10F);
            txtWarehouse.Location = new Point(64, 65);
            txtWarehouse.Name = "txtWarehouse";
            txtWarehouse.ReadOnly = true;
            txtWarehouse.Size = new Size(506, 30);
            txtWarehouse.TabIndex = 8;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Transparent;
            btnProduct.BackgroundImage = (Image)resources.GetObject("btnProduct.BackgroundImage");
            btnProduct.BackgroundImageLayout = ImageLayout.Stretch;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnProduct.Location = new Point(18, 100);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(43, 31);
            btnProduct.TabIndex = 7;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // txtProduc
            // 
            txtProduc.Font = new Font("Arial", 10F);
            txtProduc.Location = new Point(66, 100);
            txtProduc.Name = "txtProduc";
            txtProduc.ReadOnly = true;
            txtProduc.Size = new Size(296, 30);
            txtProduc.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 113, 163);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 48);
            panel2.TabIndex = 0;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(370, 105);
            label4.Name = "label4";
            label4.Size = new Size(102, 24);
            label4.TabIndex = 12;
            label4.Text = "Valor Unit";
            // 
            // BillDetailUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(customPanel5);
            Controls.Add(customPanelDetail);
            Name = "BillDetailUser";
            Size = new Size(648, 314);
            customPanel5.ResumeLayout(false);
            customPanelDetail.ResumeLayout(false);
            customPanelDetail.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedBorders.CustomPanel customPanel5;
        private Button btnAdd;
        private RoundedBorders.CustomPanel customPanelDetail;
        private TextBox txtStock;
        private TextBox txtAmount;
        private Label label3;
        private Button btnWarehouse;
        private TextBox txtWarehouse;
        private Button btnProduct;
        private TextBox txtProduc;
        private Panel panel2;
        private Label label1;
        private Label label4;
        private Button btnSalir;
        private TextBox txtUnitPrice;
        private Label label2;
    }
}
