using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Stock
    {
        public int Id {  get; set; }

        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public bool Entrance { get; set; }

        public int WarehouseId {  get; set; }
        public Warehouse Warehouse {  get; set; }   
        
        public int ProductId {  get; set; }
        public Product Product { get; set; }   
    }
}
