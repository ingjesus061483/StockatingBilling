using DTO;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class StateRepository : IRepository<StateDTO>
    {
        public StockatingDbContext Db { get ; set ; }
        public StateRepository(StockatingDbContext db) { 
            Db = db ; 
        }

        public IQueryable<StateDTO> Values =>Db.States.Select(x=>new StateDTO { 
            Id=x.Id,
            Name =x.Name,
            Description =x.Description
        }) ;

        public void DeleteById(int id)
        {
            State state = Db.States.FirstOrDefault(x=>x.Id==id);
            Db.States.Remove(state);
            Db.SaveChanges();
        }

        public StateDTO GetById(int id) => Values.Where(x => x.Id == id).FirstOrDefault();
        
        public void Save(StateDTO entity)
        {
            State state = new State
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
            };
            Db.States.Add(state);
            Db.SaveChanges();
        }

        public void Update(StateDTO entity, int id)
        {
            State entityState = Db.States.FirstOrDefault(x=>x.Id==id);
            entityState.Name = entity.Name;
            entityState.Description = entity.Description;
            Db.Update(entityState);
            Db.SaveChanges();
        }
    }
}
