using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Payment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public decimal SubTotal { 
            get 
            {
                return BillHeader.Total;
            }
        }

      public   List<Tax >   Taxes { get; set; }

        decimal _TotalTax; 
        [Required]
        public decimal Tax { 
            get 
            {
                if (Company .RegimenTypeId  == 2)
                {
                    _TotalTax = 0;
                    foreach (Tax  item in Taxes )
                    {
                        decimal calculo = (SubTotal * item.Value ) / 100;
                        _TotalTax += calculo;
                    }
                }
                return _TotalTax;
            }
        }

        [NotMapped]        
        public Company Company { get; set; }


        [Required]
        public decimal Discount { get; set; }

        [Required]
        public decimal TotalPay { 
            get 
            {
                return 0;
            }
        }
        List<DetailPay> DetailPays { get; set; }

        [Required]
        public decimal ValueReceived { get; }

        [Required]
        public decimal Change { get; }

        [Required]
        public int BillHeaderId { get; set; }
        public BillHeader BillHeader {get; set;}

    }
}
