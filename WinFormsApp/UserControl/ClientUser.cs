using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repositories;
using DTO;
using Factory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace WinFormsApp
{
    public partial class ClientUser : UserControl
    {    
        string[] arr = ["Id", "Name"];
        public ClientRepository ClientRepository { get; set; }
        public IdentificationTypeRepository IdentificationTypeRepository { get; set; } 
        public  ClientDTO ClientDTO;
        public Form Form { get; set; }
        int Id;
      
        public ClientUser()
        {
            InitializeComponent();
        }
        void NewClient()
        {   
            Id = 0;
            ClientDTO = null;
            txtIdentification.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtLastName.Clear();
            cmbIdentificationType.SelectedIndex = -1;
            txtIdentification.Focus();
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

        private void ClientUser_Load(object sender, EventArgs e)
        {
            Form.FormClosing += Form_FormClosing;
            Utilities<IdentificationTypeDTO>.FillCombo(IdentificationTypeRepository.Values.ToList(), arr, cmbIdentificationType);
            if (ClientDTO != null)
            {
                Id =ClientDTO.Id;
                ClientDTO = ClientRepository.GetById(Id);
                txtIdentification.Text = ClientDTO.Identification;
                txtAddress.Text = ClientDTO.Address;
                txtPhone.Text = ClientDTO.Phone;
                txtEmail.Text = ClientDTO.Email;
                txtName.Text = ClientDTO.Name;
                txtLastName.Text = ClientDTO.LastName;
                cmbIdentificationType.SelectedValue = ClientDTO.IdentificationTypeId;
                return  ;
            }
            NewClient();
        }


        private void btnuevo_Click(object sender, EventArgs e)
        {
            NewClient();
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
            if (ClientDTO == null)
            {
                ClientDTO = new ClientDTO
                {
                    IdentificationTypeId = int.Parse(cmbIdentificationType.SelectedValue.ToString()),
                    Identification = txtIdentification.Text,
                    Name = txtName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,

                };
                ClientRepository.Save(ClientDTO);
            }
            else
            {
                ClientDTO.IdentificationTypeId = int.Parse(cmbIdentificationType.SelectedValue.ToString());
                ClientDTO.Identification = txtIdentification.Text;
                ClientDTO.Name = txtName.Text;
                ClientDTO.LastName = txtLastName.Text;
                ClientDTO.Address = txtAddress.Text;
                ClientDTO.Phone = txtPhone.Text;
                ClientDTO.Email = txtEmail.Text;
                ClientRepository.Update(ClientDTO, Id);
            }
            NewClient();
        } 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }
    }
}
