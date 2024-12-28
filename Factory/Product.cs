using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        public decimal UnitCost {  get; set; }

        [Required]        
        public decimal Price { get; set; }
        
        public string? Description{get; set;}

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required ]
        public int UnitMeasurementId {  get; set; }
        public UnitMeasurement UnitMeasurement { get; set; }

        [NotMapped]
        List<Picture> Picture { get; set; }
        
        public List<Stock> Stocks { get; set; }

    }
}
