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
        public ComboBox CmbFilter { get; set; }   
        public DataGridView DataGridView { get; set; }
        public TextBox TxtValue { get; set; }
        public ClientRepository ClientRepository { get; set; }
        public IdentificationTypeRepository IdentificationTypeRepository { get; set; }
        public Form Form { get; set; }
        int Id;
        ClientDTO ClientDTO;
        public ClientUser()
        {
            InitializeComponent();
        }
        void NewClient()
        {
            DataGridView.DataSource = ClientRepository.Values.Select(x => new
            {
                x.Id,

                TipoIdentificacion = x.IdentificationType.Name,
                Identificion = x.Identification,
                NombreCompleto = x.CompleteName,
                Direccion = x.Address,
                Telefono = x.Phone,
                x.Email,
            }).ToList();
            Id = 0;
            txtIdentification.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtLastName.Clear();
            cmbIdentificationType.SelectedIndex = -1;
            txtIdentification.Focus();

        }
        private void ClientUser_Load(object sender, EventArgs e)
        {
            DataGridView.CellContentClick += DataGridView_CellContentClick;   
            TxtValue.TextChanged += TxtValue_TextChanged;
            Utilities<IdentificationTypeDTO>.FillCombo(IdentificationTypeRepository.Values.ToList(), arr, cmbIdentificationType);
            NewClient();
            var cols = Utilities<DataGridViewColumn>.GetValues(DataGridView);
            Utilities<DataGridViewColumn>.FillCombo(cols, CmbFilter);
        }

        private void TxtValue_TextChanged(object? sender, EventArgs e)
        {
            DataGridView.DataSource = ClientRepository.Values.Select(x => new
            {
                x.Id,
                TipoIdentificacion = x.IdentificationType.Name,
                Identificion = x.Identification,
                NombreCompleto = x.CompleteName,
                Direccion = x.Address,
                Telefono = x.Phone,
                x.Email,
            }).ToList().Where(z => Utilities<object>.GetValue(z, CmbFilter.Text, TxtValue.Text)).ToList();
        }

        private void DataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            Id = int.Parse(DataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString());
            ClientDTO = ClientRepository.GetById(Id);
            txtIdentification.Text = ClientDTO.Identification;
            txtAddress.Text = ClientDTO.Address;
            txtPhone.Text = ClientDTO.Phone;
            txtEmail.Text = ClientDTO.Email;
            txtName.Text = ClientDTO.Name;
            txtLastName.Text = ClientDTO.LastName;
            cmbIdentificationType.SelectedValue = ClientDTO.IdentificationTypeId;

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
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                ControlForm.GetMessage("Email no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (!string.IsNullOrEmpty(txtName.Text))
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ClientDTO == null)
            {
                return;
            }
            ClientRepository.DeleteById(Id);
            NewClient();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }
    }
}
