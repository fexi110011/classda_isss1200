using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umumi_Tasklar
{
    internal class Human
    {
        private int _age;
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age {
            get 
            {
                return _age;
            } 
            set 
            {
                if ( value>=17 && value<=30)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Duzgun daxil edinnn!");
                }
            } 
        }
        public Human(string name, string surname, int age)
        {
            Name = name;
            SurName = surname;
            Age = age;
        }
        public void ShowFullDate()
        {
            Console.WriteLine($"Name: {Name}, SurName: {SurName}, Age: {Age}");
        }
        public void GetFullName()
        {
            Console.WriteLine($"Name: {Name}, SurName: {SurName}");
        }

    }
}
