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
    public partial class frmStock : Form
    {
        public ProductDTO ProductDTO { get; set; }
        public WarehouseDTO WarehouseDTO { get; set; }
        public StockRepository Repository { get; set; }
        public ProductRepository ProductRepository { get; set; }
        public WarehouseRepository WarehouseRepository { get; set; }
        StockDTO StockDTO { get; set; }
        public frmStock()
        {
            InitializeComponent();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            NewStock();
        }
        void NewStock()
        {
            StockDTO = null;
            txtAmount.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
            checkBox1.Checked = true;
            bool prod;
            if (ProductDTO != null)
            {
                prod = ProductDTO != null;
                txtProduc.Text = ProductDTO != null ? ProductDTO.Reference : string.Empty;
                btnProduct.Enabled = !prod;
                dataGridView1.DataSource = Repository.Values.Where(x => x.ProductId == ProductDTO.Id).Select(x => new
                {
                    x.Id,
                    x.Amount,
                    x.Date,
                    Entrance = x.Entrance ? "Si" : "No",
                    ProductName = x.Product.Code + " - " + x.Product.Name,
                    warehouse = x.Warehouse.Code + " - " + x.Warehouse.Name,
                }).ToList();
                txtWarehouse.Text = string.Empty;
                btnWarehouse.Enabled = true;
            }
            else if (WarehouseDTO != null)
            {
                prod = WarehouseDTO != null;
                txtWarehouse.Text = WarehouseDTO != null ? WarehouseDTO.Code + " - " + WarehouseDTO.Name : string.Empty;
                btnWarehouse.Enabled = !prod;
                dataGridView1.DataSource = Repository.Values.Where(x => x.WarehouseId == WarehouseDTO.Id).Select(x => new
                {
                    x.Id,
                    x.Amount,
                    x.Date,
                    Entrance = x.Entrance ? "Si" : "No",
                    ProductName = x.Product.Code + " - " + x.Product.Name,
                    warehouse = x.Warehouse.Code + " - " + x.Warehouse.Name,
                }).ToList();
                txtProduc.Text = string.Empty;
                btnProduct.Enabled = true;
            }
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch { ProductDTOs = ProductRepository.Values.ToList(), Text = "Busqueda - producto" };
            frmSearch.ShowDialog();
            ProductDTO = ProductRepository.GetById(frmSearch.Id);
            txtProduc.Text = ProductDTO != null ? ProductDTO.Reference : string.Empty;
            txtAmount.Focus();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch { WarehouseDTOs = WarehouseRepository.Values.ToList(), Text = "Busqueda - bodega" };
            frmSearch.ShowDialog();
            WarehouseDTO = WarehouseRepository.GetById(frmSearch.Id);
            txtWarehouse.Text = WarehouseDTO != null ? WarehouseDTO.Code + " - " + WarehouseDTO.Name : "";
            txtAmount.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtAmount.Text, out decimal amount);
            if(amount == 0)
            {
                ControlForm.GetMessage("El campo cantidad no puede ser 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ProductDTO == null)
            {
                ControlForm.GetMessage("El campo producto no se ha seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (WarehouseDTO == null)
            {
                ControlForm.GetMessage("El campo bodega no se ha seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (StockDTO == null)
            {
                var exits = Repository.Values.Where(x => x.Entrance).ToList();
                var entrada = Repository.Values.Where(x => x.Entrance && x.ProductId == ProductDTO.Id && x.WarehouseId == WarehouseDTO.Id).Sum(x => x.Amount);
                var salida = Repository.Values.Where(x => !x.Entrance && x.ProductId == ProductDTO.Id && x.WarehouseId == WarehouseDTO.Id).Sum(x => x.Amount);
                var total = entrada - salida;
                if (exits.Count == 0 && !checkBox1.Checked)
                {
                    ControlForm.GetMessage("Debe haber  por lo menos una entrada en existencia", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   NewStock();
                    return;

                }  
                if(total-amount<WarehouseDTO.StockMinimo  &&!checkBox1 .Checked )
                {
                    ControlForm.GetMessage("el total de existencia no puede ser menor al minimo", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NewStock();
                    return;
                }
                StockDTO = new StockDTO
                {
                    ProductId = ProductDTO.Id,
                    WarehouseId = WarehouseDTO.Id,
                    Date = dtpDate.Value,
                    Amount = amount,
                    Entrance = checkBox1.Checked
                };
                Repository.Save(StockDTO);
            }
            else
            {
                StockDTO.Amount = amount;
                StockDTO.Date =DateTime .Now ;
                Repository.Update(StockDTO, StockDTO.Id);
            }
            NewStock();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex >= 0 ? int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()) : 0;
            StockDTO = Repository.GetById(id);
            if (StockDTO == null)
            {

                NewStock();
                return;
            }
            txtProduc.Text = StockDTO.Product != null ? StockDTO.Product.Code + " - " + StockDTO.Product.Name : string.Empty;
            btnProduct.Enabled = false;
            txtWarehouse.Text = StockDTO.Warehouse != null ? StockDTO.Warehouse.Code + " - " + StockDTO.Warehouse.Name : string.Empty;
            btnWarehouse.Enabled = false;
            txtAmount.Text = StockDTO.Amount.ToString();
            dtpDate.Value = StockDTO.Date;
            checkBox1.Checked = StockDTO.Entrance;
            ProductDTO = ProductRepository.GetById(StockDTO.ProductId);
            WarehouseDTO = WarehouseRepository.GetById(StockDTO.WarehouseId);

        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            NewStock();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var exits = Repository.Values.Where(x => !x.Entrance).ToList();
            if (exits.Count > 0&&StockDTO.Entrance)
            {
                ControlForm.GetMessage("debe haber por los menos una salida", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;

            }  
            Repository.DeleteById (StockDTO.Id );
            NewStock(); 
        }
    }
}
