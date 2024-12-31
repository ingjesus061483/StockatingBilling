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
    public partial class LoginUser : UserControl
    {
        public EmployeeDTO employeeDTO;
        public Form Form { get; set; }
        public EmployeeRepository EmployeeRepository { get; set; }

        public LoginUser()
        {
            InitializeComponent();
        }
        void newlogin()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName .Focus();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
           Form.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( txtUserName .Text ))
            {
                ControlForm.GetMessage(" el campo usuario  no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                ControlForm.GetMessage(" el campo password  no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            employeeDTO = EmployeeRepository.Values.Where(x => 
                                                                 x.User.Name == txtUserName.Text &&
                                                                 x.User.Password == Utilities<string>.Encriptar(txtPassword.Text)).
                                                                 FirstOrDefault();
            if (employeeDTO == null)
            {
                ControlForm.GetMessage("usuario o contraseña invalida", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newlogin();
                this.Cursor = Cursors.Default;

                return;
            }
            this.Cursor= Cursors.Default;
            Form .Close();
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==Convert.ToChar( Keys.Enter))
            {
                btnLogin.PerformClick();
            }
        }
    }
}
