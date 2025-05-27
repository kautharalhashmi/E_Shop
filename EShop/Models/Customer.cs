using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

   
        public string Name { get; set; }

       
        public string Email { get; set; }

       
        public string ContactInfo { get; set; }
    }
}
