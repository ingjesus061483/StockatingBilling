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
    public partial class TaxUser : UserControl
    {
        TaxDTO taxDTO;
        public TaxRepository TaxRepository { get; set; }
        public DataGridView DataGridView { get; set; }
        public TextBox TxtValue { get; set; }
        public Form Form { get; set; }
        public ComboBox CmbFilter { get; set; }
        public TaxUser()
        {
            InitializeComponent();
        }
        void NewTax()
        {
            taxDTO = null;
            DataGridView.DataSource = TaxRepository.Values.Select(x => new
            {
                x.Id,
                Nombre = x.Name,
                Valor = x.Value,
                Descripcion = x.Description
            }).ToList();
            txtDescription.Clear();
            txtName.Clear();
            txtValue.Clear();
            txtName.Focus();

        }
        private void TaxUser_Load(object sender, EventArgs e)
        {
            DataGridView.CellContentClick += DataGridView_CellContentClick;
            TxtValue.TextChanged += TxtValue_TextChanged;
            NewTax();
            var cols = Utilities<DataGridViewColumn>.GetValues(DataGridView);
            Utilities<DataGridViewColumn>.FillCombo(cols, CmbFilter);
        }

        private void TxtValue_TextChanged(object? sender, EventArgs e)
        {
            DataGridView.DataSource = TaxRepository.Values.Select(x => new
            {
                x.Id,
                Nombre = x.Name,
                Valor = x.Value,
                Descripcion = x.Description
            }).ToList().Where(z => Utilities<object>.GetValue(z, CmbFilter.Text, TxtValue.Text)).ToList();
        }

        private void DataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = int.Parse(DataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            taxDTO = TaxRepository.GetById(id);
            txtDescription.Text = taxDTO.Description;
            txtName.Text = taxDTO.Name;
            txtValue.Text = taxDTO.Value.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtValue.Text, out decimal value);
            if (string.IsNullOrEmpty(txtName.Text))
            {
                ControlForm.GetMessage("El campo nombre no debe ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (value==0)
            {
                ControlForm.GetMessage("El campo Valor  debe ser numerico y no debe estar vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (taxDTO == null)
            {
                taxDTO = new TaxDTO()
                {
                    Description = txtDescription.Text,
                    Name = txtName.Text,
                    Value = value
                };
                TaxRepository.Save(taxDTO);
            }
            else
            {
                taxDTO.Description = txtDescription.Text;
                taxDTO.Name = txtName.Text;
                taxDTO.Value = value;
                TaxRepository.Update(taxDTO, taxDTO.Id);
            }
            NewTax();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (taxDTO == null)
            {
                return;

            }
            TaxRepository.DeleteById(taxDTO.Id);
            NewTax();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();

        }

        private void btnNevo_Click(object sender, EventArgs e)
        {
            NewTax();
        }
    }
}
