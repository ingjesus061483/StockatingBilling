using DataAccess.Repositories;
using DTO;
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
        EmployeeDTO EmployeeDTO { get; set; }
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
                            TaxRepository _taxRepository,
                            StateRepository _stateRepository,
                            BillingRepository _billingRepository,
                           DocumentTypeRepository _documentTypeRepository)

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
            documetTypeRepository = _documentTypeRepository;
            stateRepository = _stateRepository;
            billingRepository = _billingRepository;
            InitializeComponent();
        }
        bool IsCloseAppication(EmployeeDTO employeeDTO)
        {
            bool close = false;
            if (employeeDTO == null)
            {
                Application.Exit();
                close = true;
            }
            return close;
        }
        LoginUser GetLoginUser(EmployeeRepository employeeRepository, FrmFather frm)
        {
            LoginUser loginUser = new()
            {
                EmployeeRepository = employeeRepository,
                frmFather = frm,
            };
            return loginUser;
        }
        private void FrmMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
            FrmFather frm = new();
            LoginUser loginUser = GetLoginUser(employeeRepository, frm);
            frm.UserControl = loginUser;
            frm.ShowDialog();
            EmployeeDTO = loginUser.employeeDTO;
            if (IsCloseAppication(EmployeeDTO))
                return;
            lblUser.Text = EmployeeDTO.User.Name;
            lblRole.Text = EmployeeDTO.User.Role.Name;
            this.Show();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (EmployeeDTO == null)
            {
                e.Cancel = false;
            }
            else if (MessageBox.Show("Cerrar Aplicacion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
                TaxRepository = taxRepository,
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
                FrmMain = this,
                Dock = DockStyle.Fill,
            };
            addControl(pnlMain, administration);

        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            BillingAdministrationUser billingUser = new BillingAdministrationUser
            {
                Dock = DockStyle.Fill,
                frmMain = this,
                StateRepository = stateRepository,
                DocumetTypeRepository = documetTypeRepository,
                ProductRepository = productRepository,
                ClientRepository = clientRepository,
                EmployeeRepository = employeeRepository,
                WarehouseRepository = warehouseRepository,
                StockRepository = StockRepository,
                BillingRepository = billingRepository,
            };
            addControl(pnlMain, billingUser);

        }
        void addControl(Panel panel, UserControl control)
        {
            panel.Controls.Clear();
            panel.Controls.Add(control);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FrmFather frmFather = new FrmFather();
            ChangePasswordUser changePasswordUser = new() 
            {
                FrmFather= frmFather,
                UserRepository =userRepository ,
                EmployeeDTO =EmployeeDTO ,
            };
            frmFather .UserControl = changePasswordUser;
            frmFather .ShowDialog();
            if (changePasswordUser.updated)
            {
                EmployeeDTO = null;
                Application.Restart();
            }
        }
    }
}
