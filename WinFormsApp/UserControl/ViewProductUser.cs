using DataAccess.Repositories;
using DTO;
using Factory;
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
    public partial class ViewProductUser : UserControl
    {
        List<StockDTO> Entrances;
        List<StockDTO >Exits;
       List< PictureDTO> PictureDTOs {  get; set; }
        WarehouseDTO warehouseDTO;
        public Form Form {  get; set; }
        public  ProductDTO  ProductDTO { get; set; }
        public StockRepository StockRepository { get; set; }
        public PictureRepository PictureRepository { get; set; }
        public  WarehouseRepository WarehouseRepository {  get; set; }
        public ViewProductUser()
        {
            InitializeComponent();
        }
        void ViewProductUser_Load(object sender, EventArgs e)
        {
            if (ProductDTO != null)
            {
                ProductDTO.Images = PictureRepository.Values.Where(x => x.ProductId == ProductDTO .Id ).Select(t => new Picture
                {
                    Id = t.Id,
                    Code = t.Code,
                    Name = t.Name,
                    Data = t.Data,
                    Type = t.Type,
                }).ToList();
                txtCode.Text = ProductDTO.Code;
                txtUnitCost.Text = ProductDTO.UnitCost.ToString();
                txtName.Text = ProductDTO.Name;
                txtDescription.Text = ProductDTO.Description;
                txtPrice.Text = ProductDTO.Price.ToString();
                txtUnitMeasurement.Text = ProductDTO.UnitMeasurement .Name ;
                txtCategory.Text = ProductDTO.Category.Name;
                PictureDTOs = PictureRepository.Values.ToList();
                return;
            }
        }
        SearchUser SearchUser;
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            FrmFather frmFather = ControlForm.GetFrmFather(ref SearchUser, WarehouseRepository.Values.ToList());

            frmFather .ShowDialog();
            warehouseDTO = WarehouseRepository.GetById(SearchUser.Id);
            txtWarehouse.Text = warehouseDTO != null ? warehouseDTO.Code + " - " + warehouseDTO.Name : "";
           Entrances= StockRepository.GetStockDTOs(ProductDTO.Id, warehouseDTO.Id).ToList ();
            Exits = StockRepository.GetStockDTOs(ProductDTO.Id, warehouseDTO.Id, false).ToList ();
            dgEntrance .DataSource = Entrances.Select(x => new
            {
                x.Id,
                x.Amount,
                x.Date,
                Entrance = x.Entrance ? "Si" : "No",
                ProductName = x.Product.Code + " - " + x.Product.Name,
                warehouse = x.Warehouse.Code + " - " + x.Warehouse.Name,
            }).ToList(); 
                dgExits .DataSource = Exits.Select(x => new
                {
                    x.Id,
                    x.Amount,
                    x.Date,
                    Entrance = x.Entrance ? "Si" : "No",
                    ProductName = x.Product.Code + " - " + x.Product.Name,
                    warehouse = x.Warehouse.Code + " - " + x.Warehouse.Name,
                }).ToList(); 
            txtEntrance.Text = Entrances .Sum(x=>x.Amount ).ToString ();
            txtExit .Text = Exits .Sum(x=>x.Amount ).ToString ();
            txtStock.Text =StockRepository . GetTotalStock(ProductDTO.  Id, warehouseDTO .Id).ToString ();
        }
        void btnExit_Click(object sender, EventArgs e)
        {
           Form .Close ();
        }
        void btnExcel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Array array = Entrances.Select(x => new
            {
                x.Id,
                Producto = x.Product.Code + " - " + x.Product.Name,
                Bodega = x.Warehouse.Code + " - " + x.Warehouse.Name,

                Cantidad = x.Amount,
                Fecha = x.Date,
                Entrada = x.Entrance ? "Si" : "No",
            }).ToArray () ;
            Array array1= Exits.Select(x => new
            {               
                x.Id, 
                Producto = x.Product.Code + " - " + x.Product.Name,
                Bodega = x.Warehouse.Code + " - " + x.Warehouse.Name,

                Cantidad = x.Amount,
                Fecha = x.Date,
                Entrada = x.Entrance ? "Si" : "No",
            }).ToArray();
            Dictionary<string, Array> keyValuePairs = new Dictionary<string, Array>
            {
                {"Entradas", array },
                {"Salidas" ,array1 }
            };
            ExcelRepository excel = new();
            excel .Export( keyValuePairs );
            this.Cursor = Cursors.Default ;
        }
    }
}
