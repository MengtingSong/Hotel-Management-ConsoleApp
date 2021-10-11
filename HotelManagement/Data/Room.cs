using System;
namespace HotelManagement.Data
{
    public class Room
    {
        public int Id { get; set; }
        public int RtCode { get; set; }
        public bool Status { get; set; }

        public RoomType RoomType { get; set; }
    }
}
