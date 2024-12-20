using DataAccess.Repositories;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Controls
{
    public abstract class ControlUser<T, E>
    {
        public TaxRepository taxRepository ;
        public ProviderRepository providerRepository;
        public RegimenTypeRepository regimenTypeRepository;
        public ProductRepository productRepository;
        public PictureRepository pictureRepository;
        public CategoryRepository categoryRepository;
        public WarehouseRepository warehouseRepository;
        public UnitMeasurementRepository unitMeasurementRepository;
        public StockRepository stockRepository;
        public RoleRepository roleRepository;
        public ClientRepository clientRepository;
        public IdentificationTypeRepository identificationTypeRepository;
        public CompanyRepository companyRepository;
        public UserRepository userRepository;
        public EmployeeRepository employeeRepository;
        public abstract T GetControlUser(E entity, FrmFather frmFather);
        public abstract void LoadGrid(DataGridView gridView);   
      public abstract void LoadGrid(DataGridView gridView, string filter, string value);
    }
}
