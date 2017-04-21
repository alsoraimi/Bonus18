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

            Console.Title ="Welcome to the Grand Circus Motors admin console!!!";  // makes title for entire console
            Console.WriteLine();
            CarClass Car1 = new CarClass();
            Console.WriteLine("Enter Make of Car");   
            Car1.MakeofCar = Console.ReadLine();       //input for make of car, no validation because it can contain both letters and numbers, same with model
            Console.WriteLine("Enter Model of Car");
            Car1.ModelofCar = Console.ReadLine();     //gets input for model
            Car1.YearofCar = int.Parse(GetValidYear()); //gets valid input for year
            Car1.PriceofCar = double.Parse(GetValidPrice()); //gets valid input for price
            Console.Clear();

            Console.WriteLine("Current Inventory: ");
            Console.WriteLine();

            // prints input from user on same line using spaces
            Console.WriteLine(Car1.MakeofCar + "        " + Car1.ModelofCar + "         " + Car1.YearofCar + "         " + "$" + Car1.PriceofCar);
            Console.WriteLine();
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

        }  //validation for year

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
        }  //validation for price

    }
    }



