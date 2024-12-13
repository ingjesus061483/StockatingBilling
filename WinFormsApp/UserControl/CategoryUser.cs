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

    public partial class CategoryUser : UserControl
    {
        CategoryDTO categoryDTO;
        public ComboBox CmbFilter {  get; set; }
        public TextBox TxtValue {  get; set; }
        public CategoryRepository repository { get; set; }
        public DataGridView DataGridView { get; set; }
        public Form Form { get; set; }
        int IdCategory;

        public CategoryUser()
        {
            InitializeComponent();
        }
        private void DataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridView dgCategory = sender as DataGridView;
            IdCategory = int.Parse(dgCategory.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            categoryDTO = repository.GetById(IdCategory);
            txtName.Text = categoryDTO.Name;
            txtDescription.Text = categoryDTO.Description;
            btnEliminar.Enabled = true;
        }

        public void NewCategory()
        {
            IdCategory = 0;
            categoryDTO = null;
            DataGridView.DataSource = repository.Values.Select (x=>new 
            {
                x.Id ,
                Nombre = x.Name,
                Descripcion=x.Description,

            }). ToList();
            txtName.Clear();
            txtDescription.Clear();
            txtName.Focus();
            btnEliminar.Enabled = false;
        }
        private void btnNevo_Click(object sender, EventArgs e)
        {
            NewCategory();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
           // categoryDTO = repository.GetById(IdCategory);
            if(string .IsNullOrEmpty( txtName .Text ))
            {
                ControlForm .GetMessage("El campo nnombre no puede ser vacio","",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                return;
            }
            if (categoryDTO == null)
            {
                categoryDTO = new()
                {
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                };
                repository.Save(categoryDTO);
            }
            else
            {
                categoryDTO.Name = txtName.Text;
                categoryDTO.Description = txtDescription.Text;
                repository.Update(categoryDTO, IdCategory);
            }
            NewCategory();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            repository.DeleteById(IdCategory);
            btnEliminar.Enabled = false;
        }

        private void CategoryUser_Load(object sender, EventArgs e)
        {
            DataGridView.CellContentClick += DataGridView_CellContentClick;
            TxtValue.TextChanged += TxtValue_TextChanged;
            NewCategory();
            var cols = Utilities<DataGridViewColumn>.GetValues(DataGridView);
            Utilities<DataGridViewColumn>.FillCombo(cols, CmbFilter );

        }

        private void TxtValue_TextChanged(object? sender, EventArgs e)
        {
            DataGridView.DataSource = repository.Values.Select(x => new
            {
                x.Id,
                Nombre = x.Name,
                Descripcion = x.Description,
            
            }).ToList(). Where(z => Utilities<object>.GetValue(z, CmbFilter.Text, TxtValue.Text)).ToList();
        }
    }
}
