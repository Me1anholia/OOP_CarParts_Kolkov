using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CarParts_Kolkov.Models
{
    internal class CatalogManager
    {
        public List<Part> Parts { get; set; }
        
        public CatalogManager() 
        {
            Parts = new List<Part>();
        }
        public List<Part> FindPartForCar(string brand, string model, int year)
        {
            List<Part> foundParts = new List<Part>();
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].IsComatibleWith(brand, model, year))
                {
                    foundParts.Add(Parts[i]);
                }
            }
            return foundParts;
        }

        public bool RemovePartById(string Id)
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].Id == Id)
                {
                    Parts.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}
