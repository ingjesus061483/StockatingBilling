using DataAccess.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Controls
{
    internal class TaxControl : ControlUser<TaxUser, TaxDTO>
    {
        public override TaxUser GetControlUser(TaxDTO entity, FrmFather frmFather)
        {
            TaxUser tax = new TaxUser
            {
                TaxRepository = taxRepository,
                Form = frmFather,
                taxDTO = entity
            };
            return  tax;
        }

        public override void LoadGrid(DataGridView gridView)
        {
           gridView.DataSource =taxRepository.Values.Select(x => new
            {
                x.Id,
                Nombre = x.Name,
                Valor = x.Value,
                Descripcion = x.Description
            }).ToList();
        }

        public override void LoadGrid(DataGridView gridView, string filter, string value)
        {
            gridView.DataSource = taxRepository.Values.Select(x => new
            {
                x.Id,
                Nombre = x.Name,
                Valor = x.Value,
                Descripcion = x.Description
            }).ToList().Where(z => Utilities<object>.GetValue(z, filter, value)).ToList(); 
        }
    }
}
