using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Models
{
    public class PaymentInformation
    {
        public int PaymentInformationID { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public string PaymentMethod { get; set; }

      
        public string CardNumber { get; set; }

        public DateTime ExpirationDate { get; set; }

        [MaxLength(5)]
        public string CVV { get; set; }
    }

}
