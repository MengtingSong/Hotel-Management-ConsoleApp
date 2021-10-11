using System;
using HotelManagement.ConsoleApp.UI;

namespace HotelManagement.ConsoleApp
{
    class MainScreenFactory
    {
        public MainScreen GetObject(int choice)
        {
            switch (choice)
            {
                case (int)Options.Room:
                    return new ManageRoom();
                case (int)Options.RoomType:
                    return new ManageRoomType();
                case (int)Options.Customer:
                    return new ManageCustomer();
                case (int)Options.Service:
                    return new ManageService();
                case (int)Options.Exit:
                    Console.WriteLine("Thanks for visit!!!");
                    break;
                default:
                    Console.WriteLine("Some error has occurred...");
                    break;
            }
            return null;
        }
    }
}
