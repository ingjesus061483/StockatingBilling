using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IRepository<T>
    {
        StockatingDbContext Db { get; set; }

        IQueryable<T> Values { get; }
        T GetById(int id);
        void Update(T entity ,int id);
        void DeleteById(int id);
        void Save(T entity );
    }
}
