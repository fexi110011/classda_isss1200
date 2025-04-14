using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp12
{
    internal class Hotel
    {
        public int Id { get; set; }
        public static int Count = 0;
        public string Name { get; set; }
        public Hotel(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Ad hissesi bos ola bilmez");
            Count++;
            Id = Count;
            Name = name;
        }
        public List<Room> Rooms { get; set; }
        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
        public List <Room> FindAllRooms(Predicate<Room> match)
        {
            return Rooms.FindAll(match);
        }
        public void MakeReservation(int? roomId, int peopleCount)
        {
            if(roomId == null) 
                throw new NullReferenceException("Otaq id Null ola bilmez");
            Room room = Rooms.Find(r=>r.Id == roomId);
            if(room == null)
            {
                throw new System.Exception("Bu ID de otaq yoxdu");
            }
            if (!room.IsAviable)
            {
                throw new FormatException("Bu otaq artik rezerv olunub");
            }
            if( peopleCount>room.PersonCapacity)
            {
                throw new System.Exception("Bu otaq bu qeder adam ucun uygun deyil");
            }

            room.IsAviable = false;
            Console.WriteLine("Otaq rezerv olundu");
        }
        public void ShowAllRoom()
        {
            if (Room.Count == 0)
            {
                Console.WriteLine("Bu otel de yer yoxdur");
            }
            foreach (Room room in Rooms)
            {
                Console.WriteLine(room);
            }
        }

    }
}
