using DataAccess.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Controls
{
    internal class WarehouseControl : ControlUser<WarehouseUser, WarehouseDTO>

    {
        public override WarehouseUser GetControlUser(WarehouseDTO entity, FrmFather frmFather)
        {
            WarehouseUser warehouse = new()
            {
                ProductRepository = productRepository,
                StockRepository = stockRepository,
                warehouseRepository = warehouseRepository,
                Form = frmFather,
                WarehouseDTO = entity,
                Dock = DockStyle.Fill
            };
            return warehouse;
        }

        public override void LoadGrid(DataGridView gridView)
        {
            gridView.DataSource = warehouseRepository.Values.Select(x => new
            {
                x.Id,
                Codigo = x.Code,
                Nombre = x.Name,
                StockMinmo = x.StockMinimo,
                Stockmaximo = x.StockMaximo,
                limitado = x.limitado ? "Si" : "No"
            }).ToList();
        }

        public override void LoadGrid(DataGridView gridView, string filter, string value)
        {
            gridView.DataSource = warehouseRepository.Values.Select(x => new
            {
                x.Id,
                Codigo = x.Code,
                Nombre = x.Name,
                StockMinmo = x.StockMinimo,
                Stockmaximo = x.StockMaximo,
                limitado = x.limitado ? "Si" : "No"
            }).ToList().Where(z => Utilities<object>.GetValue(z, filter, value)).ToList();

        }
    }
}
