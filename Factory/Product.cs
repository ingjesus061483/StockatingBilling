using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Factory
{
    [Index(nameof(Code), IsUnique = true)]
    public class Product
    {
        public int Id { get; set; }


        [Required]
        [StringLength(50)]        
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }        

        public decimal UnitCost {  get; set; }

        [Required]        
        public decimal Price { get; set; }
        


        public string Description{get; set;}
             
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public int UnitMeasurementId {  get; set; }
        public UnitMeasurement UnitMeasurement { get; set; }

        [NotMapped]
        List<Picture> Picture { get; set; }

       public List<Stock> Stocks { get; set; }

    }
}
