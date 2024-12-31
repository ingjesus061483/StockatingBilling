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
    public partial class BillingUser : UserControl
    { 
        public Form Form { get; set; }   
        string[] arr = ["Id", "Name"];
        public BillHeaderDTO? BillHeaderDTO { get; set; }
        public DocumentTypeRepository DocumetTypeRepository { get; set; }
        public ClientRepository ClientRepository { get; set; }
        public EmployeeRepository EmployeeRepository { get; set; }
        public ProductRepository ProductRepository { get; set; }
        public BillingRepository BillingRepository { get; set; }
        public WarehouseRepository WarehouseRepository { get; set; }
        public StockRepository StockRepository { get; set; }
        public BillingUser()
        {
            InitializeComponent();
        }
        void BillingUser_Load(object sender, EventArgs e)
        {
            Utilities<DocumentTypeDTO>.FillCombo(DocumetTypeRepository.Values.ToList(), arr, cmbDocumentType);
            if (BillHeaderDTO != null)
            {
                txtCode.Text = BillHeaderDTO.Code;
                txtClient.Text = BillHeaderDTO.Client.Name + " " + BillHeaderDTO.Client.LastName;
                txtEmployee.Text = BillHeaderDTO.Employee.Name + " " + BillHeaderDTO.Employee.LastName;
                cmbDocumentType.SelectedValue = BillHeaderDTO.DocumentTypeId;
                chkCredit.Checked = BillHeaderDTO.Credit;
                dtpDate.Value = BillHeaderDTO.Date;
                TxtTotalPay.Text = BillHeaderDTO.Total.ToString();
                LoadGrid(BillHeaderDTO);
                return;
            }
            NewBilling();
        }
        void NewBilling()
        {
            BillHeaderDTO = new BillHeaderDTO();
            BillHeaderDTO.BillDetails = new List<BillDetail>();
            LoadGrid(BillHeaderDTO);
            txtCode.Text = DateTime.Now.ToOADate().ToString();
            BillHeaderDTO.Code= txtCode.Text;
            txtClient.Clear();
            txtEmployee.Clear();
            cmbDocumentType.SelectedIndex = -1;
            chkCredit.Checked = false;
            dtpDate.Value = DateTime.Now;
            TxtTotalPay.Clear();
            BillHeaderDTO.StateId = 1;
        }
        SearchUser SearchUser;
        private void btnClient_Click(object sender, EventArgs e)
        {
            FrmFather frmFather = ControlForm.GetFrmFather(ref SearchUser, ClientRepository.Values.ToList());

       frmFather .ShowDialog();
            ClientDTO clientDTO = ClientRepository.GetById(SearchUser.Id);
            BillHeaderDTO.ClientId = clientDTO != null ? clientDTO.Id : 0;
            txtClient.Text = clientDTO != null ? clientDTO.CompleteName : string.Empty;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FrmFather frmFather = ControlForm.GetFrmFather(ref SearchUser, EmployeeRepository.Values.ToList());
        frmFather .ShowDialog();
            EmployeeDTO employeeDTO = EmployeeRepository.GetById(SearchUser.Id);
            txtEmployee.Text = employeeDTO != null ? employeeDTO.CompleteName : string.Empty;
            BillHeaderDTO.EmployeeId = employeeDTO != null ? employeeDTO.Id : 0;

        }
        private void btnBilllDetail_Click(object sender, EventArgs e)
        {
            FrmFather frmFather = new();
            BillDetailUser detailUser = new()
            {
                Form = frmFather,
                BillingRepository = BillingRepository,
                ProductRepository = ProductRepository,
                WarehouseRepository = WarehouseRepository,
                BillHeaderDTO = BillHeaderDTO,
                Dock = DockStyle.Fill

            };
            frmFather.UserControl = detailUser;
            frmFather.ShowDialog();
            LoadGrid(BillHeaderDTO);

        }
        void LoadGrid(BillHeaderDTO billHeaderDTO)
        {
            dgDetail.DataSource = billHeaderDTO.BillDetails.Select(x => new
            {
                x.Id,
                cantidad = x.Amount,
                bodega = x.Warehouse != null ? x.Warehouse.Code + " - " + x.Warehouse.Name : WarehouseRepository.GetById(int.Parse(x.WarehouseId.ToString())).Reference,
                detalle = x.Product != null ? x.Product.Code + " - " + x.Product.Name : ProductRepository.GetById(x.ProductId).Reference,
                valorUnitario = x.UnitPrice,
                x.Total
            }).ToList();
            txtSubtotal.Text = billHeaderDTO.BillDetails.Sum(x => x.Total).ToString();
        }

        private void dgDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = int.Parse(dgDetail.Rows[e.RowIndex].Cells["id"].Value.ToString());
            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        if (BillHeaderDTO.StateId != 1)
                        {
                            ControlForm.GetMessage("El ya ha sido entrgado", "", MessageBoxButtons.OK,
                                                                                  MessageBoxIcon.Information);
                            return;
                        }

                        BillingRepository.RemoveDetail(BillHeaderDTO, id);
                        break;
                    }
            }
            LoadGrid(BillHeaderDTO);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BillHeaderDTO.DocumentTypeId = int.Parse(cmbDocumentType.SelectedValue.ToString());
            BillHeaderDTO.Credit = chkCredit.Checked;
            BillHeaderDTO.Remark = txtRemark.Text;
            BillHeaderDTO.Date = dtpDate.Value;
            BillingRepository.Save(BillHeaderDTO);
           Form .Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewBilling();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
          Form. Close();
        }
    }
}
