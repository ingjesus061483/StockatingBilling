using DataAccess.Repositories;
using Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmMain : Form
    {
        IdentificationTypeRepository IdentificationTypeRepository;
        ClientRepository clientRepository;
        RoleRepository roleRepository;
        UnitMeasurementRepository unitMeasurementRepository;
        DataGridView DataGridView;
        StockRepository StockRepository;
        CategoryRepository categoryRepository;
        ProductRepository productRepository;
        PictureRepository pictureRepository;
        WarehouseRepository warehouseRepository;
        public FrmMain(CategoryRepository _categoryRepository,
                            ProductRepository _productRepository,
                            UnitMeasurementRepository _unitMeasurementRepository,
                            PictureRepository _pictureRepository,
                            WarehouseRepository _warehouseRepository,
                            StockRepository _stockRepository,
                            ClientRepository _clientRepository,
                            IdentificationTypeRepository _identificationTypeRepository,
                            RoleRepository _roleRepository 
            )

        {
            roleRepository= _roleRepository;
            IdentificationTypeRepository = _identificationTypeRepository;
            clientRepository = _clientRepository;
            StockRepository = _stockRepository;
            warehouseRepository = _warehouseRepository;
            categoryRepository = _categoryRepository;
            productRepository = _productRepository;
            pictureRepository = _pictureRepository;
            unitMeasurementRepository = _unitMeasurementRepository;
            InitializeComponent();
        }


        private void toolStripButtonCategory_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            pnlPrincipal.Controls.Clear();
            pnlDatagrid.Controls.Clear();
            CategoryUser category = new()
            {
                repository = categoryRepository,
                DataGridView = DataGridView,
                Form = this,
                Dock = DockStyle.Fill
            };
            pnlDatagrid.Controls.Add(DataGridView);
            pnlPrincipal.Controls.Add(category);
        }

        private void toolStripButtonProduct_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            ProductUser product = new()
            {
                repository = productRepository,
                pictureRepository = pictureRepository,
                categoryRepository = categoryRepository,
                unitMeasurementRepository = unitMeasurementRepository,
                WarehouseRepository = warehouseRepository,
                stockRepository = StockRepository,
                dgProduct = DataGridView,
                Form = this,
                Dock = DockStyle.Fill
            };
            pnlDatagrid.Controls.Clear();
            pnlPrincipal.Controls.Clear();
            pnlDatagrid.Controls.Add(DataGridView);
            pnlPrincipal.Controls.Add(product);
        }
        private void toolStripButtonUnitMeasurement_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            pnlDatagrid.Controls.Clear();
            pnlPrincipal.Controls.Clear();
            UnitMeasurementUser unitMeasurement = new()
            {
                UnitMeasurementRepository = unitMeasurementRepository,
                DataGridView = DataGridView,
                Form = this,
                Dock = DockStyle.Fill
            };
            pnlDatagrid.Controls.Add(DataGridView);
            pnlPrincipal.Controls.Add(unitMeasurement);
        }

        private void toolStripButtonWarehouse_Click(object sender, EventArgs e)
        {

            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            pnlDatagrid.Controls.Clear();
            pnlPrincipal.Controls.Clear();
            WarehouseUser warehouse = new()
            {
                ProductRepository = productRepository,
                StockRepository = StockRepository,
                warehouseRepository = warehouseRepository,
                DataGridView = DataGridView,
                Form = this,
                Dock = DockStyle.Fill
            };
            pnlDatagrid.Controls.Add(DataGridView);
            pnlPrincipal.Controls.Add(warehouse);

        }
        private void toolStripButtonRole_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            pnlDatagrid.Controls.Clear();
            pnlPrincipal.Controls.Clear();
            RoleUser role = new()
            {
                RoleRepository = roleRepository,                
                DataGridView = DataGridView,
                Dock = DockStyle.Fill,
                Form = this
            };
            pnlDatagrid.Controls.Add(DataGridView);
            pnlPrincipal.Controls.Add(role );

        }




        private void toolStripButtonClient_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            pnlDatagrid.Controls.Clear();
            pnlPrincipal.Controls.Clear();
            ClientUser client = new()
            {
                ClientRepository = clientRepository,
                IdentificationTypeRepository = IdentificationTypeRepository,
                DataGridView = DataGridView,
                Dock=DockStyle.Fill,
                Form = this
            };
            pnlDatagrid.Controls.Add(DataGridView);
            pnlPrincipal.Controls.Add(client);

        }
    }
}
