using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        public string Comments { get; set; }
    }

}
