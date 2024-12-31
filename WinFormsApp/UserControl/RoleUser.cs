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
    public partial class RoleUser : UserControl
    {
        int id;
        public RoleRepository RoleRepository { get; set; }
public        RoleDTO RoleDTO;
        public Form Form { get; set; }
        private void NewRole()
        {
            id = 0;
            txtName.Clear();
            txtDescription.Clear();
            txtName.Focus();
            RoleDTO = null;
        }


        public RoleUser()
        {
            InitializeComponent();
        }

        private void RoleUser_Load(object sender, EventArgs e)
        {
            Form.FormClosing += Form_FormClosing;
            if(RoleDTO  != null)
            {
                id = RoleDTO.Id;
                RoleDTO = RoleRepository.GetById(id);
                txtDescription.Text = RoleDTO.Description;
                txtName.Text = RoleDTO.Name;
                return;
            }
            NewRole();
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

        private void btnNevo_Click(object sender, EventArgs e)
        {
            NewRole();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                 ControlForm.GetMessage("El campo nombre no debe ser vacio","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;

            }
            if (RoleDTO == null)
            {
                RoleDTO = new RoleDTO
                {
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                };
                RoleRepository.Save(RoleDTO);
            }
            else
            {
                RoleDTO.Name = txtName.Text;
                RoleDTO.Description = txtDescription.Text;
                RoleRepository.Update(RoleDTO, id);
            }
            NewRole();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (RoleDTO == null)
            {
                return;
            }
            RoleRepository.DeleteById(id);
            NewRole();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }
    }
}
