using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Enum__Exception_homework___1
{
    public class Hotel
    {
        public string Name;

        private Room[] _rooms = Array.Empty<Room>();

        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            _rooms[^1] = room;
        }

        public Room MakeReservation(int? roomId)
        {

            if (roomId == null)
            {
                throw new NullReferenceException("nulldi");
            }
            if (roomId > _rooms.Length || roomId < 1)
            {
                throw new Exception("Error");
            }

            foreach (Room room in _rooms)
            {
                if (room.Id == roomId)
                {
                    if (!room.IsAvailabe)
                    {
                        throw new NotAvailableException("not available");
                    }
                }
            }
            throw new Exception("is Available");


        }
    }
}
