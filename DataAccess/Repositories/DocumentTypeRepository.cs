using DTO;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class DocumentTypeRepository : IRepository<DocumentTypeDTO>
    {
        public StockatingDbContext Db { get ;set ; }

        public IQueryable<DocumentTypeDTO> Values => Db.DocumentTypes.Select(x=>new DocumentTypeDTO 
        {
            Id = x.Id,
            Name = x.Name,
            Description = x.Description,

        });
        public DocumentTypeRepository (StockatingDbContext db)
        {
            Db = db;
        }
        public void DeleteById(int id)
        {
          DocumentType documentType=Db.DocumentTypes.FirstOrDefault (x=>x.Id==id);
            Db.DocumentTypes .Remove(documentType);
            Db.SaveChanges();
        }

        public DocumentTypeDTO GetById(int id) => Values.FirstOrDefault(x => x.Id == id);
        

        public void Save(DocumentTypeDTO entity)
        {
            DocumentType documentType = new DocumentType
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,

            };
           Db.DocumentTypes.Add(documentType);
            Db.SaveChanges();
        }

        public void Update(DocumentTypeDTO entity, int id)
        {
            DocumentType documentType = Db.DocumentTypes.FirstOrDefault(x => x.Id == id);
            documentType.Name = entity.Name;
            documentType.Description = entity.Description;
            Db.DocumentTypes .Update(documentType);
            Db.SaveChanges();
        }
    }
}
