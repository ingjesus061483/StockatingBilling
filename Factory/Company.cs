using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Factory
{
    [Index(nameof(Nit ), IsUnique = true)]

    public class Company
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Nit { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(50)]
        public string TradeCamera { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Direction { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Contact { get; set; }
       
        public string slogan { get; set; }

        [Required]
        public int  RegimenTypeId     { get; set; }
        public RegimenType RegimenType { get; set; }    

        public List <User> Users { get; set; }  
    }
}
