using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Controls
{
    public class UnitMeasurementControl : ControlUser<UnitMeasurementUser, UnitMeasurementDTO>
    {
        public override UnitMeasurementUser GetControlUser(UnitMeasurementDTO entity, FrmFather frmFather)
        {
            UnitMeasurementUser unitMeasurement = new()
            {
                UnitMeasurementRepository = unitMeasurementRepository,
                unitMeasurementDTO = entity,
                Form =frmFather,
                Dock = DockStyle.Fill
            };
            return unitMeasurement;
        }

        public override void LoadGrid(DataGridView gridView)
        {
           gridView.DataSource = unitMeasurementRepository.Values.Select(x => new
            {
                x.Id,
                Nombre = x.Name,
                Descripcion = x.Description,
            }).ToList();
        }

        public override void LoadGrid(DataGridView gridView, string filter, string value)
        {
            gridView.DataSource = unitMeasurementRepository.Values.Select(x => new
            {
                x.Id,
                Nombre = x.Name,
                Descripcion = x.Description,
            }).ToList().Where(z => Utilities<object>.GetValue(z, filter, value)).ToList();

        }
    }
}
