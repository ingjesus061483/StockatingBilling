using DataAccess.Repositories;
using DTO;
using Factory;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        DataGridViewButtonColumn[] SetButtonColumn(string[] buttons, Dictionary<int, Color[]> pairs)
        {
            DataGridViewButtonColumn[] dataGridViewButtonColumns = new DataGridViewButtonColumn[buttons.Length];
            for (int i = 0; i < buttons.Length; i++)
            {
                Color[] colors = pairs[i];
                DataGridViewButtonColumn buttonColumn = ControlForm.GetButtonColumn(buttons[i], "");
                buttonColumn.DefaultCellStyle = ControlForm.GetGridViewCellStyle(colors[0], colors[1]);
                dataGridViewButtonColumns[i] = buttonColumn;
            }
            return dataGridViewButtonColumns;
        }
        void SetDatagrid(DataGridView gridView, DataGridViewColumn[] dataGridViewColumns)
        {
            gridView.CellContentClick += DataGridView_CellContentClick;
            gridView.Columns.AddRange(dataGridViewColumns);

        }
        void AddControls(DataGridView gridView)
        {
            pnlDatagrid.Controls.Clear();
            pnlDatagrid.Controls.Add(gridView);
        }
        void SetCombo(DataGridView gridView)
        {
            var cols = Utilities<DataGridViewColumn>.GetValues(gridView);
            Utilities<DataGridViewColumn>.FillCombo(cols, cmbfields);
        }
        void Delete(UserControl UserControl, int id)
        {
            var resp = MessageBox.Show("Eliminar registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                switch (UserControl)
                {
                    case CategoryUser:
                        {
                            categoryRepository.DeleteById(id);
                            categoryControl.LoadGrid(DataGridView);
                            break;
                        }
                    case ProductUser:
                        {
                            productRepository.DeleteById(id);
                            productControl.LoadGrid(DataGridView);
                            break;
                        }
                    case UnitMeasurementUser:
                        {
                            unitMeasurementRepository.DeleteById(id);
                            unitMeasurementControl.LoadGrid(DataGridView);
                            break;
                        }
                    case WarehouseUser:
                        {
                            warehouseRepository.DeleteById(id);
                            warehouseControl.LoadGrid(DataGridView);
                            break;
                        }
                    case ClientUser:
                        {
                            clientRepository.DeleteById(id);
                            clientControl.LoadGrid(DataGridView);
                            break;
                        }
                    case RoleUser:
                        {
                            roleRepository.DeleteById(id);
                            roleControl.LoadGrid(DataGridView);
                            break;
                        }
                    case EmployeeUser:
                        {
                            EmployeeDTO employeeDTO = employeeRepository.GetById(id);
                            userRepository.DeleteById(employeeDTO.UserId);
                            employeeControl.LoadGrid(DataGridView);
                            break;
                        }
                    case CompanyUser:
                        {
                            companyRepository.DeleteById(id);
                            companyControl.LoadGrid(DataGridView);
                            break;
                        }
                    case ProviderUser:
                        {
                            providerRepository.DeleteById(id);
                            providerControl.LoadGrid(DataGridView);
                            break;
                        }
                    case TaxUser:
                        {
                            TaxRepository.DeleteById(id);
                            taxControl.LoadGrid(DataGridView);
                            break;
                        }
                }
            }
        }
        void New(FrmFather frmFather)
        {
            switch (frmFather.UserControl)
            {
                case TaxUser:
                    {
                        TaxUser tax = (TaxUser)frmFather.UserControl;
                        tax.taxDTO = null;
                        frmFather.ShowDialog();
                        taxControl.LoadGrid(DataGridView);
                        break;
                    }
                case ProviderUser:
                    {
                        ProviderUser provider = (ProviderUser)frmFather.UserControl;
                        provider.providerDTO = null;
                        frmFather.ShowDialog();
                        providerControl.LoadGrid(DataGridView);
                        break;
                    }
                case CompanyUser:
                    {
                        CompanyUser company = (CompanyUser)frmFather.UserControl;
                        company.companyDTO = null;
                        frmFather.ShowDialog();
                        companyControl.LoadGrid(DataGridView);
                        break;
                    }
                case CategoryUser:
                    {
                        CategoryUser categoryUser = (CategoryUser)frmFather.UserControl;
                        categoryUser.categoryDTO = null;
                        frmFather.ShowDialog();
                        categoryControl.LoadGrid(DataGridView);
                        break;
                    }
                case ProductUser:
                    {
                        ProductUser product = (ProductUser)frmFather.UserControl;
                        product.productDTO = null;
                        frmFather.ShowDialog();
                        productControl.LoadGrid(DataGridView);
                        break;
                    }
                case UnitMeasurementUser:
                    {
                        UnitMeasurementUser unitMeasurement = (UnitMeasurementUser)frmFather.UserControl;
                        unitMeasurement.unitMeasurementDTO = null;
                        frmFather.ShowDialog();
                        unitMeasurementControl.LoadGrid(DataGridView);
                        break;
                    }
                case WarehouseUser:
                    {
                        WarehouseUser warehouse = (WarehouseUser)frmFather.UserControl;
                        warehouse.WarehouseDTO = null;
                        frmFather.ShowDialog();
                        warehouseControl.LoadGrid(DataGridView);
                        break;
                    }
                case ClientUser:
                    {
                        ClientUser client = (ClientUser)frmFather.UserControl;
                        client.ClientDTO = null;
                        frmFather.ShowDialog();
                        clientControl.LoadGrid(DataGridView);
                        break;
                    }
                case RoleUser:
                    {
                        RoleUser role = (RoleUser)frmFather.UserControl;
                        role.RoleDTO = null;
                        frmFather.ShowDialog();
                        roleControl.LoadGrid(DataGridView);
                        break;
                    }
                case EmployeeUser:
                    {
                        EmployeeUser employee = (EmployeeUser)frmFather.UserControl;
                        employee.EmployeeDTO = null;
                        frmFather.ShowDialog();
                        employeeControl.LoadGrid(DataGridView);
                        break;
                    }
            }
        }
        void Search(DataGridView gridView, UserControl userControl, string filter, string searchText)
        {
            switch (userControl)
            {
                case ProviderUser:
                    {
                        providerControl.LoadGrid(gridView, filter, searchText);
                        break;
                    }
                case CompanyUser:
                    {
                        companyControl.LoadGrid(gridView, filter, searchText);
                        break;

                    }
                case CategoryUser:
                    {
                        categoryControl.LoadGrid(gridView, filter, searchText);
                        break;

                    }
                case ProductUser:
                    {
                        productControl.LoadGrid(gridView, filter, searchText);
                        break;
                    }
                case UnitMeasurementUser:
                    {
                        unitMeasurementControl.LoadGrid(gridView, filter, searchText);
                        break;

                    }
                case WarehouseUser:
                    {
                        warehouseControl.LoadGrid(gridView, filter, searchText);
                        break;
                    }
                case ClientUser:
                    {
                        clientControl.LoadGrid(gridView, filter, searchText);
                        break;
                    }
                case RoleUser:
                    {
                        roleControl.LoadGrid(gridView, filter, searchText);
                        break;
                    }
                case EmployeeUser:
                    {
                        employeeControl.LoadGrid(gridView, filter, searchText);
                        break;
                    }
                case TaxUser:
                    {
                        taxControl.LoadGrid(gridView, filter, searchText);
                        break;

                    }
                case StockUser:
                    {
                        productControl.LoadGrid(gridView, filter, searchText);
                        break;
                    }
            }
        }
        void Edit(FrmFather frmFather, int id)
        {
            switch (frmFather.UserControl)
            {
                case TaxUser:
                    {
                        TaxDTO taxDTO = TaxRepository.GetById(id);
                        TaxUser tax = taxControl.GetControlUser(taxDTO, FrmFather);
                        frmFather.UserControl = tax;
                        frmFather.ShowDialog();
                        taxControl.LoadGrid(DataGridView);
                        break;
                    }
                case ProviderUser:
                    {
                        ProviderDTO providerDTO = providerRepository.GetById(id);
                        ProviderUser provider = providerControl.GetControlUser(providerDTO, FrmFather);
                        frmFather.UserControl = provider;
                        frmFather.ShowDialog();
                        providerControl.LoadGrid(DataGridView);
                        break;
                    }
                case CompanyUser:
                    {
                        CompanyDTO companyDTO = companyRepository.GetById(id);
                        CompanyUser company = companyControl.GetControlUser(companyDTO, FrmFather);
                        frmFather.UserControl = company;
                        frmFather.ShowDialog();
                        companyControl.LoadGrid(DataGridView);
                        break;
                    }
                case EmployeeUser:
                    {
                        EmployeeDTO employeeDTO = employeeRepository.GetById(id);
                        EmployeeUser employee = employeeControl.GetControlUser(employeeDTO, FrmFather);
                        frmFather.UserControl = employee;
                        frmFather.ShowDialog();
                        employeeControl.LoadGrid(DataGridView);
                        break;
                    }
                case CategoryUser:
                    {
                        CategoryDTO categoryDTO = categoryRepository.GetById(id);
                        CategoryUser category = categoryControl.GetControlUser(categoryDTO, FrmFather);
                        frmFather.UserControl = category;
                        frmFather.ShowDialog();
                        categoryControl.LoadGrid(DataGridView);
                        break;
                    }
                case ProductUser:
                    {
                        ProductDTO productDTO = productRepository.GetById(id);
                        ProductUser product = productControl.GetControlUser(productDTO, FrmFather);
                        frmFather.UserControl = product;
                        frmFather.ShowDialog();
                        productControl.LoadGrid(DataGridView);
                        break;

                    }
                case UnitMeasurementUser:
                    {
                        UnitMeasurementDTO unitMeasurementDTO = unitMeasurementRepository.GetById(id);
                        UnitMeasurementUser unitMeasurement = unitMeasurementControl.GetControlUser(unitMeasurementDTO, FrmFather);
                        frmFather.UserControl = unitMeasurement;
                        frmFather.ShowDialog();
                        unitMeasurementControl.LoadGrid(DataGridView);
                        break;
                    }
                case WarehouseUser:
                    {
                        WarehouseDTO WarehouseDTO = warehouseRepository.GetById(id);
                        WarehouseUser warehouse = warehouseControl.GetControlUser(WarehouseDTO, FrmFather);
                        frmFather.UserControl = warehouse;
                        frmFather.ShowDialog();
                        warehouseControl.LoadGrid(DataGridView);
                        break;
                    }
                case ClientUser:
                    {
                        ClientDTO ClientDTO = clientRepository.GetById(id);
                        ClientUser client = clientControl.GetControlUser(ClientDTO, FrmFather);
                        frmFather.UserControl = client;
                        frmFather.ShowDialog();
                        clientControl.LoadGrid(DataGridView);
                        break;
                    }
                case RoleUser:
                    {
                        RoleDTO roleDTO = roleRepository.GetById(id);
                        RoleUser role = roleControl.GetControlUser(roleDTO, FrmFather);
                        frmFather.UserControl = role;
                        frmFather.ShowDialog();
                        roleControl.LoadGrid(DataGridView);
                        break;
                    }
            }
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
                        Edit(FrmFather, id);
                        break;
                    }
                case 1:
                    {
                        Delete(FrmFather.UserControl, id);
                        break;
                    }
                case 2:
                    {
                        if (FrmFather.UserControl is ProductUser)
                        {            FrmFather = new();

                            StockUser stockUser = new()
                            {
                                Form = FrmFather,
                                ProductDTO = productRepository.GetById(id),
                                Repository = StockRepository,
                                WarehouseRepository = warehouseRepository
                            };
                            FrmFather.UserControl = stockUser;
                            FrmFather.ShowDialog();
                            productControl.LoadGrid(DataGridView);
                            FrmFather.UserControl = productControl.GetControlUser(null, FrmFather);                           
                        } 
                        break;
                    }
                case 3: 
                    {
                        if (FrmFather.UserControl is ProductUser)
                        {
                            FrmFather = new();

                            ViewProductUser ViewProductUser = new()
                            {
                                Form = FrmFather,
                                ProductDTO = productRepository.GetById(id),
                                StockRepository = StockRepository,
                                PictureRepository = pictureRepository,
                                WarehouseRepository = warehouseRepository
                            };
                            FrmFather.UserControl = ViewProductUser;
                            FrmFather.ShowDialog();
                            productControl.LoadGrid(DataGridView);
                            FrmFather.UserControl = productControl.GetControlUser(null, FrmFather);
                        }
                        break ;
                    }


            }
        }
        private void toolStripButtonCategory_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            btnNew.Enabled = true;
            DataGridView = ControlForm.GetDatagrid();
            FrmFather = new FrmFather();
            CategoryUser category = categoryControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = category;
            string[] buttons = { "Editar", "Eliminar" };
            Dictionary<int, Color[]> pairs = new Dictionary<int, Color[]>
            {
                {0,[Color.Yellow,Color.Black ] },
                {1,[Color.Red ,Color.White ] }
            };
            SetDatagrid(DataGridView, SetButtonColumn(buttons, pairs));
            this.Cursor = Cursors.WaitCursor;
            categoryControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            AddControls(DataGridView);
            SetCombo(DataGridView);
        }
        private void toolStripButtonProduct_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            btnNew.Enabled = true;
            DataGridView = ControlForm.GetDatagrid();
            FrmFather = new FrmFather();
            ProductUser product = productControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = product;
            string[] buttons = { "Editar", "Eliminar", "Existencias","Ver detalle de producto" };
            Dictionary<int, Color[]> pairs = new Dictionary<int, Color[]>
            {
                {0,[Color.Yellow,Color.Black ] },
                {1,[Color.Red ,Color.White ] },
                {2,[Color.Blue ,Color.White  ] },
                {3,[Color .Silver ,Color.Black ] }
            };
            SetDatagrid(DataGridView, SetButtonColumn(buttons, pairs)); this.Cursor = Cursors.WaitCursor;
            productControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            AddControls(DataGridView);
            SetCombo(DataGridView);
        }
        private void toolStripButtonUnitMeasurement_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            UnitMeasurementUser unitMeasurement = unitMeasurementControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = unitMeasurement;
            string[] buttons = { "Editar", "Eliminar" };
            Dictionary<int, Color[]> pairs = new Dictionary<int, Color[]>
            {
                {0,[Color.Yellow,Color.Black ] },
                {1,[Color.Red ,Color.White ] }
            };
            SetDatagrid(DataGridView, SetButtonColumn(buttons, pairs)); this.Cursor = Cursors.WaitCursor;
            unitMeasurementControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            AddControls(DataGridView);
            SetCombo(DataGridView);
        }
        private void toolStripButtonWarehouse_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            WarehouseUser warehouse = warehouseControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = warehouse;
            string[] buttons = { "Editar", "Eliminar" };
            Dictionary<int, Color[]> pairs = new Dictionary<int, Color[]>
            {
                {0,[Color.Yellow,Color.Black ] },
                {1,[Color.Red ,Color.White ] }
            };
            SetDatagrid(DataGridView, SetButtonColumn(buttons, pairs));
            this.Cursor = Cursors.WaitCursor;
            warehouseControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            AddControls(DataGridView);
            SetCombo(DataGridView);
        }
        private void toolStripButtonRole_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            RoleUser role = roleControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = role;
            string[] buttons = { "Editar", "Eliminar" };
            Dictionary<int, Color[]> pairs = new Dictionary<int, Color[]>
            {
                {0,[Color.Yellow,Color.Black ] },
                {1,[Color.Red ,Color.White ] }
            };
            SetDatagrid(DataGridView, SetButtonColumn(buttons, pairs));
            this.Cursor = Cursors.WaitCursor;
            roleControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            AddControls(DataGridView);
            SetCombo(DataGridView);
        }
        private void toolStripButtonClient_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            ClientUser client = clientControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = client;
            string[] buttons = { "Editar", "Eliminar" };
            Dictionary<int, Color[]> pairs = new Dictionary<int, Color[]>
            {
                {0,[Color.Yellow,Color.Black ] },
                {1,[Color.Red ,Color.White ] }
            };
            SetDatagrid(DataGridView, SetButtonColumn(buttons, pairs));
            this.Cursor = Cursors.WaitCursor;
            clientControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            AddControls(DataGridView);
            SetCombo(DataGridView);
        }
        private void toolStripButtonEmployee_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            EmployeeUser employee = employeeControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = employee;
            string[] buttons = { "Editar", "Eliminar" };
            Dictionary<int, Color[]> pairs = new Dictionary<int, Color[]>
            {
                {0,[Color.Yellow,Color.Black ] },
                {1,[Color.Red ,Color.White ] }
            };
            SetDatagrid(DataGridView, SetButtonColumn(buttons, pairs));
            this.Cursor = Cursors.WaitCursor;
            employeeControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            AddControls(DataGridView);
            SetCombo(DataGridView);
        }
        private void toolStripButtonCompany_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            CompanyUser companyUser = companyControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = companyUser;
            string[] buttons = { "Editar", "Eliminar" };
            Dictionary<int, Color[]> pairs = new Dictionary<int, Color[]>
            {
                {0,[Color.Yellow,Color.Black ] },
                {1,[Color.Red ,Color.White ] }
            };
            SetDatagrid(DataGridView, SetButtonColumn(buttons, pairs));
            this.Cursor = Cursors.WaitCursor;
            companyControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            AddControls(DataGridView);
            SetCombo(DataGridView);
        }
        private void toolStripButtonProvider_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            ProviderUser provider = providerControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = provider;
            string[] buttons = { "Editar", "Eliminar" };
            Dictionary<int, Color[]> pairs = new Dictionary<int, Color[]>
            {
                {0,[Color.Yellow,Color.Black ] },
                {1,[Color.Red ,Color.White ] }
            };
            SetDatagrid(DataGridView, SetButtonColumn(buttons, pairs));
            this.Cursor = Cursors.WaitCursor;
            providerControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            AddControls(DataGridView);
            SetCombo(DataGridView);
        }
        private void toolStripButtonTax_Click(object sender, EventArgs e)
        {
            DataGridView = null;
            DataGridView = ControlForm.GetDatagrid();
            btnNew.Enabled = true;
            FrmFather = new FrmFather();
            TaxUser tax = taxControl.GetControlUser(null, FrmFather);
            FrmFather.UserControl = tax;
            string[] buttons = { "Editar", "Eliminar" };
            Dictionary<int, Color[]> pairs = new Dictionary<int, Color[]>
            {
                {0,[Color.Yellow,Color.Black ] },
                {1,[Color.Red ,Color.White ] }
            };
            SetDatagrid(DataGridView, SetButtonColumn(buttons, pairs));
            this.Cursor = Cursors.WaitCursor;
            taxControl.LoadGrid(DataGridView);
            this.Cursor = Cursors.Default;
            AddControls(DataGridView);
            SetCombo(DataGridView);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            New(FrmFather);
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            Search(DataGridView, FrmFather.UserControl, cmbfields.Text, txtValue.Text);
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
                taxRepository = TaxRepository,
            };
            toolStripButtonRole.PerformClick();
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            FrmMain.Close();
        }

        
    }
}
