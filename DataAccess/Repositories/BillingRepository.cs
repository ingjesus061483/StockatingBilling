using DTO;
using Factory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class BillingRepository : IRepository<BillHeaderDTO>
    {
        public StockatingDbContext Db { get ; set ; }
        StockRepository StockRepository;
        ProductRepository ProductRepository;
        public IQueryable<BillHeaderDTO> Values => Db.BillHeaders.Include(x=>x.Client).
                                                                  Include(x=>x.Employee).
                                                                  Include(x=>x.State ).            
                                                                  Include (x=>x.DocumentType).
                                                                  Include (x=>x.BillDetails).           
                                                                  Select(x=>new BillHeaderDTO
                                                                  {
                                                                      Id = x.Id,
                                                                      ClientId = x.ClientId,
                                                                      Client =x.Client,
                                                                      DocumentType = x.DocumentType,
                                                                      Date = x.Date,
                                                                      Code = x.Code,
                                                                      DocumentTypeId = x.DocumentTypeId,
                                                                      EmployeeId = x.EmployeeId,
                                                                      Employee=x.Employee,
                                                                      State = x.State,
                                                                      StateId = x.StateId,
                                                                      Credit = x.Credit,
                                                                      Remark = x.Remark,
                                                                      BillDetails = x.BillDetails,
                                                                  });

        public BillingRepository(StockatingDbContext db,ProductRepository _productRepository , StockRepository  _stockRepository)
        {
            Db = db;
            StockRepository = _stockRepository;
        }
        public void DeleteById(int id)
        {
            BillHeader billHeader=Db.BillHeaders.FirstOrDefault(x=>x.Id == id);
            Db.BillHeaders.Remove(billHeader);
            Db.SaveChanges();
        }
        public BillHeaderDTO GetById(int id)=>Values.FirstOrDefault (x=>x.Id == id);
        public void Save(BillHeaderDTO entity)
        {
            BillHeader billHeader = new BillHeader
            {
                Code = entity.Code,
                ClientId = entity.ClientId,
                DocumentTypeId = entity.DocumentTypeId,
                EmployeeId = entity.EmployeeId,
                Date = entity.Date,
                StateId = 1,
                Credit = entity.Credit,
                Remark = entity.Remark,
            };
            Db.BillHeaders.Add(billHeader);
            Db.SaveChanges();            
            var billdetail = entity.BillDetails.Select(x=>new BillDetail
            {
                Id =0,
                Amount = x.Amount,
                WarehouseId= x.WarehouseId,
                ProductId = x.ProductId,
                UnitPrice = x.UnitPrice,
                Product=x.Product,
                BillHeaderId = billHeader.Id,
            }).ToList();
            Db.BillDetail.AddRange(billdetail);
            Db.SaveChanges();
        }
        public void Update(BillHeaderDTO entity, int id)
        {
            BillHeader billHeader  =Db .BillHeaders .Where (x=>x.Id == id).FirstOrDefault();    
            billHeader .StateId = entity.StateId;
            Db.BillHeaders .Update(billHeader);
            Db.SaveChanges();
        }
        public void RemoveDetail(BillHeaderDTO billHeaderDTO,int id)
        {
           var BillDetails= billHeaderDTO .BillDetails ;
            if (BillDetails.Count   != 0)
            {
                var billDetail =BillDetails .Where (z=>z.Id ==id).FirstOrDefault();
               BillDetails .Remove(billDetail );
            }
        }
        int GetId(List< BillDetail> BillDetails)
        {
            BillDetail last = null;
            if (BillDetails.Count > 0)
            {
                last = BillDetails.Last();
            }
            int id = 0;      
            return  last!=null ?last .Id +1 : 1;
        }
        void GetExists(List<BillDetail> BillDetails, ProductDTO productDTO)
        {
            if (BillDetails.Exists(x => x.Product.Id == productDTO .Id))
            {
                BillDetails.RemoveAll(x => x.Product.Id == productDTO .Id);
            }
        }
        public void DeliveryProduct(BillHeaderDTO billHeaderDTO )
        {
            List<Stock> stocks = [];
            

            foreach (BillDetail billDetail in billHeaderDTO.BillDetails)
            {
               decimal Totalstock= StockRepository.GetTotalStock(billDetail.ProductId, int.Parse(billDetail.WarehouseId.ToString()));
              decimal TotalAmount= Totalstock -billDetail.Amount;
                if (TotalAmount < 0)
                {
                    break;
                }
                Stock stock = new()
                {
                    Amount = billDetail.Amount,
                    Entrance = false,
                    Date = DateTime.Now,
                    ProductId = billDetail.ProductId,
                    WarehouseId =int.Parse( billDetail.WarehouseId.ToString() ),
                };
                stocks.Add(stock);                
            }
            StockRepository.Save(stocks );
            billHeaderDTO .StateId = 2;


        }
        public void AddDetails(ProductDTO Articulo,BillHeaderDTO billHeaderDTO,WarehouseDTO warehouseDTO, decimal amount)
        {
            try
            {
                var BillDetails=billHeaderDTO.BillDetails;          
                GetExists(BillDetails, Articulo );             
                BillDetail billDetail = new ()
                {
                    Id =GetId(BillDetails),
                    BillHeaderId =billHeaderDTO . Id,
                    ProductId = Articulo.Id,
                    WarehouseId = warehouseDTO . Id,
                    Warehouse=Db.Warehouse.FirstOrDefault(x=>x.Id == warehouseDTO .Id ),
                    Product = Db.Products.FirstOrDefault(x=>x.Id ==Articulo .Id ),
                    UnitPrice  = Articulo.Price ,
                    Amount  = amount,
                };
                BillDetails.Add(billDetail);
                billHeaderDTO.BillDetails = BillDetails;    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
