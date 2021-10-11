using System;
namespace HotelManagement.ConsoleApp
{
    class Menu
    {
        public int Print(Type t)
        {
            string[] names = Enum.GetNames(t);
            int[] values = (int[])Enum.GetValues(t);
            int length = values.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Enter {values[i]} for {names[i]}");
            }
            Console.WriteLine("Input your choice = ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
