using DataAccess.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class ChangePasswordUser : UserControl
    {
        public bool updated {  get; set; }
       public  EmployeeDTO EmployeeDTO { get; set; }
        public FrmFather FrmFather { get; set; }
        public UserRepository UserRepository { get; set; }
        UserDTO UserDTO { get; set; }
        public ChangePasswordUser()
        {
            InitializeComponent();
        }
        void ChangePasswordUser_Load(object sender, EventArgs e)
        {
            txtUserName.Text  = EmployeeDTO.User.Name;

        }
        void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                updated = false;
                return;

            }
            UserDTO = new UserDTO
            {
                Name = txtUserName.Text,
                Password = Utilities<string>.Encriptar(txtNewPassword.Text),
                CompanyId = EmployeeDTO.User.Companyid,
                RoleId = EmployeeDTO.User.RoleId,
                Email = EmployeeDTO.User.Email,
            };
            UserRepository.Update(UserDTO, EmployeeDTO.UserId);
            updated = true;
            FrmFather .Close();
        }
        void btnSalir_Click(object sender, EventArgs e)
        {
            updated=false;
            FrmFather .Close ();
        }
    }
}
