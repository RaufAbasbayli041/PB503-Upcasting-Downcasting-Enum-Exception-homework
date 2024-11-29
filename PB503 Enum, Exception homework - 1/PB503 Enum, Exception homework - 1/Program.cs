namespace PB503_Enum__Exception_homework___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room()
            {
                Name = "room1",
                Price = 1.1,
                PersonCapacity = 1,
            };

            Room room2 = new Room()
            {
                Name = "room2",
                Price = 2.2,
                PersonCapacity = 2,
                
            };
            Room room3 = new Room()
            {
                Name = "room3",
                Price = 3,
                PersonCapacity = 3,
                
            };

            Hotel hotel = new Hotel()
            {
                Name = "hotel1"
            };

            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            hotel.AddRoom(room3);
                        
                                  
            room2.IsAvailabe = false;
            try
            {
                hotel.MakeReservation(3);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
