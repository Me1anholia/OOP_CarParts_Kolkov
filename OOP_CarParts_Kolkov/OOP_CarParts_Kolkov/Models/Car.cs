using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CarParts_Kolkov.Models
{
    internal class Car
    {
        public string brand {  get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public Car() 
        {
            
        }
        public Car (string b, string m, int y)
        {
            string brand = b;
            string model = m;
            int year = y;
        }
        

    }
}
