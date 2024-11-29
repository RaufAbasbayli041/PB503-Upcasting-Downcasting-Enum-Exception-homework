using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Enum__Exception_homework_2
{
    public class Car
    {
        private static int _count;
        private int Id;
        public string Brand;
        public string Model;
        public Type Type;
       
        public Car()
        {
            Id = ++_count;          
        }

        public override string ToString()
        {
            return $"{Id} - {Brand} - {Model} - {Type}";
        }


    }
}
