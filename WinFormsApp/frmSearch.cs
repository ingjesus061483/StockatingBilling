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
    public partial class frmSearch : Form
    {
        public List<ProductDTO> ProductDTOs { get; set; }
        public List<WarehouseDTO> WarehouseDTOs { get; set; }
        public int Id { get; set; }
        string[] arr = ["Index", "Name"];

        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductDTOs != null ? ProductDTOs.Select(x => new
            {
                x.Id,
                Codigo = x.Code,
                Nombre = x.Name,
                Costo = x.UnitCost,
                Precio = x.Price,
                Descripcion = x.Description,
                Categoria = x.Category.Name,
                Unidad = x.UnitMeasurement.Name,
                Entrada = x.Entrance,
                Salida = x.Out,
                x.Total
            }).ToList() : WarehouseDTOs != null ? WarehouseDTOs.Select(x => new
            {
                x.Id,
                x.Code,
                x.Name,
                limite = x.limitado ? "Si" : "No"

            }).ToList() : null;

            var cols = Utilities<DataGridViewColumn>.GetValues(dataGridView1);
            Utilities<DataGridViewColumn>.FillCombo(cols, cmbfields);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Id = dataGridView1.CurrentRow != null ? int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()) : 0;
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = e.RowIndex >= 0 ? int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()) : 0;
            this.Close();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if (ProductDTOs != null)
            {
               dataGridView1.DataSource= ProductDTOs.Select(x => new
               {
                    x.Id,
                    Codigo = x.Code,
                    Nombre = x.Name,
                    Costo = x.UnitCost,
                    Precio = x.Price,
                    Descripcion = x.Description,
                    Categoria = x.Category.Name,
                    Unidad = x.UnitMeasurement.Name,
                    Entrada = x.Entrance,
                    Salida = x.Out,
                    x.Total
                }).Where(z =>Utilities<object>. GetValue(z, cmbfields.Text, txtValue.Text)).ToList();

            }
            else if (WarehouseDTOs != null) 
            {
                dataGridView1.DataSource=  WarehouseDTOs.Select(x => new
                {
                    x.Id,
                    x.Code,
                    x.Name,
                    limite = x.limitado ? "Si" : "No"
                }).Where(z =>Utilities<object>. GetValue(z,cmbfields.Text ,txtValue .Text )).ToList();
            }
        }      
    }
}
