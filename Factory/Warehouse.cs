﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
namespace Factory
{
    [Index(nameof(Code), IsUnique = true)]
    public class Warehouse
    {       
        public int  Id {  get; set; }

        [Required]
        [StringLength(50)]
        public string Code {  get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } 
        
        public bool limitado {  get; set; }
        
        public string? Descripcion {  get; set; }
        
        public int StockMinimo {  get; set; }
        
        public int StockMaximo {  get; set; }

        List<Stock> Stocks { get; set; }
        public List<BillDetail > BillDetails  { get; set; }

    }
}
