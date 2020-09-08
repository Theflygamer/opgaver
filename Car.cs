using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_a1
{
    class Car
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Brand { get; set; }

        public int Year { get; set; }

        public int Price { get; set; }

        public string Coler { get; set; }

        public Car(int id, string model, string brand, int year, int price, string coler ) 
        {
            Id = id;
            Model = model;
            Brand = brand;
            Year = year;
            Price = price;
            Coler = coler; 



        }
    }
}
