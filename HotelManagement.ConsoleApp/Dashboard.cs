using System;
namespace HotelManagement.ConsoleApp
{
    class Dashboard
    {
        public void ShowDashboard()
        {
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Hotel Management";

            Menu m = new Menu();
            int choice = m.Print(typeof(Options));
            MainScreenFactory factory = new MainScreenFactory();
            MainScreen ms = factory.GetObject(choice);
            if (ms != null)
            {
                ms.Run();
            }
        }
    }
}
