using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PictureDTO
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
       
        public int ProductId {  get; set; }
       public Product Product { get; set; }

    }
}
