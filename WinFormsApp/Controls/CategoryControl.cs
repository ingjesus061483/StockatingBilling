using DataAccess.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Controls
{
    public class CategoryControl : ControlUser<CategoryUser, CategoryDTO>
    {
        public override CategoryUser GetControlUser(CategoryDTO entity, FrmFather frmFather)
        {
            CategoryUser category = new()
            {
                repository = categoryRepository,
                Form = frmFather,
                Dock = DockStyle.Fill,
                categoryDTO = entity
            };
            return category;
        }

        public override void LoadGrid(DataGridView gridView)
        {
            gridView.DataSource = categoryRepository.Values.Select(x => new
            {
                x.Id,
                Nombre = x.Name,
                Descripcion = x.Description,
            }).ToList();
        }

        public override void LoadGrid(DataGridView gridView, string filter, string value)
        {
            gridView.DataSource = categoryRepository.Values.Select(x => new
            {
                x.Id,
                Nombre = x.Name,
                Descripcion = x.Description,
            }).ToList().Where(z => Utilities<object>.GetValue(z, filter, value)).ToList(); 
        }
    }
}
