using DataAccess.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Controls
{
    internal class RoleControl : ControlUser<RoleUser, RoleDTO>
    {
        public override RoleUser GetControlUser(RoleDTO entity, FrmFather frmFather)
        {
            RoleUser role = new()
            {
                RoleRepository = roleRepository,
                RoleDTO = entity ,
                Dock = DockStyle.Fill,
                Form = frmFather
            };
            return role;
        }

        public override void LoadGrid(DataGridView gridView)
        {
            gridView.DataSource = roleRepository.Values.Select(x => new
            {
                x.Id,
                Nombre = x.Name,
                Descripcion = x.Description,
            }).ToList();
        }

        public override void LoadGrid(DataGridView gridView, string filter, string value)
        {
            gridView.DataSource = roleRepository.Values.Select(x => new
            {
                x.Id,
                Nombre = x.Name,
                Descripcion = x.Description,
            }).ToList().Where(z => Utilities<object>.GetValue(z, filter, value)).ToList();
        }
    }
}
