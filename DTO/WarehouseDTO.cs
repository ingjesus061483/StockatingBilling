using Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WarehouseDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool limitado { get; set; }

        public string Descripcion { get; set; }

        public int StockMinimo { get; set; }

        public int StockMaximo { get; set; }

        List<Stock> Stocks { get; set; }

        public string Reference 
        { 
            get
            {
                return Code +" - "+ Name ;
            } 
        }
    }
}
