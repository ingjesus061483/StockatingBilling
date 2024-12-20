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
                            ProviderRepository _providerRepository,
                            TaxRepository _taxRepository)

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
            taxRepository = _taxRepository;
            InitializeComponent();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
            this.Show();
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

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnAdministration_Click(object sender, EventArgs e)
        {
            AdministrationUser administration = new AdministrationUser
            {
                TaxRepository=taxRepository,
                companyRepository = companyRepository,
                roleRepository = roleRepository,
                IdentificationTypeRepository = IdentificationTypeRepository,
                clientRepository = clientRepository,
                StockRepository = StockRepository,
                warehouseRepository = warehouseRepository,
                categoryRepository = categoryRepository,
                productRepository = productRepository,
                pictureRepository = pictureRepository,
                unitMeasurementRepository = unitMeasurementRepository,
                employeeRepository = employeeRepository,
                userRepository = userRepository,
                RegimenTypeRepository = RegimenTypeRepository,
                providerRepository = providerRepository,
                Dock = DockStyle.Fill,
            };
            addControl(pnlMain, administration);

        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            BillingUser billingUser =new BillingUser 
            {
                Dock = DockStyle.Fill,
                frmMain = this

            };
            addControl(pnlMain, billingUser);

        }
        void addControl(Panel panel,UserControl control )
        {
            panel.Controls.Clear();
            panel.Controls.Add(control );
        }
    }
}
