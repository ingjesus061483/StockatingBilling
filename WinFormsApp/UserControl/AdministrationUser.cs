using DataAccess.Repositories;
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
    public partial class AdministrationUser : UserControl
    {
        public TaxRepository TaxRepository { get; set; }
        public CompanyRepository companyRepository { get; set; }
        public EmployeeRepository employeeRepository { get; set; }
        public IdentificationTypeRepository IdentificationTypeRepository { get; set; }
        public ClientRepository clientRepository { get; set; }
        public RoleRepository roleRepository { get; set; }
        public UnitMeasurementRepository unitMeasurementRepository { get; set; }

        public StockRepository StockRepository { get; set; }
        public CategoryRepository categoryRepository { get; set; }
        public ProductRepository productRepository { get; set; }
        public PictureRepository pictureRepository { get; set; }
        public WarehouseRepository warehouseRepository { get; set; }
        public UserRepository userRepository { get; set; }
        public ProviderRepository providerRepository { get; set; }
        public RegimenTypeRepository RegimenTypeRepository { get; set; }
        public Form frmMain { get; set; }
        DataGridView DataGridView;
        public AdministrationUser()
        {
            InitializeComponent();
        }
        private void toolStripButtonCategory_Click(object sender, EventArgs e)
        {
            DataGridView = null;

            DataGridView = ControlForm.GetDatagrid();
            CategoryUser category = new()
            {
                CmbFilter = cmbfields,
                TxtValue = txtValue,
                repository = categoryRepository,
                DataGridView = DataGridView,
                Form = frmMain,
                Dock = DockStyle.Fill
            };
            addControls(DataGridView, category);
        }
        private void toolStripButtonProduct_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            ProductUser product = new()
            {
                repository = productRepository,
                pictureRepository = pictureRepository,
                CmbFilter = cmbfields,
                TxtValue = txtValue,
                categoryRepository = categoryRepository,
                unitMeasurementRepository = unitMeasurementRepository,
                WarehouseRepository = warehouseRepository,
                stockRepository = StockRepository,
                dgProduct = DataGridView,
                Form = frmMain,
                Dock = DockStyle.Fill
            };
            addControls(DataGridView, product);
        }
        private void toolStripButtonUnitMeasurement_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            UnitMeasurementUser unitMeasurement = new()
            {
                UnitMeasurementRepository = unitMeasurementRepository,
                CmbFilter = cmbfields,
                TxtValue = txtValue,
                DataGridView = DataGridView,
                Form = frmMain,
                Dock = DockStyle.Fill
            };
            addControls(DataGridView, unitMeasurement);
        }
        private void toolStripButtonWarehouse_Click(object sender, EventArgs e)
        {

            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            WarehouseUser warehouse = new()
            {
                CmbFilter = cmbfields,
                TxtValue = txtValue,
                ProductRepository = productRepository,
                StockRepository = StockRepository,
                warehouseRepository = warehouseRepository,
                DataGridView = DataGridView,
                Form = frmMain,
                Dock = DockStyle.Fill
            };
            addControls(DataGridView, warehouse);
        }
        private void toolStripButtonRole_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            RoleUser role = new()
            {
                CmbFilter = cmbfields,
                TxtValue = txtValue,
                RoleRepository = roleRepository,
                DataGridView = DataGridView,
                Dock = DockStyle.Fill,
                Form = frmMain
            };
            addControls(DataGridView, role);
        }
        private void toolStripButtonClient_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();

            ClientUser client = new()
            {
                CmbFilter = cmbfields,
                TxtValue = txtValue,
                ClientRepository = clientRepository,
                IdentificationTypeRepository = IdentificationTypeRepository,
                DataGridView = DataGridView,
                Dock = DockStyle.Fill,
                Form = frmMain
            };
            addControls(DataGridView, client);

        }
        private void toolStripButtonEmployee_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            EmployeeUser employee = new EmployeeUser
            {
                CompanyRepository = companyRepository,
                UserRepository = userRepository,
                DataGridView = DataGridView,
                TxtValue = txtValue,
                CmbFilter = cmbfields,
                EmployeeRepository = employeeRepository,
                IdentificationTypeRepository = IdentificationTypeRepository,
                RoleRepository = roleRepository,
                Form = frmMain
            };
            addControls(DataGridView, employee);
        }
        void addControls(DataGridView dataGridView, UserControl userControl)
        {
            pnlDatagrid.Controls.Clear();
            pnlPrincipal.Controls.Clear();
            pnlDatagrid.Controls.Add(dataGridView);
            pnlPrincipal.Controls.Add(userControl);
        }
        private void toolStripButtonCompany_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            CompanyUser companyUser = new CompanyUser
            {
                CompanyRepository = companyRepository,
                DataGridView = DataGridView,
                TxtValue = txtValue,
                CmbFilter = cmbfields,
                RegimenTypeRepository = RegimenTypeRepository,
                Form = frmMain
            };
            addControls(DataGridView, companyUser);

        }
        private void toolStripButtonProvider_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            ProviderUser provider = new ProviderUser
            {
                ProviderRepository = providerRepository,
                IdentificationTypeRepository = IdentificationTypeRepository,
                DataGridView = DataGridView,
                TxtValue = txtValue,
                Form = frmMain,
                CmbFilter = cmbfields,
            };
            addControls(DataGridView, provider);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            TaxUser tax = new TaxUser
            {
                TaxRepository = TaxRepository,
                DataGridView = DataGridView,
                TxtValue = txtValue,
                Form = frmMain,
                CmbFilter = cmbfields,
            };
            addControls(DataGridView, tax);

        }


  
    }
}
