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
    public class CategoryRepository : IRepository<CategoryDTO>
    {
        public CategoryRepository(StockatingDbContext context) 
        {
            Db = context;
        }
        public IQueryable<CategoryDTO> Values => Db.Categories.Select(x=> new CategoryDTO { 
            Id = x.Id,
            Name = x.Name,
            Description = x.Description,
        });

        public StockatingDbContext Db { get; set; }

        public void DeleteById(int id)
        {
            Category category = Db.Categories.Where(x => x.Id == id).FirstOrDefault();
            if (category != null)
            {
                Db.Categories.Remove(category);
                Db.SaveChanges();
            }
   
        }

        public CategoryDTO GetById(int id)=> Values.Where(x => x.Id == id).FirstOrDefault();        

        public void Save(CategoryDTO entity)
        {
            Category category = new()
            {
                Name = entity.Name,
                Description = entity.Description,

            };
            Db.Categories.Add(category);
            Db.SaveChanges();
        }

        public void Update(CategoryDTO entity, int id)
        {
            Category category=Db.Categories.Where(x=>x.Id == id).FirstOrDefault();
            category.Name = entity.Name;
            category.Description = entity.Description;
            Db.Categories.Update(category);
            Db.SaveChanges();

        }
    }
}
