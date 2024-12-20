using DataAccess.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Controls
{
    internal class EmployeeControl : ControlUser<EmployeeUser, EmployeeDTO>
    {
        public override EmployeeUser GetControlUser(EmployeeDTO entity, FrmFather frmFather)
        {
            EmployeeUser employee = new EmployeeUser
            {
                CompanyRepository = companyRepository,
                UserRepository = userRepository,          
                EmployeeRepository = employeeRepository,
                IdentificationTypeRepository = identificationTypeRepository,
                RoleRepository = roleRepository,
                Form = frmFather,
                EmployeeDTO = entity
            };
            return employee;
        }

        public override void LoadGrid(DataGridView gridView)
        {
           gridView.DataSource = employeeRepository.Values.Select(x => new
            {
                x.Id,
                TipoIdentificacion = x.IdentificationType.Name,
                Identificion = x.Identification,
                NombreCompleto = x.CompleteName,
                Direccion = x.Address,
                Telefono = x.Phone,
                x.User.Email,
                Usuario = x.User.Name,
                Role = x.User.Role.Name,
                Empresa = x.User.Company.Nit + " -" + x.User.Company.Name
            }).ToList();
        }
     

        public override void LoadGrid(DataGridView gridView, string filter, string value)
        {
            gridView.DataSource = employeeRepository.Values.Select(x => new
            {
                x.Id,
                TipoIdentificacion = x.IdentificationType.Name,
                Identificion = x.Identification,
                NombreCompleto = x.CompleteName,
                Direccion = x.Address,
                Telefono = x.Phone,
                x.User.Email,
                Usuario = x.User.Name,
                Role = x.User.Role.Name,
                Empresa = x.User.Company.Nit + " -" + x.User.Company.Name
            }).ToList().Where(z => Utilities<object>.GetValue(z, filter, value)).ToList();
        }
    }
}
