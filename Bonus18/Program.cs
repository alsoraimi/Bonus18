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
            bool loop = true;
            do
            {
                Console.Title = "Welcome to the Grand Circus Motors admin console!!!";  // makes title for entire console

                Console.WriteLine("How many cars are you entering? ");
                int numCars = int.Parse(Console.ReadLine());


                List<CarClass> CarList = new List<CarClass>(numCars);   //added so user can input more than one vehicle

                for (int i = 0; i < numCars; i++)
                {
                    Console.WriteLine("\nWould you like to enter data for Car {0}? (y = yes n = continue)", i + 1);
                    string defaultCar = Console.ReadLine().ToLower();

                    if (defaultCar == "y")
                    {

                        CarClass Car = new CarClass();     // creates new class per new user input for car
                        Console.WriteLine("Please enter Make of Car");
                        Car.MakeofCar = Console.ReadLine();
                        Console.WriteLine("Please Enter Model of Car");
                        Car.ModelofCar = Console.ReadLine();
                        Car.YearofCar = int.Parse(GetValidYear());
                        Car.PriceofCar = double.Parse(GetValidPrice());
                        CarList.Add(Car);

                    }
                    else if (defaultCar == "n")
                    {
                        CarClass Car = new CarClass();
                        CarList.Add(Car);
                    }
                    else
                    {
                        Console.WriteLine("ERROR INVALID INPUT");
                        break;
                    }

                }
                Console.Clear();
                Console.WriteLine("Car Data:");
                Console.WriteLine("Year\tMake\tModel\tPrice");
                foreach (CarClass item in CarList)
                // foreach to loop through items in CarList and outputs them
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t${3}.", item.YearofCar, item.MakeofCar, item.ModelofCar, item.PriceofCar);
                }
                if (!ContinueLoop())
                {
                    loop = false;
                }

            } while (loop);
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

        public static bool ContinueLoop()
        {
            while (true)
            {
                Console.WriteLine("Would you like to go again, ? (Y/N)"); // add user input if they want to try again
                string input = Console.ReadLine().ToUpper();
                if (input == "Y")
                {
                    Console.WriteLine();
                    return true;
                }

                else if (input == "N")
                {
                    Console.WriteLine("thanks for trying!");
                    return false;
                }
                else
                {
                    Console.WriteLine("ERROR, ENTER Y OR N");

                }
            }

        }
    }
}



