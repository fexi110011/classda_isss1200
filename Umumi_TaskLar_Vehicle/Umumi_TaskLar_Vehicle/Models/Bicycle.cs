using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Umumi_TaskLar_Vehicle.Models
{
    public class Bicycle:Vehicle
    {
        private int _wheelnum;
        public int WheelNum
        {
            get
            {
                return _wheelnum;
            }
            set
            {
                if (value > 0 && value < 5)
                {
                    _wheelnum = value;
                }
                else
                {
                    throw new ArgumentException("Teker sayi 0 dan boyuk, 5 den kicik olmalidir.");
                }
            }
        }
        public Bicycle(string brand, string model, double mile, int wheelNum) : base(brand, model, mile)
        {
            WheelNum = wheelNum;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand},  Model: {Model}");
        }
    }
}
