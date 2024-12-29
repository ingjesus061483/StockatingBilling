using Factory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class PictureRepository : IRepository<PictureDTO>
    {
        public StockatingDbContext Db { get; set ; }

        public IQueryable<PictureDTO> Values => Db .PictureProducts.Include(pp=>pp.Picture)
                                                   .Include(pp=>pp.Product)
                                                   .Select(x=>new PictureDTO
                                                   {
                                                       Id = x.Picture.Id,
                                                       Code = x.Picture.Code,
                                                       Name = x.Picture.Name,
                                                       Type = x.Picture.Type,
                                                       Data = x.Picture.Data,
                                                       ProductId = x.ProductID,
                                                       Product = x.Product,
                                                   }) ;

        public PictureRepository(StockatingDbContext inventarioDbContext) 
        {
            Db = inventarioDbContext;
        }
        public void DeleteById(int id)
        {
           var picture= Db.Pictures.Where(x => x.Id == id).FirstOrDefault();
            Db.Pictures.Remove(picture);
            Db.SaveChanges();
        }

        public PictureDTO GetById(int id)=> Values.Where(x=>x.Id==id).FirstOrDefault();
        

        public void Save(PictureDTO entity)
        {
            var picture = new Picture
            {
                Code = entity.Code,
                Name = entity.Name,
                Type = entity.Type,
                Data = entity.Data,

            };
            Db.Pictures. Add(picture);
            Db .SaveChanges();
            Save(entity.Code ,entity.ProductId);

        }
        void Save(string code , int productId)
        {
            var P = Db.Pictures.Where(x => x.Code == code).FirstOrDefault();
            Db.PictureProducts.Add(new PictureProduct { PictureID = P.Id, ProductID = productId });
            Db.SaveChanges();
        }
        public void Update(PictureDTO entity, int id)
        {
           var picture=Db.Pictures.Where(x=>x.Id== id).FirstOrDefault();
            picture.Name = entity.Name;
            picture.Type = entity.Type;
            picture.Data = entity.Data;
            Db .Pictures.Update(picture);
            Db.SaveChanges() ;
            
        }
    }
}
