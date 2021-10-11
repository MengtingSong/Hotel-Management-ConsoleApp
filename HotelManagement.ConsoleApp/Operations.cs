using System;

namespace HotelManagement.ConsoleApp
{
    enum Operations
    {
        Add = 1,
        Update,
        Delete,
        PrintAll,
        PrintById,
        Exit
    }

    enum Options
    {
        Room = 1,
        RoomType,
        Service,
        Customer,
        Exit
    }
}
