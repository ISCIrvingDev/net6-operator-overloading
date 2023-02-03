using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.Models
{
    public class Product
    {
        public string? Description { get; set; }
        public decimal Price { get; set; }

        public static Product operator +(Product product, Beer beer) {
            product.Price = beer.Price;
            product.Description = $"The product is {beer.Name} from the {beer.Brand} brand";

            return product;
        }
    }
}
