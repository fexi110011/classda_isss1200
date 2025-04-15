using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umumi_TaskLar_Vehicle.Models
{
    public class Vehicle
    {
        private string _brand;
        public string Brand { get; set; }
        public string Model { get; set; }
        private double _mile;
        public double Mile { 
            get
            {
                return _mile;
            } 
            set 
            { 
                if ( value > 0)
                {
                    _mile = value;
                }
                else
                {
                    throw new ArgumentException("Mile 0 dan boyuk olmalidir.");
                }
            }
        }
        public Vehicle(string brand, string model,double mile)
        {
            if (brand.Length > 3 && brand.Length < 30)
                throw new ArgumentException("Brand uzunlugu 3 den boyuk, 30 dan kicik olmalidir.");
            if (model.Length > 3 && model.Length < 30)
                throw new ArgumentException("Brand uzunlugu 3 den boyuk, 30 dan kicik olmalidir.");
            Brand = brand;
            Model = model;
            Mile = mile;
        }
    }
}
