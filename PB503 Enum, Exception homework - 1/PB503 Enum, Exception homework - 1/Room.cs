using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Enum__Exception_homework___1
{
    public class Room
    {
        private static int _count;
        private int _id;
        public int Id { get { return _id; } }
        public string Name;
        public double Price;
        public int PersonCapacity;
        public bool IsAvailabe = true;

        public Room()
        {
            _id = ++_count;
        }
               

        public void ShowInfo()
        {
            Console.WriteLine($"{_id} - {Name} - {Price} - {PersonCapacity}");
        }


        public override string ToString()
        {
            return $"{Id} - {Name} - {Price} - {PersonCapacity}";
        }
    }
}
