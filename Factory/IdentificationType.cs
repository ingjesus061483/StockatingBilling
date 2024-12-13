using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class IdentificationType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Employee >Employees { get; set; }
        public List<Client > Clients { get; set; }
        public List<Provider> Providers { get; set; }
    }
}
