using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Index(nameof(Code), IsUnique = true)]
    public class Picture
    {
        public int Id {  get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public byte[] Data { get; set; }
       [ NotMapped]
     public    List<Product> Products { get; set; }

   


    }
}
