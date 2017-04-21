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
            Car1.ModelofCar = Console.ReadLine();
            Console.WriteLine("Enter Model of Car");
            Car1.MakeofCar = Console.ReadLine();
            Console.WriteLine("Enter Year of Car");
            Console.WriteLine("Please enter price of car"); 
            Car1.PriceofCar = double.Parse(Console.ReadLine());


            Console.WriteLine("Make of car is: " + Car1.MakeofCar);
            Console.WriteLine();
            Console.WriteLine("Model of car is: " + Car1.ModelofCar);
            Console.WriteLine();
            Console.WriteLine("Year of Car is: " + Car1.YearofCar);
            Console.WriteLine();
            Console.WriteLine("price of car is: " +Car1.PriceofCar);
            



        }
    }
}
