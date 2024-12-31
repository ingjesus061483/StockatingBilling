using DataAccess.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class SearchUser : UserControl
    {    
        public object objects { get; set; }
        public int Id { get; set; }
   public  Form Form  { get; set; } 
        List<EmployeeDTO> EmployeeDTOs { get; set; }
        List<ClientDTO> ClientDTOs { get; set; }
        List<ProductDTO> ProductDTOs { get; set; }
        List<WarehouseDTO> WarehouseDTOs { get; set; }
        List<CompanyDTO> CompanyDTOs { get; set; }
        string[] arr = ["Index", "Name"];

        public SearchUser()
        {
            InitializeComponent();
        }
    
        object LoadGrid(object obj)
        {

            switch (obj)
            {
                case List<EmployeeDTO>:
                    {
                        EmployeeDTOs = obj as List<EmployeeDTO>;
                        return EmployeeDTOs.Select(x => new
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
                        //    break;
                    }
                case List<CompanyDTO>:
                    {
                        CompanyDTOs = obj as List<CompanyDTO>;
                        return CompanyDTOs.Select(x => new
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
                        }).ToList();
                        //  break;
                    }
                case List<ProductDTO>:
                    {
                        ProductDTOs = obj as List<ProductDTO>;
                        return ProductDTOs.Select(x => new
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
                        // break;
                    }
                case List<WarehouseDTO>:
                    {
                        WarehouseDTOs = obj as List<WarehouseDTO>;
                        return WarehouseDTOs.Select(x => new
                        {
                            x.Id,
                            x.Code,
                            x.Name,
                            limite = x.limitado ? "Si" : "No"
                        }).ToList();
                        //  break;
                    }
                case List<ClientDTO>:
                    {
                        ClientDTOs = obj as List<ClientDTO>;
                        return ClientDTOs.Select(x => new
                        {
                            x.Id,
                            TipoIdentificacion = x.IdentificationType.Name,
                            Identificion = x.Identification,
                            NombreCompleto = x.CompleteName,
                            Direccion = x.Address,
                            Telefono = x.Phone,
                            x.Email,
                        }).ToList();
                        // break;
                    }
            }
            return null;
        }
        object LoadGrid(object obj, string filter, string value)
        {
            switch (obj)
            {
                case List<EmployeeDTO>:
                    {
                        EmployeeDTOs = obj as List<EmployeeDTO>;
                        return EmployeeDTOs.Select(x => new
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
                case List<CompanyDTO>:
                    {
                        CompanyDTOs = obj as List<CompanyDTO>;
                        return CompanyDTOs.Select(x => new
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
                        }).ToList().Where(z => Utilities<object>.GetValue(z, filter, value)).ToList(); ;

                    }
                case List<ProductDTO>:
                    {
                        ProductDTOs = obj as List<ProductDTO>;
                        return ProductDTOs.Select(x => new
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
                case List<WarehouseDTO>:
                    {
                        WarehouseDTOs = obj as List<WarehouseDTO>;
                        return WarehouseDTOs.Select(x => new
                        {
                            x.Id,
                            x.Code,
                            x.Name,
                            limite = x.limitado ? "Si" : "No"
                        }).ToList().Where(z => Utilities<object>.GetValue(z, filter, value)).ToList();

                    }
                case List<ClientDTO>:
                    {
                        ClientDTOs = obj as List<ClientDTO>;
                        return ClientDTOs.Select(x => new
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
            return null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Id = dgSearch.CurrentRow != null ? int.Parse(dgSearch.CurrentRow.Cells[0].Value.ToString()) : 0;
           Form .Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = e.RowIndex >= 0 ? int.Parse(dgSearch.Rows[e.RowIndex].Cells[0].Value.ToString()) : 0;
            Form .Close();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            dgSearch.DataSource = LoadGrid(objects, cmbfields.Text, txtValue.Text);
        }
        private void SearchUser_Load(object sender, EventArgs e)
        {
            dgSearch.DataSource = LoadGrid(objects);
            var cols = Utilities<DataGridViewColumn>.GetValues(dgSearch);
            Utilities<DataGridViewColumn>.FillCombo(cols, cmbfields);

        }
    }
}
