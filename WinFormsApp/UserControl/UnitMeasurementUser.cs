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
    public partial class UnitMeasurementUser : UserControl
    {
        int idUnitMeasurement;
     
        public UnitMeasurementRepository UnitMeasurementRepository { get; set; }
      
      public   UnitMeasurementDTO unitMeasurementDTO { get;set; }
        public Form Form { get; set; }
        public UnitMeasurementUser()
        {
            InitializeComponent();
        }
        private void newUnit()
        {
            idUnitMeasurement = 0;
            txtName.Clear();
            txtDescription.Clear();
            txtName.Focus();
            unitMeasurementDTO = null;
        }

        private void btnNevo_Click(object sender, EventArgs e)
        {
            newUnit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                ControlForm.GetMessage("El campo nnombre no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (unitMeasurementDTO == null)
            {
                unitMeasurementDTO = new UnitMeasurementDTO {
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                };
                UnitMeasurementRepository.Save(unitMeasurementDTO);
            }
            else
            {
                unitMeasurementDTO.Name = txtName.Text;
                unitMeasurementDTO.Description = txtDescription.Text;
               UnitMeasurementRepository.Update(unitMeasurementDTO,idUnitMeasurement);

            }
            newUnit();
        }

     

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();   
        }

        private void UnitMeasurementUser_Load(object sender, EventArgs e)
        {
            Form.FormClosing += Form_FormClosing;
            if(unitMeasurementDTO!= null)
            { 
                idUnitMeasurement = unitMeasurementDTO.Id;
                txtDescription.Text = unitMeasurementDTO.Description;
                txtName.Text = unitMeasurementDTO.Name;
                return;
            }      
            newUnit();           
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
    }
}
