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
 public  class CompanyRepository : IRepository<CompanyDTO>
    {
        public StockatingDbContext Db { get ; set ; }
        public CompanyRepository(StockatingDbContext db)
        {
            Db = db;
        }

        public IQueryable<CompanyDTO> Values => Db.Companies.Include(x=>x.RegimenType).Select(x=> new CompanyDTO 
        {
            Id = x.Id,
            Name = x.Name,
            Address = x.Address,
            Phone = x.Phone,
            Contact=x.Contact,
            TradeCamera = x.TradeCamera,
            Slogan = x.Slogan,
            Email=x.Email,
            Nit=x.Nit,
            RegimenType = x.RegimenType,
            RegimenTypeId = x.RegimenTypeId,
        }) ;

        public void DeleteById(int id)
        {
           Company company= Db.Companies.Where( x => x.Id == id ).FirstOrDefault();
            Db.Companies.Remove(company);
            Db.SaveChanges();
            
        }

        public CompanyDTO GetById(int id)=>Values.Where(x=>x.Id == id).FirstOrDefault();
        

        public void Save(CompanyDTO entity)
        {
            Company company = new Company
            {
                Name = entity.Name,
                Address = entity.Address,
                Phone = entity.Phone,
                Contact = entity.Contact,
                TradeCamera = entity.TradeCamera,
                Slogan = entity.Slogan,
                Email = entity.Email,
                Nit = entity.Nit,
                RegimenTypeId = entity.RegimenTypeId,

            };
            Db.Companies.Add(company);
            Db.SaveChanges();
        }

        public void Update(CompanyDTO entity, int id)
        {
            Company company=Db.Companies .Where(x=> x.Id == id).FirstOrDefault();   
            company.Address = entity.Address;
            company.Phone = entity.Phone;
            company.Contact = entity.Contact;
            company.Nit = entity.Nit;
            company.Name = entity.Name;
            company.Email = entity.Email;
            company.Slogan = entity.Slogan;
            company.RegimenTypeId = entity.RegimenTypeId;
            Db.Companies .Update(company);
            Db.SaveChanges();            
        }
    }
}
