using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1200.Models
{
    internal class Planet
    {
        public string Name { get; set; }
        public double Area { get; set; }
        public Country[] Countries = new Country[0];
        public Planet(string name, double area)
        {
            Name = name;
            Area = area;
        }
        public void CreateCountry(string countryName, double area, string anthem, string region)
        {
            for (int i = 0; i < Countries.Length; i++)
            {
                if (Countries[i] == null)
                {
                    Countries[i] = new Country(countryName, area, anthem, region);
                }
            }
        }
        public bool UpdateCountry(int id, string newcountryName, double newarea, string newanthem, string newregion)
        {
            for (int i = 0; i < Countries.Length; i++)
            {
                if (Countries[i].Id == id)
                {
                    Countries[i].CounrtyName = newcountryName;
                    Countries[i].Area = newarea;
                    Countries[i].Anthem = newanthem;
                    Countries[i].Region = newregion;
                    return true;
                }
            }
            return false;
        }
        public void RemoveCountry(string countryName)
        {
            int index = -1;
            for (int i = 0; i < Countries.Length; i++)
            {
                if (Countries[i].CounrtyName == countryName)
                {
                    index = i; break;
                }
            }
            if (index == -1) 
            {
                Console.WriteLine("Bu olke yoxdur");
                return;
            }
            for (int i = index; i < Countries.Length-1; i++)
                {
                    Countries[i] = Countries[i + 1];
                }
            Array.Resize(ref Countries, Countries.Length - 1);
            Console.WriteLine($"{countryName} bu nomreli id silindi");
        }
        public void GetAllCountries()
        {
            if (Countries.Length == 0)
            {
                Console.WriteLine("Olke yoxdur");
                return;
            }
            foreach (var i in Countries)
            {
                Console.WriteLine(i);
            }
        }
        public void GetCountryByRegion(Regiontype regiontype)
        {
            bool found = false;
            foreach (var country in Countries)
            {
                if (country.Regiontype == regiontype)
                {
                    country
                }
            }
        }
    }
}
    
