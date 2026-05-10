using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CarParts_Kolkov.Models
{
    internal class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public int QuantityInStock { get; set; }
        public List<Car> CompatibleCars { get; set; }

        public Part() 
        {
            CompatibleCars = new List<Car>();
        }
        public Part(int id, string name, string manufacturer, int price, int quantityInStock)
        {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            QuantityInStock = quantityInStock;
            CompatibleCars = new List<Car>();
        }
    }
}
