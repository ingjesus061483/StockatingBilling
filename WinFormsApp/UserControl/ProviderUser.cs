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

namespace WinFormsApp
{
    public partial class ProviderUser : UserControl
    {
        string[] arr = ["Id", "Name"];

        public ProviderDTO providerDTO;
        public ProviderRepository ProviderRepository { get; set; }
        public IdentificationTypeRepository IdentificationTypeRepository { get; set; }
        public Form Form { get; set; }
        public ProviderUser()
        {
            InitializeComponent();
        }
        void NewProvider()
        {
            providerDTO = null;
            txtIdentification.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtLastName.Clear();
            cmbIdentificationType.SelectedIndex = -1;
            txtIdentification.Focus();
        }

        private void ProviderUser_Load(object sender, EventArgs e)
        {
            Form.FormClosing += Form_FormClosing;
            Utilities<IdentificationTypeDTO>.FillCombo(IdentificationTypeRepository.Values.ToList(), arr, cmbIdentificationType);
            if (providerDTO != null)
            {                
                txtIdentification.Text = providerDTO.Identification;
                txtAddress.Text = providerDTO.Address;
                txtPhone.Text = providerDTO.Phone;
                txtEmail.Text = providerDTO.Email;
                txtName.Text = providerDTO.Name;
                txtLastName.Text = providerDTO.LastName;
                cmbIdentificationType.SelectedValue = providerDTO.IdentificationTypeId;
                return ;
            }
            NewProvider();           
        }

        private void Form_FormClosing(object? sender, FormClosingEventArgs e)
        {
              var resp = MessageBox.Show("Cerrar Modal?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            NewProvider();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdentification.Text))
            {
                ControlForm.GetMessage("Idntificacion no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                ControlForm.GetMessage("Direccion no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                ControlForm.GetMessage("Telefono no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                ControlForm.GetMessage("Email no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                ControlForm.GetMessage("Nombre no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                ControlForm.GetMessage("Apellido no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbIdentificationType.SelectedIndex == -1)
            {
                ControlForm.GetMessage("Tipo Idntificacion no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (providerDTO == null)
            {
                providerDTO = new ProviderDTO
                {
                    IdentificationTypeId = int.Parse(cmbIdentificationType.SelectedValue.ToString()),
                    Identification = txtIdentification.Text,
                    Name = txtName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                };
                ProviderRepository.Save(providerDTO);
            }
            else
            {
                providerDTO.IdentificationTypeId = int.Parse(cmbIdentificationType.SelectedValue.ToString());
                providerDTO.Identification = txtIdentification.Text;
                providerDTO.Name = txtName.Text;
                providerDTO.LastName = txtLastName.Text;
                providerDTO.Address = txtAddress.Text;
                providerDTO.Phone = txtPhone.Text;
                providerDTO.Email = txtEmail.Text;
                ProviderRepository.Update(providerDTO, providerDTO.Id);

            }
            NewProvider();
        }

    }
}
