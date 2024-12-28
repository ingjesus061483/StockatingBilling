using DataAccess.Repositories;
using DTO;
using Factory;
using K4os.Hash.xxHash;
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
    public partial class WarehouseUser : UserControl
    {
        int id;
        public WarehouseDTO WarehouseDTO;        
        public Form Form { get; set; }
        public ProductRepository ProductRepository { get; set; }    
        public StockRepository StockRepository { get; set; }
        public WarehouseRepository warehouseRepository {  get; set; }
        public WarehouseUser()
        {
            InitializeComponent();
        }
        private void WarehouseUser_Load(object sender, EventArgs e)
        {
            if (WarehouseDTO != null)
            {
                id = WarehouseDTO.Id;
                txtCode.Text = WarehouseDTO.Code;
                txtName.Text = WarehouseDTO.Name;
                txtDescription.Text = WarehouseDTO.Descripcion;
                txtMin.Text = WarehouseDTO.StockMinimo.ToString();
                txtMax.Text = WarehouseDTO.StockMaximo.ToString();
                chkLimit.Checked = WarehouseDTO.limitado;
                return ;
            }

            NewWarehouse();
        }

    /*    private void TxtValue_TextChanged(object? sender, EventArgs e)
        {
            DataGridView.DataSource = warehouseRepository.Values.Select(x => new
            {
                x.Id,
                Codigo = x.Code,
                Nombre = x.Name,
                StockMinmo = x.StockMinimo,
                Stockmaximo = x.StockMaximo,
                limitado = x.limitado ? "Si" : "No"
            }).ToList().Where(z => Utilities<object>.GetValue(z, CmbFilter.Text, TxtValue.Text)).ToList(); ;
        }*/

     /*   private void DataGridView_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            id = int.Parse(DataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString());
            WarehouseDTO = warehouseRepository.GetById(id);
            txtCode.Text = WarehouseDTO.Code;
            txtName.Text = WarehouseDTO.Name;
            txtDescription.Text = WarehouseDTO.Descripcion;
            txtMin.Text = WarehouseDTO.StockMinimo.ToString();
            txtMax.Text = WarehouseDTO.StockMaximo.ToString();
            chkLimit.Checked = WarehouseDTO.limitado;
            txtCode.Focus();

        }*/
        void NewWarehouse()
        {
            id = 0;
            WarehouseDTO = null;
            txtCode.Clear();
            txtName.Clear();
            txtMin.Clear();
            txtMax.Clear();
            txtDescription.Clear();
            chkLimit.Checked = false;
            txtCode.Focus();
   /*         DataGridView.DataSource = warehouseRepository.Values.Select(x => new
            {
                x.Id,
                Codigo = x.Code,
                Nombre = x.Name,
                StockMinmo = x.StockMinimo,
                Stockmaximo = x.StockMaximo,
                limitado = x.limitado ? "Si" : "No"
            }).ToList();*/


        }
        private void Btnuevo_Click(object sender, EventArgs e)
        {
            NewWarehouse();
        }

        private void chkLimit_CheckedChanged(object sender, EventArgs e)
        {
            txtMin.ReadOnly = !chkLimit.Checked;
            txtMax.ReadOnly = !chkLimit.Checked;
            txtMin.Clear();
            txtMax.Clear();
            txtMin.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int.TryParse(txtMin.Text, out int StockMinimo);
            int.TryParse(txtMax.Text, out int StockMaximo);
            if(string.IsNullOrEmpty(txtName  .Text))
            {
                ControlForm.GetMessage("El campo nnombre no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(string.IsNullOrEmpty(txtCode  .Text))
            {
                ControlForm.GetMessage("El campo nnombre no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (StockMinimo <= 0 && chkLimit.Checked)
            {
                ControlForm.GetMessage("El campo nnombre no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (StockMaximo  <= 0 && chkLimit.Checked)
            {
                ControlForm.GetMessage("El campo nnombre no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (WarehouseDTO == null)
            {
                WarehouseDTO = new()
                {
                    Code = txtCode.Text,
                    Name = txtName.Text,
                    StockMinimo = StockMinimo,
                    StockMaximo = StockMaximo,
                    Descripcion = txtDescription.Text,
                    limitado = chkLimit.Checked,
                };
                warehouseRepository.Save(WarehouseDTO);
            }
            else
            {
                WarehouseDTO.Code = txtCode.Text;
                WarehouseDTO.Name = txtName.Text;
                WarehouseDTO.Descripcion = txtDescription.Text;
                WarehouseDTO.StockMaximo = StockMaximo;
                WarehouseDTO.StockMinimo = StockMinimo;
                WarehouseDTO.limitado = chkLimit.Checked;
                warehouseRepository.Update(WarehouseDTO, id);
            }
            NewWarehouse();
        }

    

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }

      
    }
}
