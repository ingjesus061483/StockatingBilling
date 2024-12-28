using DataAccess.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Controls
{
    public class ProductControl : ControlUser<ProductUser, ProductDTO>
    {
        public override ProductUser GetControlUser(ProductDTO entity, FrmFather frmFather)
        {
            ProductUser product = new()
            {
                productDTO = entity,
                repository = productRepository,
                pictureRepository = pictureRepository,
                categoryRepository = categoryRepository,
                unitMeasurementRepository = unitMeasurementRepository,
                WarehouseRepository = warehouseRepository,
                stockRepository = stockRepository,
                Form = frmFather,
                Dock = DockStyle.Fill
            };
            return product;
        }

        public override void LoadGrid(DataGridView gridView)
        {
            gridView.DataSource = productRepository.Values.Select(x => new
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

        public override void LoadGrid(DataGridView gridView, string filter, string value)
        {

            gridView.DataSource = productRepository.Values.Select(x => new
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
            }).ToList().Where(z => Utilities<object>.GetValue(z, filter, value)).ToList();
        }
    }
}
