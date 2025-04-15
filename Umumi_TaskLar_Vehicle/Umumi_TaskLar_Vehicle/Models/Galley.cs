using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umumi_TaskLar_Vehicle.Models
{
    internal class Gallery
    {
        public List<Car> cars { get; set; }
        public string Name { get; set; }
        public Gallery(string name)
        {
            if(string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Ad bos ola bilmez");
            Name = name;
        }
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public List<Car> FilterCarsB(string brand)
        {

            List<Car> filtercars = new List<Car>();
            foreach(Car car in cars)
            {
                if(car.Brand.ToLower() == brand.ToLower())
                {
                    filtercars.Add(car);
                }
            }
            return filtercars;
            
        }
        public List<Car> FilterCarsM(double mile)
        {

            List<Car> filtercars = new List<Car>();
            foreach (Car car in cars)
            {
                if (car.Mile == mile)
                {
                    filtercars.Add(car);
                }
            }
            return filtercars;
        }
        public void AllCars()
        {
            foreach(Car car in cars)
            {
                Console.WriteLine(car.ShowInfo);
            }
        }
        

    }
}
