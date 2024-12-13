using DataAccess.Migrations;
using DataAccess.Repositories;
using DTO;
using Factory;
using RoundedBorders;
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
    public partial class ProductUser : UserControl
    {
        List<PictureDTO> pictureDTOs;
        int idProduct;
        string path;
        ProductDTO productDTO;
        public Form Form { get; set; }
        public ComboBox CmbFilter { get; set; }
        public TextBox TxtValue { get; set; }
        public DataGridView dgProduct { get; set; }
        public WarehouseRepository WarehouseRepository { get; set; }
        public UnitMeasurementRepository unitMeasurementRepository;
        public ProductRepository repository { get; set; }
        public StockRepository stockRepository { get; set; }
        public CategoryRepository categoryRepository { get; set; }
        public PictureRepository pictureRepository { get; set; }
        string[] arr = ["Id", "Name"];
        public ProductUser()
        {
            InitializeComponent();
        }
        void NewProduct()
        {
            idProduct = 0;
            productDTO = null;
            txtUnitCost.Clear();
            txtCode.Clear();
            txtDescription.Clear();
            txtName.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbUnitMeasurement.SelectedIndex = -1;
            txtCode.Focus();
            pictureDTOs = pictureRepository.Values.Where(x => x.ProductId == idProduct).ToList();
            dgProduct.DataSource = repository.Values.Select(x => new
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
            }).ToList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            repository.DeleteById(idProduct);
            NewProduct();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal.TryParse(txtPrice.Text, out decimal price);
            decimal.TryParse(txtUnitCost.Text, out decimal unitCost);
            if (string.IsNullOrEmpty(txtUnitCost.Text))
            {
                ControlForm.GetMessage("El campo nnombre no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                ControlForm.GetMessage("El campo nnombre no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                ControlForm.GetMessage("El campo nnombre no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                ControlForm.GetMessage("El campo nnombre no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbCategory.SelectedIndex == -1)
            {
                ControlForm.GetMessage("El campo nnombre no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbUnitMeasurement.SelectedIndex == -1) 
            {
                ControlForm.GetMessage("El campo nnombre no puede ser vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (productDTO == null)
            {
                productDTO = new ProductDTO
                {
                    Code = txtCode.Text,
                    Name = txtName.Text,
                    UnitCost = unitCost,
                    Price = price,
                    Description = txtDescription.Text,
                    CategoryId = int.Parse(cmbCategory.SelectedValue.ToString()),
                    UnitMeasurementId = int.Parse(cmbUnitMeasurement.SelectedValue.ToString()),
                    Images = pictureDTOs.Select(x => new Picture
                    {
                        Code = x.Code,
                        Id = x.Id,
                        Name = x.Name,
                        Type = x.Type,
                        Data = x.Data,
                    }).ToList(),
                };
                repository.Save(productDTO);
            }
            else
            {
                productDTO.Name = txtName.Text;
                productDTO.Description = txtDescription.Text;
                productDTO.Price = price;
                productDTO.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
                productDTO.UnitMeasurementId = int.Parse(cmbUnitMeasurement.SelectedValue.ToString());
                productDTO.UnitCost = unitCost;
                productDTO.Code = txtCode.Text;
                repository.Update(productDTO, idProduct);
            }
            NewProduct();
            btnStock .PerformClick ();

        }

        private void dgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            idProduct = int.Parse(dgProduct.Rows[e.RowIndex].Cells["id"].Value.ToString());
            productDTO = repository.GetById(idProduct);
            productDTO.Images = pictureRepository.Values.Where(x => x.ProductId == idProduct).Select(t => new Picture
            {
                Id = t.Id,
                Code = t.Code,
                Name = t.Name,
                Data = t.Data,
                Type = t.Type,
            }).ToList();
            txtCode.Text = productDTO.Code;
            txtUnitCost.Text = productDTO.UnitCost.ToString();
            txtName.Text = productDTO.Name;
            txtDescription.Text = productDTO.Description;
            txtPrice.Text = productDTO.Price.ToString();
            cmbUnitMeasurement.SelectedValue = productDTO.UnitMeasurementId;
            cmbCategory.SelectedValue = productDTO.CategoryId;
            pictureDTOs = pictureRepository.Values.ToList();

        }
        private void Btnuevo_Click(object sender, EventArgs e)
        {
            NewProduct();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FrmImage frmImage = new()
            {
                ProductDTO = productDTO,
                Images = pictureDTOs,
                PictureRepository = pictureRepository,

            };
            frmImage.ShowDialog();
            pictureDTOs = frmImage.Images;
        }

        private void ProductUser_Load(object sender, EventArgs e)
        {
            TxtValue.TextChanged += TxtValue_TextChanged;
            dgProduct.CellContentClick += dgProduct_CellContentClick;
            Utilities<UnitMeasurementDTO>.FillCombo(unitMeasurementRepository.Values.ToList(), arr, cmbUnitMeasurement);
            Utilities<CategoryDTO>.FillCombo(categoryRepository.Values.ToList(), arr, cmbCategory);
            NewProduct();
            var cols = Utilities<DataGridViewColumn>.GetValues(dgProduct);
            Utilities<DataGridViewColumn>.FillCombo(cols, CmbFilter);

        }

        private void TxtValue_TextChanged(object? sender, EventArgs e)
        {
            dgProduct.DataSource = repository.Values.Select(x => new
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
            }).ToList().Where(z => Utilities<object>.GetValue(z, CmbFilter.Text, TxtValue.Text)).ToList();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (productDTO==null)
            {
                return;
            }
            frmStock frmStock = new frmStock
            {
                ProductDTO=productDTO,
                ProductRepository= repository,
                WarehouseRepository=WarehouseRepository,
                Repository =stockRepository 
            };
            frmStock.ShowDialog();
            NewProduct(); 
        }
    }
}
