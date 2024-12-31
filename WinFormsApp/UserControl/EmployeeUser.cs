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
    public partial class EmployeeUser : UserControl
    {
        int Id;
        CompanyDTO  CompanyDTO;
      public EmployeeDTO EmployeeDTO { get; set; }
        public Form Form { get; set; }
        public CompanyRepository CompanyRepository { get; set; }
        public UserRepository UserRepository { get; set; }
        public EmployeeRepository EmployeeRepository { get; set; }
        public RoleRepository RoleRepository { get; set; }
        public IdentificationTypeRepository IdentificationTypeRepository { get; set; }
        string[] arr = ["Id", "Name"];
        public EmployeeUser()
        {
            InitializeComponent();
        }
        void NewEmployee()
        {    
            Id = 0;
            txtIdentification.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtLastName.Clear();
            cmbIdentificationType.SelectedIndex = -1;
            txtIdentification.Focus();
            txtUserName.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            EmployeeDTO = null;
        }
        private void EmployeeUser_Load(object sender, EventArgs e)
        {
            Form.FormClosing += Form_FormClosing;
            Utilities<IdentificationTypeDTO>.FillCombo(IdentificationTypeRepository.Values.ToList(), arr, cmbIdentificationType);
            Utilities<RoleDTO>.FillCombo(RoleRepository.Values.ToList(), arr, cmbRole);
            if (EmployeeDTO != null)
            {
                txtIdentification.Text = EmployeeDTO.Identification;
                txtAddress.Text = EmployeeDTO.Address;
                txtPhone.Text = EmployeeDTO.Phone;
                txtEmail.Text = EmployeeDTO.User.Email;
                txtName.Text = EmployeeDTO.Name;
                txtLastName.Text = EmployeeDTO.LastName;
                cmbIdentificationType.SelectedValue = EmployeeDTO.IdentificationTypeId;
                txtUserName.Text = EmployeeDTO.User.Name;
                cmbRole.SelectedValue = EmployeeDTO.User.Role.Id;
                Id=EmployeeDTO .Id ;
                return ;
            }
            NewEmployee();
           
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

        private void btnuevo_Click(object sender, EventArgs e)
        {
            NewEmployee();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
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
            if (!Utilities<string>.ValidarEmail(txtEmail.Text))
            {
                ControlForm.GetMessage("Email  esta mal escrito", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (EmployeeDTO == null)
            {
                if (CompanyDTO == null)
                {
                    ControlForm.GetMessage("No has elegido una compañia", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                UserDTO userDTO = new UserDTO
                {
                    Name = txtUserName.Text,
                    Password = Utilities<string>.Encriptar(txtPassword.Text),
                    RoleId = int.Parse(cmbRole.SelectedValue.ToString()),
                    CompanyId =CompanyDTO.Id ,
                    Email = txtEmail.Text,
                };
                UserRepository.Save(userDTO);
                EmployeeDTO = new EmployeeDTO
                {
                    Name = txtName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Identification = txtIdentification.Text,
                    IdentificationTypeId = int.Parse(cmbIdentificationType.SelectedValue.ToString()),
                    UserId = userDTO.Id
                };
                EmployeeRepository.Save(EmployeeDTO);

            }
            else
            {

                EmployeeDTO.Name = txtName.Text;
                EmployeeDTO.LastName = txtLastName.Text;
                EmployeeDTO.Address = txtAddress.Text;
                EmployeeDTO.Phone = txtPhone.Text;
                EmployeeDTO.Identification = txtIdentification.Text;
                EmployeeDTO.IdentificationTypeId = int.Parse(cmbIdentificationType.SelectedValue.ToString());
                EmployeeRepository.Update(EmployeeDTO, Id);

            }
            NewEmployee();
        }
        SearchUser SearchUser;
        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmFather frmFather = ControlForm.GetFrmFather(ref  SearchUser, CompanyRepository.Values.ToList());
            frmFather .ShowDialog();
           CompanyDTO= CompanyRepository.GetById( SearchUser .Id );
            txtCompany.Text = CompanyDTO != null ? CompanyDTO.Nit + " " + CompanyDTO.Name : string .Empty;
        }
    }
}
