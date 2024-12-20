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
     public CompanyDTO companyDTO { get; set; }
        public CompanyRepository CompanyRepository { get; set; }
        public RegimenTypeRepository RegimenTypeRepository { get; set; }
        public Form Form { get; set; }
        public CompanyUser()
        {
            InitializeComponent();
        }
        public void NewCompany()
        {       
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
            Utilities<RegimentypeDTO>.FillCombo(RegimenTypeRepository.Values.ToList(), arr, cmbRegimeType);
            if (companyDTO != null)
            {
                txtAddress.Text = companyDTO.Address;
                txtContact.Text = companyDTO.Contact;
                txtEmail.Text = companyDTO.Email;
                txtName.Text = companyDTO.Name;
                txtPhone.Text = companyDTO.Phone;
                txtNit.Text = companyDTO.Nit;
                txtSlogan.Text = companyDTO.Slogan;
                cmbRegimeType.SelectedValue = companyDTO.RegimenTypeId; 
                txtTradeCamera.Text = companyDTO.TradeCamera;
                return;
            }
            NewCompany();
            

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

      
    }
}
