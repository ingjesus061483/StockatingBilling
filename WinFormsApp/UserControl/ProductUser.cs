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
       public  ProductDTO productDTO ;
        public Form Form { get; set; }
   
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
            Form.FormClosing += Form_FormClosing;
            Utilities<UnitMeasurementDTO>.FillCombo(unitMeasurementRepository.Values.ToList(), arr, cmbUnitMeasurement);
            Utilities<CategoryDTO>.FillCombo(categoryRepository.Values.ToList(), arr, cmbCategory);
            if (productDTO != null)
            {
                idProduct= productDTO.Id ;
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
                return;
            }
            NewProduct();
     
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
