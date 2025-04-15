using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umumi_TaskLar_Vehicle.Models
{
    public class Car : Vehicle
    {
        private int _doorsnum;
        public int DoorsNum
        {
            get
            {
                return _doorsnum;
            }
            set
            {
                if (value > 0 && value < 5)
                {
                    _doorsnum = value;
                }
                else
                {
                    throw new ArgumentException("Qapin sayi 0 dan boyuk, 5 den kicik olmalidir.");
                }
            }
        }
        public Car(string brand, string model, double mile, int doorsNum) : base(brand, model, mile)
        {
            DoorsNum = doorsNum;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand},  Model: {Model}, Mile: {Mile}, DoorsNum: {DoorsNum}");
        }


    }
}
