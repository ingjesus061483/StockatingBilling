using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    [Index (nameof(Code),IsUnique =true)]
    public class BillHeader
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }

       

        [Required]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Required]
        public int StateId {  get; set; }
        public State  State { get; set; }

       public  List<BillDetail> BillDetails {  get; set; }

        public string? Remark {  get; set; }


        public bool Credit { get; set; }

        public decimal Total { get { return BillDetails.Sum(x => x.Total);  } }


    }
}
