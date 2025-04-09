using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1200.Models
{
    internal class Country
    {
        public int Id { get; set; }
        private static int _id;
        public string CounrtyName { get; set; }
        public double Area { get; set; }
        public string Anthem { get; set; }
        public Regiontype Regiontype { get; set; }
        public Country(string countryname, double area,string anthem,Regiontype type)
        {
            CounrtyName = countryname;
            Area = area;    
            Anthem = anthem;
            Regiontype = type;
            Id = _id++;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"CounrtyName: {CounrtyName}, Area: {Area}, Anthem: {Anthem}, Region: {Region}");
        }
    }
}
