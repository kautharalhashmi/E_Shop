using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Models
{
    public class ShippingAddress
    {
        public int ShippingAddressID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        [MaxLength(20)]
        public string PostalCode { get; set; }
    }

}
