using System;
namespace HotelManagement.Data
{
    public class Service
    {
        public int Id { get; set; }
        public int RoomNO { get; set; }
        public string SDesc { get; set; }
        public decimal Amount { get; set; }
        public DateTime ServiceDate { get; set; }

        public Room Room { get; set; }
    }
}
