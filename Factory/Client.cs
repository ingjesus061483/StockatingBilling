using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Index(nameof(Identification), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]

    public class Client
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Identification { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        public int IdentificationTypeId { get; set; }
        public IdentificationType IdentificationType { get; set; }

    }
}
