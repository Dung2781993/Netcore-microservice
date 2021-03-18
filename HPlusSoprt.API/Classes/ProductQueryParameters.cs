using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPlusSoprt.API.Classes
{
    public class ProductQueryParameters : QueryParameters
    {
        public string Sku { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public String Name { get; set; }
    }
}
