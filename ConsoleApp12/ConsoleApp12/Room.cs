using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Room
    {
        public int Id { get; set; }
        public static int Count = 0;
        public string Name { get; set; }
        public int Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAviable = true;
        public Room(string name,int price, int personcapacity)
        {
            if (string.IsNullOrEmpty(name)) 
                throw new ArgumentNullException("Ad hissesi bos ola bilmez");
            if (price > 0)
                throw new ArgumentException("Price 0 dan boyuk olmalidir");
            if (personcapacity > 0)
                throw new ArgumentNullException("Person capacity 0 dan boyuk olmalidir");
            Count++;
            Id = Count;
            Name = name; 
            Price = price;
            PersonCapacity = personcapacity;
        }
        public string ShowInfo()
        {
            return $"Id_{Id},  Name: {Name}, Price: {Price}, PersonCapacity: {PersonCapacity}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
