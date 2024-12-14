using DataAccess.Repositories;
using Factory;
using MySqlX.XDevAPI;
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
        public FrmMain(CategoryRepository _categoryRepository,
                            ProductRepository _productRepository,
                            UnitMeasurementRepository _unitMeasurementRepository,
                            PictureRepository _pictureRepository,
                            WarehouseRepository _warehouseRepository,
                            StockRepository _stockRepository,
                            ClientRepository _clientRepository,
                            IdentificationTypeRepository _identificationTypeRepository,
                            RoleRepository _roleRepository,
                            EmployeeRepository _employeeRepository,
                            UserRepository _userRepository,
                            CompanyRepository _companyRepository,
                            RegimenTypeRepository _regimenTypeRepository,
                            ProviderRepository _providerRepository)

        {
            companyRepository = _companyRepository;
            roleRepository = _roleRepository;
            IdentificationTypeRepository = _identificationTypeRepository;
            clientRepository = _clientRepository;
            StockRepository = _stockRepository;
            warehouseRepository = _warehouseRepository;
            categoryRepository = _categoryRepository;
            productRepository = _productRepository;
            pictureRepository = _pictureRepository;
            unitMeasurementRepository = _unitMeasurementRepository;
            employeeRepository = _employeeRepository;
            userRepository = _userRepository;
            RegimenTypeRepository = _regimenTypeRepository;
            providerRepository = _providerRepository;
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
                Form = this,
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
                Form = this,
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
                Form = this,
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
                Form = this,
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
                Form = this
            }; addControls(DataGridView, role);

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
                Form = this
            };

            addControls(DataGridView, client);

        }
        private void FrmMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
            this.Show();
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
                Form = this
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
                Form = this
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
                Form =this,
                CmbFilter = cmbfields,
            };
            addControls(DataGridView, provider);
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resp = MessageBox.Show("Cerrar Aplicacion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
            
        }
    }
}
