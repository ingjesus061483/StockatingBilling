﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Index(nameof(Name ), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]

        public string Name { get; set; }

        [Required]
        [StringLength(50)]

        public string Email { get; set; }

        [Required]
        [StringLength(255)]
       public string Password { get; set; }
     
        [Required]
        public int RoleId {  get; set; }
        public Role Role { get; set; }

        public int Companyid {  get; set; }
        public Company Company { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
