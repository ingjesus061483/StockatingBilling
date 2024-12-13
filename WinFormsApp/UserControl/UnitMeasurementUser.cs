﻿using DataAccess.Repositories;
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
        public ComboBox CmbFilter { get; set; }
        public TextBox TxtValue { get; set; }

        public UnitMeasurementRepository UnitMeasurementRepository { get; set; }
        public DataGridView DataGridView { get; set; }
        UnitMeasurementDTO unitMeasurementDTO;
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
            DataGridView.DataSource = UnitMeasurementRepository.Values.Select(x=> new {
                x.Id,
                Nombre = x.Name,
                Descripcion = x.Description,
            }). ToList();           
            

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UnitMeasurementRepository.DeleteById(idUnitMeasurement);
            newUnit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();   
        }

        private void UnitMeasurementUser_Load(object sender, EventArgs e)
        {
            DataGridView.CellContentClick += DataGridView_CellContentClick;
            TxtValue.TextChanged += TxtValue_TextChanged;
            newUnit();
            var cols = Utilities<DataGridViewColumn>.GetValues(DataGridView);
            Utilities<DataGridViewColumn>.FillCombo(cols, CmbFilter);
        }

        private void TxtValue_TextChanged(object? sender, EventArgs e)
        {

            DataGridView.DataSource = UnitMeasurementRepository.Values.Select(x => new {
                x.Id,
                Nombre = x.Name,
                Descripcion = x.Description,
            }).ToList().Where(z => Utilities<object>.GetValue(z, CmbFilter.Text, TxtValue.Text)).ToList();
        }

        private void DataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            idUnitMeasurement =int.Parse(  DataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString());
         unitMeasurementDTO = UnitMeasurementRepository.GetById(idUnitMeasurement);
            txtDescription.Text = unitMeasurementDTO.Description;   
            txtName.Text = unitMeasurementDTO.Name; 

        }
    }
}
