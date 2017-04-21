using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class CarClass
    {
        #region
        private string Make;
        private string Model;
        private int Year;
        private double Price;
        #endregion

        public string MakeofCar
        {
            set
            {
                Make = value;
            }
            get
            {
                return Make;
            }
        }
        public string ModelofCar
        {
            set
            {
                Model = value;
            }
            get
            {
                return Model;
            }
        }
        public int YearofCar
        {
            set
            {
                Year = value;
            }
            get
            {
                return Year;
            }
        }
        public double PriceofCar
        {
            set
            {
                Price = value;
            }
            get
            {
                return Price;
            }
        }
        public CarClass (string MakeofCarInput, 
            string ModelofCarInput,
            int YearofCarInput,
            double PriceofCarInput)
        {

            Make = MakeofCarInput;
            Model = ModelofCarInput;
            Year = YearofCarInput;
            Price = PriceofCarInput;
        }
        public CarClass()
        {
            Make = Console.ReadLine();
            Model = Console.ReadLine();
            Year = Console.ReadLine();
            Price = Console.ReadLine();

        }


    }
}
