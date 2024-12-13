using Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public decimal UnitCost { get; set; }

        [Required]
        public decimal Price { get; set; }

        public List<Picture>  Images { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int UnitMeasurementId { get; set; }
        public UnitMeasurement UnitMeasurement { get; set; }
        
        public    List<Stock> Stocks { get; set; }
        public  decimal Entrance 
        {
            get
            {
                return Stocks.Where(x => x.Entrance && x.ProductId == Id).Sum(x => x.Amount);
            }
        }
        public decimal Out
        {
            get 
            {
                return Stocks.Where(x =>!x.Entrance && x.ProductId == Id).Sum(x => x.Amount);
            }
        }
        public decimal Total
        {
            get
            {
                return Entrance- Out;
            }
        }
        public string Reference
        {
            get
            {
                return Code + " - " + Name;
            }
        }
    }
}
