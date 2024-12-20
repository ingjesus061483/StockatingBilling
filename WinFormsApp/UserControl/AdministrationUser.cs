using DataAccess.Repositories;
using DTO;
using Factory;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Controls;

namespace WinFormsApp
{
    public partial class AdministrationUser : UserControl
    {
        public AdministrationUser()
        {
            InitializeComponent();

        }
        void SetDatagrid()
        {
            DataGridView.CellContentClick += DataGridView_CellContentClick;
            DataGridViewButtonColumn buttonColumn = ControlForm.GetButtonColumn("Editar", "");
            buttonColumn.DefaultCellStyle = ControlForm.GetGridViewCellStyle(Color.FromArgb(249, 215, 2), Color.White);
            DataGridViewButtonColumn buttonColumn2 = ControlForm.GetButtonColumn("Eliminar", "");
            buttonColumn2.DefaultCellStyle = ControlForm.GetGridViewCellStyle(Color.Red, Color.White);
            DataGridView.Columns.Add(buttonColumn);
            DataGridView.Columns.Add(buttonColumn2);
        }
        private void toolStripButtonCategory_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            btnNew.Enabled = true;
            DataGridView = ControlForm.GetDatagrid();
            FrmFather = new FrmFather();
            CategoryUser category = categoryControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = category;
            SetDatagrid();
            this.Cursor = Cursors.WaitCursor;
            categoryControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            addControls(DataGridView);
            setCombo();
        }
        private void DataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = int.Parse(DataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString());
            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        Edit(FrmFather.UserControl, id);
                        break;
                        //editar
                    }
                case 1:
                    {
                        Delete(FrmFather.UserControl, id);
                        //eliminar
                        break;
                    }
            }
        }

        private void toolStripButtonProduct_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            btnNew.Enabled = true;

            DataGridView = ControlForm.GetDatagrid();
            FrmFather = new FrmFather();

            ProductUser product = productControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = product;
            SetDatagrid();
            this.Cursor = Cursors.WaitCursor;
            productControl.LoadGrid(DataGridView);

            this.Cursor = Cursors.Default;

            addControls(DataGridView);
            setCombo();

        }
        void setCombo()
        {
            var cols = Utilities<DataGridViewColumn>.GetValues(DataGridView);
            Utilities<DataGridViewColumn>.FillCombo(cols, cmbfields);
        }
        private void toolStripButtonUnitMeasurement_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            UnitMeasurementUser unitMeasurement = unitMeasurementControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = unitMeasurement;
            SetDatagrid();
            this.Cursor = Cursors.WaitCursor;
            unitMeasurementControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            addControls(DataGridView);
            setCombo();
        }
        private void toolStripButtonWarehouse_Click(object sender, EventArgs e)
        {

            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            WarehouseUser warehouse = warehouseControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = warehouse;
            SetDatagrid();
            this.Cursor = Cursors.WaitCursor;
            warehouseControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            addControls(DataGridView);
            setCombo();
        }
        private void toolStripButtonRole_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            RoleUser role = roleControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = role;
            SetDatagrid();
            this.Cursor = Cursors.WaitCursor;
            roleControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            addControls(DataGridView);
            setCombo();
        }
        private void toolStripButtonClient_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            ClientUser client = clientControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = client;
            SetDatagrid();
            this.Cursor = Cursors.WaitCursor;
            clientControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            addControls(DataGridView);
            setCombo();
        }
        private void toolStripButtonEmployee_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            EmployeeUser employee = employeeControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = employee;
            SetDatagrid();
            this.Cursor = Cursors.WaitCursor;
            employeeControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            addControls(DataGridView);
            setCombo();
        }
        private void toolStripButtonCompany_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            CompanyUser companyUser = companyControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = companyUser;
            SetDatagrid();
            this.Cursor = Cursors.WaitCursor;
            companyControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            addControls(DataGridView);
            setCombo();

        }
        private void toolStripButtonProvider_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            ProviderUser provider = providerControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = provider;
            SetDatagrid();
            this.Cursor = Cursors.WaitCursor;
            providerControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            addControls(DataGridView);
            setCombo();
        }
        private void toolStripButtonTax_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            TaxUser tax = taxControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = tax;    
            SetDatagrid();
            this.Cursor = Cursors.WaitCursor;
            taxControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            addControls(DataGridView);
            setCombo();
        }


        void addControls(DataGridView dataGridView)
        {
            pnlDatagrid.Controls.Clear();
            pnlDatagrid.Controls.Add(dataGridView);
        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            if (FrmFather .UserControl is TaxUser)
            {
                TaxUser tax=(TaxUser )FrmFather .UserControl;
                tax.taxDTO = null;
                FrmFather .ShowDialog();
                taxControl.LoadGrid(DataGridView);
            }
            if (FrmFather.UserControl is ProviderUser)
            {
                ProviderUser provider = (ProviderUser)FrmFather.UserControl;
                provider.providerDTO = null;
                FrmFather.ShowDialog();
                providerControl.LoadGrid(DataGridView);
            }
            if (FrmFather.UserControl is CompanyUser)
            {
                CompanyUser company = (CompanyUser)FrmFather.UserControl;
                company.companyDTO = null;
                FrmFather.ShowDialog();
                companyControl.LoadGrid(DataGridView);
            }
            if (FrmFather.UserControl is CategoryUser)
            {
                CategoryUser categoryUser = (CategoryUser)FrmFather.UserControl;
                categoryUser.categoryDTO = null;

                FrmFather.ShowDialog();

                categoryControl.LoadGrid(DataGridView);
            }
            if (FrmFather.UserControl is ProductUser)
            {
                ProductUser product = (ProductUser)FrmFather.UserControl;
                product.productDTO = null;
                FrmFather.ShowDialog();
                productControl.LoadGrid(DataGridView);
            }
            if (FrmFather.UserControl is UnitMeasurementUser)
            {
                UnitMeasurementUser unitMeasurement = (UnitMeasurementUser)FrmFather.UserControl;
                unitMeasurement.unitMeasurementDTO = null;
                FrmFather.ShowDialog();
                unitMeasurementControl.LoadGrid(DataGridView);
            }
            if (FrmFather.UserControl is WarehouseUser)
            {
                WarehouseUser warehouse = (WarehouseUser)FrmFather.UserControl;
                warehouse.WarehouseDTO = null;
                FrmFather.ShowDialog();
                warehouseControl.LoadGrid(DataGridView);
            }
            if (FrmFather.UserControl is ClientUser)
            {
                ClientUser client = (ClientUser)FrmFather.UserControl;
                client.ClientDTO = null;
                FrmFather.ShowDialog();
                clientControl.LoadGrid(DataGridView);
            }
            if (FrmFather.UserControl is RoleUser)
            {
                RoleUser role = (RoleUser)FrmFather.UserControl;
                role.RoleDTO = null;
                FrmFather.ShowDialog();
                roleControl.LoadGrid(DataGridView);
            }
            if (FrmFather.UserControl is EmployeeUser)
            {
                EmployeeUser employee = (EmployeeUser)FrmFather.UserControl;
                employee.EmployeeDTO = null;
                FrmFather.ShowDialog();
                employeeControl.LoadGrid(DataGridView);
            }
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if (FrmFather.UserControl is ProviderUser)
            {
                providerControl.LoadGrid(DataGridView, cmbfields.Text, txtValue.Text);

            }
            if (FrmFather.UserControl is CompanyUser)
            {
                companyControl.LoadGrid(DataGridView, cmbfields.Text, txtValue.Text);

            }
            if (FrmFather.UserControl is CategoryUser)
            {
                categoryControl.LoadGrid(DataGridView, cmbfields.Text, txtValue.Text);
            }
            if (FrmFather.UserControl is ProductUser)
            {
                productControl.LoadGrid(DataGridView, cmbfields.Text, txtValue.Text);
            }
            if (FrmFather.UserControl is UnitMeasurementUser)
            {
                unitMeasurementControl.LoadGrid(DataGridView, cmbfields.Text, txtValue.Text);
            }
            if (FrmFather.UserControl is WarehouseUser)
            {
                warehouseControl.LoadGrid(DataGridView, cmbfields.Text, txtValue.Text);
            }
            if (FrmFather.UserControl is ClientUser)
            {
                clientControl.LoadGrid(DataGridView, cmbfields.Text, txtValue.Text);
            }
            if (FrmFather.UserControl is RoleUser)
            {
                roleControl.LoadGrid(DataGridView, cmbfields.Text, txtValue.Text);
            }
            if (FrmFather.UserControl is EmployeeUser)
            {
                employeeControl.LoadGrid(DataGridView, cmbfields.Text, txtValue.Text);
            }
            if (FrmFather.UserControl is TaxUser)
            {
                taxControl.LoadGrid(DataGridView,cmbfields.Text ,txtValue .Text);
            }
        }
            void Delete(UserControl UserControl, int id)
        {
            var resp = MessageBox.Show("Eliminar registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                if (UserControl is CategoryUser)
                {
                    categoryRepository.DeleteById(id);
                    categoryControl.LoadGrid(DataGridView);

                }
                if (UserControl is ProductUser)
                {
                    productRepository.DeleteById(id);
                    categoryControl.LoadGrid(DataGridView);
                }
                if (UserControl is UnitMeasurementUser)
                {
                    unitMeasurementRepository.DeleteById(id);
                    unitMeasurementControl.LoadGrid(DataGridView);
                }
                if (UserControl is WarehouseUser)
                {
                    warehouseRepository.DeleteById(id);
                    warehouseControl.LoadGrid(DataGridView);
                }
                if (UserControl is ClientUser)
                {
                    clientRepository.DeleteById(id);
                    clientControl.LoadGrid(DataGridView);
                }
                if (UserControl is RoleUser)
                {
                    roleRepository.DeleteById(id);
                    roleControl.LoadGrid(DataGridView);
                }
                if (UserControl is EmployeeUser)
                {
                    EmployeeDTO employeeDTO = employeeRepository.GetById(id);
                    userRepository.DeleteById(employeeDTO.UserId);
                    employeeControl.LoadGrid(DataGridView);
                }
                if (UserControl is CompanyUser)
                {
                    companyRepository.DeleteById(id);
                    companyControl.LoadGrid(DataGridView);
                }
                if (UserControl is ProviderUser)
                {
                    providerRepository.DeleteById(id);
                    providerControl.LoadGrid(DataGridView);
                }
                if (UserControl is TaxUser)
                {
                    TaxRepository.DeleteById(id);
                    taxControl.LoadGrid(DataGridView);  

                }
            }
        }
        void Edit(UserControl UserControl, int id)
        {
            if (UserControl is TaxUser)
            {
                TaxDTO taxDTO=TaxRepository.GetById(id);
                TaxUser tax=taxControl.GetControlUser(taxDTO,FrmFather);
                FrmFather.UserControl =tax;
                FrmFather.ShowDialog ();
                taxControl.LoadGrid (DataGridView);
            }
            if (UserControl is ProviderUser)
            {
                ProviderDTO providerDTO = providerRepository.GetById(id);
                ProviderUser provider = providerControl.GetControlUser(providerDTO, FrmFather);
                FrmFather.UserControl = provider;
                FrmFather.ShowDialog();
                providerControl.LoadGrid(DataGridView);
            }
            if (UserControl is CompanyUser)
            {
                CompanyDTO companyDTO = companyRepository.GetById(id);
                CompanyUser company = companyControl.GetControlUser(companyDTO, FrmFather);
                FrmFather.UserControl = company;
                FrmFather.ShowDialog();
                companyControl.LoadGrid(DataGridView);
            }
            if (UserControl is EmployeeUser)
            {
                EmployeeDTO employeeDTO = employeeRepository.GetById(id);
                EmployeeUser employee = employeeControl.GetControlUser(employeeDTO, FrmFather);
                FrmFather.UserControl = employee;
                FrmFather.ShowDialog();
                employeeControl.LoadGrid(DataGridView);
            }
            if (UserControl is CategoryUser)
            {
                CategoryDTO categoryDTO = categoryRepository.GetById(id);
                CategoryUser category = categoryControl.GetControlUser(categoryDTO, FrmFather);
                FrmFather.UserControl = category;
                FrmFather.ShowDialog();
                categoryControl.LoadGrid(DataGridView);
            }
            if (UserControl is ProductUser)
            {
                ProductDTO productDTO = productRepository.GetById(id);
                ProductUser product = productControl.GetControlUser(productDTO, FrmFather);
                FrmFather.UserControl = product;
                FrmFather.ShowDialog();
                productControl.LoadGrid(DataGridView);
            }
            if (UserControl is UnitMeasurementUser)
            {
                UnitMeasurementDTO unitMeasurementDTO = unitMeasurementRepository.GetById(id);
                UnitMeasurementUser unitMeasurement = unitMeasurementControl.GetControlUser(unitMeasurementDTO, FrmFather);
                FrmFather.UserControl = unitMeasurement;
                FrmFather.ShowDialog();
                unitMeasurementControl.LoadGrid(DataGridView);
            }
            if (UserControl is WarehouseUser)
            {
                WarehouseDTO WarehouseDTO = warehouseRepository.GetById(id);

                WarehouseUser warehouse = warehouseControl.GetControlUser(WarehouseDTO, FrmFather);
                FrmFather.UserControl = warehouse;
                FrmFather.ShowDialog();
                warehouseControl.LoadGrid(DataGridView);
            }
            if (UserControl is ClientUser)
            {
                ClientDTO ClientDTO = clientRepository.GetById(id);

                ClientUser client = clientControl.GetControlUser(ClientDTO, FrmFather);
                FrmFather.UserControl = client;
                FrmFather.ShowDialog();
                clientControl.LoadGrid(DataGridView);
            }
            if (FrmFather.UserControl is RoleUser)
            {
                RoleDTO roleDTO = roleRepository.GetById(id);
                RoleUser role = roleControl.GetControlUser(roleDTO, FrmFather);
                FrmFather.UserControl = role;
                FrmFather.ShowDialog();
                roleControl.LoadGrid(DataGridView);

            }

        }
        private void cmbfields_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtValue.Clear();
            txtValue.Focus();
        }



        private void AdministrationUser_Load(object sender, EventArgs e)
        {
            providerControl = new ProviderControl
            {
                providerRepository = providerRepository,
                identificationTypeRepository = IdentificationTypeRepository,
            };
            employeeControl = new EmployeeControl
            {
                companyRepository = companyRepository,
                userRepository = userRepository,
                employeeRepository = employeeRepository,
                identificationTypeRepository = IdentificationTypeRepository,
                roleRepository = roleRepository,
            };
            clientControl = new ClientControl
            {
                clientRepository = clientRepository,
                identificationTypeRepository = IdentificationTypeRepository
            };
            roleControl = new RoleControl { roleRepository = roleRepository };
            categoryControl = new CategoryControl { categoryRepository = categoryRepository };
            warehouseControl = new WarehouseControl
            {
                productRepository = productRepository,
                stockRepository = StockRepository,
                warehouseRepository = warehouseRepository,
            };
            productControl = new ProductControl
            {
                productRepository = productRepository,
                pictureRepository = pictureRepository,
                categoryRepository = categoryRepository,
                unitMeasurementRepository = unitMeasurementRepository,
                warehouseRepository = warehouseRepository,
                stockRepository = StockRepository,
            };
            unitMeasurementControl = new UnitMeasurementControl
            {
                unitMeasurementRepository = unitMeasurementRepository,
            };
            companyControl = new CompanyControl
            {
                companyRepository = companyRepository,
                regimenTypeRepository = RegimenTypeRepository
            };
            taxControl = new TaxControl
            {
                taxRepository =TaxRepository,
            };
        }     
    }
}
