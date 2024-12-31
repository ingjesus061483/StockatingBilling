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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp
{
    public partial class BillingAdministrationUser : UserControl
    {
        IQueryable<BillHeaderDTO> billHeaderDTOs;
        public StateRepository StateRepository { get; set; }
        public DocumentTypeRepository DocumetTypeRepository { get; set; }
        public ClientRepository ClientRepository { get; set; }
        public EmployeeRepository EmployeeRepository { get; set; }
        public ProductRepository ProductRepository { get; set; }
        public BillingRepository BillingRepository { get; set; }
        public WarehouseRepository WarehouseRepository { get; set; }
        public StockRepository StockRepository { get; set; }
        public Form frmMain { get; set; }
        string[] arr = ["Id", "Name"];

        public BillingAdministrationUser()
        {
            InitializeComponent();
        }
        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            frmMain.Close();
        }

        private void BillingUser_Load(object sender, EventArgs e)
        {
            Utilities<StateDTO>.FillCombo(StateRepository.Values.ToList(), arr, cmbState);
            cmbState.SelectedIndex = 0;
            Loadgrid();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            FrmFather frmFather = GetFrmFather(null,1);
            frmFather.ShowDialog();
            Loadgrid();
        }
        void Loadgrid()
        {
            int.TryParse(cmbState.SelectedValue != null ? cmbState.SelectedValue.ToString() : string.Empty, out int state);
            billHeaderDTOs = chkPeriodo.Checked ? BillingRepository.Values.Where(x => (x.Date >= dtpDateStar.Value && x.Date <= dtpDateEnd.Value)).
                Where(x => x.StateId == state && x.Code.Contains(txtCode.Text)) : BillingRepository.Values.Where(x => x.StateId == state && x.Code.Contains(txtCode.Text));
            dgBilling.DataSource = billHeaderDTOs.Select(x => new
            {
                x.Id,
                Codigo = x.Code,
                TipoDocumento = x.DocumentType.Name,
                Fecha = x.Date,
                Cliente = x.Client.Name + " " + x.Client.LastName,
                Empleado = x.Employee.Name + " " + x.Employee.LastName,
                Credito = x.Credit ? "Si" : "No",
                Estado = x.State.Name,
                x.Total
            }).ToList();
            txtTotal.Text = billHeaderDTOs.Where (x=>x.StateId==3). Select(x => new
            {
                x.Id,
                Codigo = x.Code,
                tipoDocumento = x.DocumentType.Name,
                Fecha = x.Date,
                Cliente = x.Client.Name + " " + x.Client.LastName,
                Empleado = x.Employee.Name + "" + x.Employee.LastName,
                Credito = x.Credit ? "Si" : "No",
                Estado = x.State.Name,
                x.Total
            }).ToList().Sum(x => x.Total).ToString();
        }

        private void chkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateEnd.Enabled = chkPeriodo.Checked;
            dtpDateStar.Enabled = chkPeriodo.Checked;
            Loadgrid();
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            Loadgrid();
        }

        private void cmbState_SelectedValueChanged(object sender, EventArgs e)
        {
            Loadgrid();
        }

        private void dtpDateStar_ValueChanged(object sender, EventArgs e)
        {
            Loadgrid();
        }

        private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
        {
            Loadgrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = int.Parse(dgBilling.Rows[e.RowIndex].Cells["id"].Value.ToString());
            BillHeaderDTO billHeaderDTO = BillingRepository.GetById(id);
            switch (e.ColumnIndex)
            {
                //imprimir
                case 0:
                    {
                        BillingRepository.Print(billHeaderDTO);
                        break;
                    }
                //entregar
                case 1:
                    {
                        if(billHeaderDTO.StateId !=1)
                        {
                            ControlForm.GetMessage("El producto ya ha sido entregado", "", MessageBoxButtons.OK,
                                                                                  MessageBoxIcon.Information);
                            return;
                        }
                        var resp = MessageBox.Show("Entregar productos?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resp == DialogResult.No)
                        {
                            return;
                        }
                        BillingRepository.DeliveryProduct(billHeaderDTO);                        
                        BillingRepository .Update (billHeaderDTO ,id);
                        ControlForm.GetMessage("El producto ha sido entregado", "", MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information);
                        break;
                    }
                //Eliminar
                case 2:
                    {
                        if (billHeaderDTO.StateId != 1)
                        {
                            ControlForm.GetMessage("Solo pueden eliminarse facturas en proceso", "", MessageBoxButtons.OK,
                                                    MessageBoxIcon.Exclamation);
                            return;
                        }
                        var resp = MessageBox.Show("Eliminar Factura?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resp == DialogResult.Yes)
                        {
                          
                            BillingRepository.DeleteById(id);
                        }
                        break ;
                    }
                //ver
                case 3:
                    {
                        FrmFather frmFather = GetFrmFather(billHeaderDTO,1);
                        frmFather .ShowDialog();
                        break;
                    }                    
               //pagar
               case 4:
                    {
                        if (billHeaderDTO.StateId == 1)
                        {
                            BillingRepository.DeliveryProduct(billHeaderDTO);
                            BillingRepository.Update(billHeaderDTO, id);
                        }
                        if (billHeaderDTO.StateId == 2 || billHeaderDTO.StateId == 4)
                        {
                            FrmFather frmFather = GetFrmFather(billHeaderDTO, 2);
                            frmFather.ShowDialog();
                        }
                        break;
                    }
            }
            Loadgrid();
        }

        private void toolStripButtonExcel_Click(object sender, EventArgs e)
        {   
            this.Cursor= Cursors.WaitCursor;
            Array  array= billHeaderDTOs.Select(x => new
            {
                x.Id,
                Codigo = x.Code,
                tipoDocumento = x.DocumentType.Name,
                Fecha = x.Date,
                Cliente = x.Client.Name + " " + x.Client.LastName,
                Empleado = x.Employee.Name + " " + x.Employee.LastName,
                Credito = x.Credit ? "Si" : "No",
                Estado = x.State.Name,
                x.Total
            }).ToArray();
            if(array .Length <=0)
            {
                ControlForm.GetMessage("No se muestra informacion", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Cursor = Cursors.Default;
                return;
            }
            Dictionary<string, Array> keyValues = new Dictionary<string, Array>()
            {
                {"Ventas",array  }
            };
            BillingRepository.Export(keyValues  );
            this.Cursor= Cursors.Default;
        }
        FrmFather GetFrmFather(BillHeaderDTO billHeaderDTO,int control )
        {
            FrmFather frmFather = new();

            switch (control )
            {
                case 1:
                    {
                        BillingUser BillingUser = new()
                        {
                           Form = frmFather,
                            DocumetTypeRepository = DocumetTypeRepository,
                            EmployeeRepository = EmployeeRepository,
                            ClientRepository = ClientRepository,
                            ProductRepository = ProductRepository,
                            BillingRepository = BillingRepository,
                            WarehouseRepository = WarehouseRepository,
                            StockRepository = StockRepository,
                            BillHeaderDTO = billHeaderDTO
                        };
                        frmFather.UserControl = BillingUser;
                        break;
                    }
                case 2:
                    {
                        PaymentUser PaymentUser = new();
                        frmFather .UserControl = PaymentUser;
                        break;
                    }
            }
            return frmFather;
        }
    }
}
