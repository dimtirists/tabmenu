using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabMenu
{
    class Product
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Size { get; set; }

        public Product(string brand, string model, int size)
        {
            Brand = brand;
            Model = model;
            Size = size;
        }
        
    }
}
