using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Program
    {
        static void Main(string[] args)
        {
            CarClass Car1 = new CarClass();
            Console.WriteLine("Enter Make of Car");
            Car1.MakeofCar = Console.ReadLine();
            Console.WriteLine("Enter Model of Car");
            Car1.ModelofCar = Console.ReadLine();
            Car1.YearofCar = int.Parse(GetValidYear());
            Car1.PriceofCar = double.Parse(GetValidPrice());
            Console.Clear();

            Console.WriteLine("Current Inventory: ");
            Console.WriteLine();


            Console.WriteLine(Car1.MakeofCar + "        " + Car1.ModelofCar + "         " + Car1.YearofCar + "         " + Car1.PriceofCar);
            Console.WriteLine();
            //Console.WriteLine( Car1.ModelofCar);
            //Console.WriteLine();
            //Console.WriteLine( Car1.YearofCar);
            //Console.WriteLine();
            //Console.WriteLine(Car1.PriceofCar);




        }

        public static string GetValidYear()
        {


            int value;
            Console.WriteLine("Enter Year of Car");
            string YearofCar = Console.ReadLine();
            while (!int.TryParse(YearofCar, out value))
            {
                Console.WriteLine("ERROR, Please enter a valid number");
                YearofCar = Console.ReadLine();

            }
            return YearofCar;

        }

        public static string GetValidPrice()
        {


            double value;
            Console.WriteLine("Enter Price of Car");
            string PriceOfCar = Console.ReadLine();
            while (!double.TryParse(PriceOfCar, out value))
            {
                Console.WriteLine("ERROR, Please enter a valid number");
                PriceOfCar = Console.ReadLine();

            }
            return PriceOfCar;
        }

    }
    }



