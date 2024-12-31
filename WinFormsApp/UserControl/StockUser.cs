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

namespace WinFormsApp
{
    public partial class StockUser : UserControl
    {
        public Form Form { get; set; }
        public ProductDTO ProductDTO { get; set; }
        public StockRepository Repository { get; set; }
        public ProductRepository ProductRepository { get; set; }
        public WarehouseRepository WarehouseRepository { get; set; }     
        WarehouseDTO WarehouseDTO { get; set; }

        StockDTO StockDTO { get; set; }
        public StockUser()
        {
            InitializeComponent();
        }
        SearchUser SearchUser;
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            FrmFather frmFather = ControlForm.GetFrmFather(ref SearchUser, WarehouseRepository.Values.ToList());

           frmFather .ShowDialog();
            WarehouseDTO = WarehouseRepository.GetById(SearchUser.Id);
            txtWarehouse.Text = WarehouseDTO != null ? WarehouseDTO.Code + " - " + WarehouseDTO.Name : "";
            txtAmount.Focus();
        }
        void btnuevo_Click(object sender, EventArgs e)
        {
            NewStock();
        }
        void StockUser_Load(object sender, EventArgs e)
        {
            NewStock();
        }
        void NewStock()
        {
            txtProduc .Text = ProductDTO .Reference ;
            StockDTO = null;
            txtAmount.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
            WarehouseDTO = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtAmount.Text, out decimal amount);
            if (amount == 0)
            {
                ControlForm.GetMessage("El campo cantidad no puede ser 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }         
            if (WarehouseDTO == null)
            {
                ControlForm.GetMessage("El campo bodega no se ha seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var total = Repository.GetTotalStock(ProductDTO.Id, WarehouseDTO.Id);

            if (WarehouseDTO.limitado && total + amount < WarehouseDTO.StockMaximo )
            {
                ControlForm.GetMessage("el total de existencia no puede ser menor al minimo", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewStock();
                return;

            }
            if (StockDTO == null)
            {
             
                StockDTO = new StockDTO
                {
                    ProductId = ProductDTO.Id,
                    WarehouseId = WarehouseDTO.Id,
                    Date = dtpDate.Value,
                    Amount = amount,
                };
                Repository.Save(StockDTO);
            }           
            NewStock();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form .Close();
        }

    }
}
