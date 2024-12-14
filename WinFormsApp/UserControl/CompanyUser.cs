using DataAccess.Repositories;
using DTO;
using Org.BouncyCastle.Asn1.Mozilla;
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
    public partial class CompanyUser : UserControl
    {
        string[] arr = ["Id", "Name"];
        CompanyDTO companyDTO;
        public CompanyRepository CompanyRepository { get; set; }
        public RegimenTypeRepository RegimenTypeRepository { get; set; }
        public DataGridView DataGridView { get; set; }
        public TextBox TxtValue { get; set; }
        public ComboBox CmbFilter { get; set; }
        public Form Form { get; set; }
        public CompanyUser()
        {
            InitializeComponent();
        }
        public void NewCompany()
        {
            DataGridView.DataSource = CompanyRepository.Values.Select(x => new
            {
                x.Id,
                x.Nit,
                Nombre = x.Name,
                Direccion = x.Address,
                Telefono = x.Phone,
                CamaraComercio = x.TradeCamera,
                x.Email,
                Contacto = x.Contact,
                TipoRegimen = x.RegimenType.Name,

            }).ToList();
            txtAddress.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtNit.Clear();
            txtSlogan.Clear();
            txtTradeCamera.Clear();
            txtNit.Focus();

        }
        private void CompanyUser_Load(object sender, EventArgs e)
        {
            DataGridView.CellContentClick += DataGridView_CellContentClick;
            TxtValue.TextChanged += TxtValue_TextChanged;
            Utilities<RegimentypeDTO>.FillCombo(RegimenTypeRepository.Values.ToList(), arr, cmbRegimeType);
            NewCompany();
            var cols = Utilities<DataGridViewColumn>.GetValues(DataGridView);
            Utilities<DataGridViewColumn>.FillCombo(cols, CmbFilter);


        }

        private void TxtValue_TextChanged(object? sender, EventArgs e)
        {
            DataGridView.DataSource = CompanyRepository.Values.Select(x => new
            {
                x.Id,
                x.Nit,
                Nombre = x.Name,
                Direccion = x.Address,
                Telefono = x.Phone,
                x.Email,
                CamaraComercio = x.TradeCamera,
                Contacto = x.Contact,
                TipoRegimen = x.RegimenType.Name,
            }).ToList().Where(z => Utilities<object>.GetValue(z, CmbFilter.Text, TxtValue.Text)).ToList();
        }

        private void DataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            NewCompany();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (companyDTO == null)
            {
                companyDTO = new CompanyDTO
                {
                    Name = txtName.Text,
                    Nit = txtNit.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    TradeCamera = txtTradeCamera.Text,
                    RegimenTypeId = int.Parse(cmbRegimeType.SelectedValue.ToString()),
                    Slogan = txtSlogan.Text,
                    Contact = txtContact.Text,
                    Email = txtEmail.Text,
                };
                CompanyRepository.Save(companyDTO);

            }
            else
            {
                companyDTO.Name = txtName.Text;
                companyDTO.Nit = txtNit.Text;
                companyDTO.Address = txtAddress.Text;
                companyDTO.Phone = txtPhone.Text;
                companyDTO.TradeCamera = txtTradeCamera.Text;
                companyDTO.RegimenTypeId = int.Parse(cmbRegimeType.SelectedValue.ToString());
                companyDTO.Slogan = txtSlogan.Text;
                companyDTO.Contact = txtContact.Text;
                companyDTO.Email = txtEmail.Text;
                CompanyRepository.Update(companyDTO, companyDTO.Id);
            }
            NewCompany();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (companyDTO == null)
            {
                return;
            }
            CompanyRepository.DeleteById (companyDTO.Id);
        }
    }
}
