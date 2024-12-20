using DataAccess.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Controls
{
    internal class ClientControl : ControlUser<ClientUser, ClientDTO>
    {
        public override ClientUser GetControlUser(ClientDTO entity, FrmFather frmFather)
        {
            ClientUser client = new()
            {
                ClientRepository = clientRepository,
                ClientDTO = entity ,
                IdentificationTypeRepository = identificationTypeRepository,
                Dock = DockStyle.Fill,
                Form = frmFather
            };
            return client;
        }

        public override void LoadGrid(DataGridView gridView)
        {
            gridView.DataSource = clientRepository.Values.Select(x => new
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
            gridView.DataSource = clientRepository.Values.Select(x => new
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
