using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
 public  interface IOperation<T>
    {
        abstract void Print(T entity);
        abstract void Export(Dictionary<string, Array > entities);
    }
}
