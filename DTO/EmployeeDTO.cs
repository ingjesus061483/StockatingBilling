using Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public class EmployeeDTO
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
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int IdentificationTypeId { get; set; }
        public IdentificationType IdentificationType { get; set; }


        public string CompleteName { get { return Name + " " + LastName; } }



    }
}
