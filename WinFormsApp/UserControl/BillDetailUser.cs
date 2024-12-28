using DataAccess.Repositories;
using DTO;
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
        public FrmFather FrmFather { get; set; }
        public BillDetailUser()
        {
            InitializeComponent();
        }
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch
            {
                objects = WarehouseRepository.Values.ToList()
            };
            frmSearch.ShowDialog();
            WarehouseDTO = WarehouseRepository.GetById(frmSearch.Id);

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
            frmSearch frmSearch = new frmSearch
            {
                objects = ProductRepository.Values.ToList()
            };
            frmSearch.ShowDialog();
            ProductDTO = ProductRepository.GetById(frmSearch.Id);
            if (ProductDTO == null)
            {
                txtProduc.Clear();
                txtStock.Clear();
                return;
            }
            txtProduc.Text = ProductDTO != null ? ProductDTO.Reference : string.Empty;
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
            if (ProductRepository  . GetTotalAmount(ProductDTO , amount))
            {
                ControlForm.GetMessage("La cantidad ha sobrepasado el limite minimo en el inventario ","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation );
                return;
            }
     
            BillingRepository.AddDetails(ProductDTO, BillHeaderDTO, WarehouseDTO, amount);      
            FrmFather.Close();
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
           FrmFather.Close();
        }

    }
}
