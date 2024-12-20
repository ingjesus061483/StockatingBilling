using DataAccess.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Controls
{
    internal class ProviderControl : ControlUser<ProviderUser, ProviderDTO>
    {
        public override ProviderUser GetControlUser(ProviderDTO entity, FrmFather frmFather)
        {
            ProviderUser provider = new ProviderUser
            {
                ProviderRepository = providerRepository,
                IdentificationTypeRepository = identificationTypeRepository,
                providerDTO = entity,
                Form = frmFather ,

            };
            return provider;
        }

        public override void LoadGrid(DataGridView gridView)
        {
            gridView.DataSource = providerRepository.Values.Select(x => new
            {
                x.Id,

                TipoIdentificacion = x.IdentificationType.Name,
                Identificion = x.Identification,
                NombreCompleto = x.CompleteName,
                Direccion = x.Address,
                Telefono = x.Phone,
                x.Email,
            }).ToList();
        }

        public override void LoadGrid(DataGridView gridView, string filter, string value)
        {
            gridView.DataSource = providerRepository.Values.Select(x => new
            {
                x.Id,
                TipoIdentificacion = x.IdentificationType.Name,
                Identificion = x.Identification,
                NombreCompleto = x.CompleteName,
                Direccion = x.Address,
                Telefono = x.Phone,
                x.Email,
            }).ToList().Where(z => Utilities<object>.GetValue(z, filter, value)).ToList();
        }
    }
}
