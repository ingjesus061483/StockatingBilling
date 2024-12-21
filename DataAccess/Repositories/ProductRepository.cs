using DTO;
using Factory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace DataAccess.Repositories
{
   public  class ProductRepository : IRepository<ProductDTO>
    {
        PictureRepository pictureRepository;
        public ProductRepository(StockatingDbContext context,PictureRepository _pictureRepository) 
        {           
            pictureRepository = _pictureRepository; 
            Db = context;
        }
        public StockatingDbContext Db { get  ; set; }

        public IQueryable<ProductDTO> Values => Db.Products.Include(c=>c.Category)
                                                           .Include(u=>u.UnitMeasurement)
                                                           .Include(s=>s.Stocks)
                                                           .Select(x => new ProductDTO
                                                           {
                                                                Id = x.Id,
                                                                Code = x.Code,
                                                                Name = x.Name,
                                                                UnitCost = x.UnitCost,
                                                                Price = x.Price,
                                                                Description = x.Description,
                                                                CategoryId = x.CategoryId,
                                                                Category=x.Category,
                                                                UnitMeasurementId = x.UnitMeasurementId,
                                                                UnitMeasurement = x.UnitMeasurement,
                                                                Stocks = x.Stocks,       
                                                           });

        public void DeleteById(int id)
        {
            Product product = Db.Products.Where(x=>x.Id == id).FirstOrDefault();
            Db.Products.Remove(product);    
            Db.SaveChanges();
        }

        public ProductDTO GetById(int id)=> Values .Where(x=>x.Id==id).FirstOrDefault();
        

        public void Save(ProductDTO entity)
        {
            Product product = new( )
            {
                Id = entity.Id,
                Code = entity.Code,
                Name = entity.Name,
                UnitCost = entity.UnitCost,
                Price = entity.Price,
                Description = entity.Description,
                CategoryId = entity.CategoryId,
                UnitMeasurementId= entity.UnitMeasurementId,
            };
            Db.Products.Add(product);      
            Db.SaveChanges();

            var p=entity.Images.Select(x=>new PictureDTO
            {
                Code = x.Code,
                Name = x.Name,
                Data = x.Data,
                Type = x.Type,               
            }).ToList();

            Save(p, product.Code);
            
        }
        void Save(List<PictureDTO> pictures, string code)
        {
            int idproduct= Db.Products.Where(x=>x.Code == code).FirstOrDefault().Id;
            foreach (PictureDTO picture in pictures)
            {
                pictureRepository.Save(picture);
                var P=Db.Pictures.Where(x=>x.Code ==    picture.Code).FirstOrDefault();
                Db.PictureProducts.Add(new PictureProduct { PictureID =P.Id, ProductID = idproduct });
                Db.SaveChanges();           
            }



        }
        public void Update(ProductDTO entity, int id)
        {
            Product product=Db.Products.FirstOrDefault(x=>x.Id == id);              
            product.Code = entity.Code;
            product.Name = entity.Name;
            product.UnitCost = entity.UnitCost;
            product.Price = entity.Price;
            product.Description = entity.Description;
            product.CategoryId = entity.CategoryId;
            product.UnitMeasurementId = entity.UnitMeasurementId;
            Db.Products.Update(product  );
            Db.SaveChanges();
        }
    }
}
