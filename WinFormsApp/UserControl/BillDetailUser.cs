using DataAccess.Repositories;
using DTO;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp
{
    public partial class BillDetailUser : UserControl
    {
         WarehouseDTO WarehouseDTO { get; set; }
        ProductDTO ProductDTO { get; set; }
        
        public BillingRepository BillingRepository { get; set; }    
        public ProductRepository ProductRepository { get; set; }    
        public WarehouseRepository WarehouseRepository { get; set; }   

        public  BillHeaderDTO BillHeaderDTO { get; set; }   
        public Form  Form  { get; set; }
        public BillDetailUser()
        {
            InitializeComponent();
     //       Form.FormClosing += Form_FormClosing;
        }
        SearchUser SearchUser;
        private void btnWarehouse_Click(object sender, EventArgs e)
        {

            FrmFather frmFather = ControlForm.GetFrmFather(ref SearchUser ,WarehouseRepository.Values.ToList());
            frmFather.ShowDialog();
            WarehouseDTO = WarehouseRepository.GetById(SearchUser .Id);

            if (WarehouseDTO == null)
            {
                return;
            }
            txtWarehouse.Text = WarehouseDTO != null ? WarehouseDTO.Code + "-" + WarehouseDTO.Name : string.Empty;
            ProductDTO = ProductRepository.GetById(ProductDTO != null ? ProductDTO.Id : 0);
            txtStock.Text = ControlForm.GetStock(ProductDTO, WarehouseDTO).ToString();
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmFather frmFather = ControlForm.GetFrmFather(ref SearchUser, ProductRepository.Values.ToList());
            frmFather.ShowDialog();

            ProductDTO = ProductRepository.GetById(SearchUser.Id);
            if (ProductDTO == null)
            {
                txtProduc.Clear();
                txtStock.Clear();
                return;
            }
            txtProduc.Text = ProductDTO != null ? ProductDTO.Reference : string.Empty;
            txtUnitPrice.Text = ProductDTO.Price.ToString();
            txtStock.Text = ControlForm.GetStock(ProductDTO, WarehouseDTO).ToString();
            txtAmount.Focus();
            txtAmount.Text = "1";

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ProductDTO == null)
            {
                return;
            }            
            decimal.TryParse(txtAmount.Text, out decimal amount);
            if (amount <= 0)
            {
                txtAmount.Text = string.Empty;
                ControlForm.GetMessage("El campo no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAmount.Focus();
                return ;    
            }
                if (ProductRepository  . GetTotalAmount(ProductDTO , amount))
            {
                ControlForm.GetMessage("La cantidad ha sobrepasado el limite minimo en el inventario ","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation );
                return;
            }
     
            BillingRepository.AddDetails(ProductDTO, BillHeaderDTO, WarehouseDTO, amount);      
            Form .Close();
        }
        void newDetail()
        {
            ProductDTO = null;
            WarehouseDTO = null;
            txtAmount.Clear();
            txtProduc.Clear();
            txtWarehouse.Clear();
            txtStock.Clear();

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
           Form .Close();
        }

    }
}
