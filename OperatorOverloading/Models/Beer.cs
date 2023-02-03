using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading.Models
{
    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        public Beer(string name, string brand, decimal price)
        {
            Name = name;
            Brand = brand;
            Price = price;
        }
    }
}
