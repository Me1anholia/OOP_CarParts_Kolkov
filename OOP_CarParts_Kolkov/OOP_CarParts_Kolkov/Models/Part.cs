using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CarParts_Kolkov.Models
{
    internal class Part
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
        public List<Car> CompatibleCars { get; set; }

        public Part()
        {
            CompatibleCars = new List<Car>();
        }
        public Part(string id, string name, string manufacturer, decimal price, int quantityInStock)
        {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            QuantityInStock = quantityInStock;
            CompatibleCars = new List<Car>();
        }
        /// <summary>
        /// Додає сумістний автотобіль до деталі
        /// </summary>
        /// <param name="car"></param>
        public void AddCar(Car car)
        {
            if (car != null)
            {
                CompatibleCars.Add(car);
            }
        }
        /// <summary>
        /// Видаляє сумістний автотобіль до деталі
        /// </summary>
        /// <param name="car"></param>
        public void RemoveCar(Car car)
        {
            if (car != null)
            {
                CompatibleCars.Remove(car);
            }
        }
        public bool IsComatibleWith(string brand, string model, int year)
        {
            for (int i = 0; i < CompatibleCars.Count; i++)
            {
                if (CompatibleCars[i].brand == brand && CompatibleCars[i].model == model && CompatibleCars[i].year == year)
                    {
                        return true;
                    }
            }
            return false;
        }

        public string GetCompatibilityList()
        {
            if (CompatibleCars.Count == 0)
            {
                return "Немає сумісних авто";
            }

            string result = "";
            for (int i = 0; i < CompatibleCars.Count; i++) 
            {
                result += CompatibleCars[i].brand + " " + CompatibleCars[i].model + " " + CompatibleCars[i].year;

                if (i < CompatibleCars.Count - 1)
                {
                    result += ", ";
                }
            }
            return result;
        }

    }
}
