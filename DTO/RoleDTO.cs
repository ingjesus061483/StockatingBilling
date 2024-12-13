using Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class RoleDTO
    {
            public int Id { get; set; }

            [Required]
            [StringLength(50)]
            public string Name { get; set; }

            public string Description { get; set; }

            public List<User> Users { get; set; }
        

    }
}
