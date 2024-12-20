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
       public TaxDTO taxDTO;
        public TaxRepository TaxRepository { get; set; }
        public Form Form { get; set; }
        public TaxUser()
        {
            InitializeComponent();
        }
        void NewTax()
        {
            taxDTO = null;
            txtDescription.Clear();
            txtName.Clear();
            txtValue.Clear();
            txtName.Focus();

        }
        private void TaxUser_Load(object sender, EventArgs e)
        {
            if (taxDTO != null)
            {
                txtDescription.Text = taxDTO.Description;
                txtName.Text = taxDTO.Name;
                txtValue.Text = taxDTO.Value.ToString();
                return;
            }
            NewTax();
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
