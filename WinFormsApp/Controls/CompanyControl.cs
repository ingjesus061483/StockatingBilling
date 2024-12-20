using DataAccess.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Controls
{
    internal class CompanyControl : ControlUser<CompanyUser, CompanyDTO>
    {
        public override CompanyUser GetControlUser(CompanyDTO entity, FrmFather frmFather)
        {
            CompanyUser companyUser = new CompanyUser
            {
                CompanyRepository = companyRepository,
                companyDTO=entity ,
                RegimenTypeRepository = regimenTypeRepository,
                Form = frmFather
            };
            return companyUser;
        }

        public override void LoadGrid(DataGridView gridView)
        {
            gridView.DataSource = companyRepository.Values.Select(x => new
            {
                x.Id,
                x.Nit,
                Nombre = x.Name,
                Direccion = x.Address,
                Telefono = x.Phone,
                CamaraComercio = x.TradeCamera,
                x.Email,
                Contacto = x.Contact,
                TipoRegimen = x.RegimenType.Name,

            }).ToList();
        }

        public override void LoadGrid(DataGridView gridView, string filter, string value)
        {
            gridView.DataSource = companyRepository.Values.Select(x => new
            {
                x.Id,
                x.Nit,
                Nombre = x.Name,
                Direccion = x.Address,
                Telefono = x.Phone,
                x.Email,
                CamaraComercio = x.TradeCamera,
                Contacto = x.Contact,
                TipoRegimen = x.RegimenType.Name,
            }).ToList().Where(z => Utilities<object>.GetValue(z, filter, value)).ToList();
        }
    }
}
