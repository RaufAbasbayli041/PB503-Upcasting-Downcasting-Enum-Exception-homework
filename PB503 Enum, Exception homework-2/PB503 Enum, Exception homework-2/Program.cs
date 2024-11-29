namespace PB503_Enum__Exception_homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car()
            { 
                Brand = "car1 brand",
                Model = "car1 model",
                Type = Type.Sport,
            };

            Car car2 = new Car()
            {
                Brand = "car2 brand",
                Model = "car2 model",
                Type = Type.Sedan,
            };

            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());
            
        }
    }
}
