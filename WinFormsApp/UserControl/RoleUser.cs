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
    public partial class RoleUser : UserControl
    {
        int id;
        public RoleRepository RoleRepository { get; set; }
        public DataGridView DataGridView { get; set; }
        RoleDTO RoleDTO;
        public Form Form { get; set; }
        private void NewRole()
        {
            id = 0;
            txtName.Clear();
            txtDescription.Clear();
            txtName.Focus();
            DataGridView.DataSource = RoleRepository.Values.ToList();

            RoleDTO = null;
        }

        private void DataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            id = int.Parse(DataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            RoleDTO = RoleRepository.GetById(id);
            txtDescription.Text = RoleDTO.Description;
            txtName.Text = RoleDTO.Name;
        }

        public RoleUser()
        {
            InitializeComponent();
        }

        private void RoleUser_Load(object sender, EventArgs e)
        {
            DataGridView.CellContentClick += DataGridView_CellContentClick;
            NewRole();
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
