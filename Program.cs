using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_a1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listtal = new List<int>() { 4, 7, 12, 17, -3, 8, 0, -45, 101 };



            List<int> nyListe = listtal.Where(number => number <= 0).ToList();
            List<int> nyliste2 = listtal.Where(number => number == 7).ToList();
            List<int> nyliste3 = listtal.Where(number => number >= 4).ToList();

            UdskrivList(nyListe);
            UdskrivList(nyliste2);
            UdskrivList(nyliste3);


            List<Car> cars = new List<Car>
            {
                 new Car(1, "Rio", "Kia", 2006, 250000, "Red"),
                 new Car(2, "Rio", "Kia", 2007, 265000, "Black"),
                 new Car(3, "Panda", "Fiat", 2017, 256000, "Black"),
                 new Car(4, "Panda", "Fiat", 2017, 365000, "Yellow"),
                 new Car(5, "S40", "Volvo", 2018, 665000, "White"),
                 new Car(6, "S65", "Volvo", 2018, 600000, "White"),
                 new Car(7, "Gorm", "Ferrari", 2000, 4665000, "White"),
                 new Car(8, "Gorm", "Ferrari", 2018, 4665000, "White"),
            };

            List<Car> modelRio = cars.Where(car => car.Model == "Rio").ToList();
            List<Car> BrandFerrair = cars.Where(car => car.Brand == "Ferrari").ToList();
            List<Car> Fra2010 = cars.Where(car => car.Year >=2010).ToList();
            List<Car> HvideBIler = cars.Where(car => car.Coler == "White").ToList();
            Car onecar = cars.SingleOrDefault(Car => Car.Id == 8);

            WriteList(modelRio);
            WriteList(BrandFerrair);
            WriteList(Fra2010);
            WriteList(HvideBIler);
            WriteList(onecar);



            Console.ReadKey();
        }
        // opgave A
        private static void UdskrivList(List<int> listtal)
        {
            foreach (var item in listtal)
            {
                Console.Write(item + " , ");
            }
            Console.WriteLine();

        }
        //opgave B
        static void WriteList(List<Car> cars)
        {
            foreach(Car car in cars)
            {
                Console.WriteLine(CarString(car));
            }
            Console.WriteLine();
        }

        static void WriteList(Car car)
        {
            Console.WriteLine(CarString(car));
            Console.WriteLine();
        }
        static string CarString(Car car)
        {
            return $"ID: {car.Id} | {car.Brand} {car.Model} ({car.Year}) | Price: {car.Price:C} | Color: {car.Coler}";
        }
    }
}
