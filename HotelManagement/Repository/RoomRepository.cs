using System;
using System.Data;
using HotelManagement.Data;
using Dapper;

namespace HotelManagement.Repository
{
    public class RoomRepository : IRepository<Room>
    {
        DbContext db = new DbContext();
        public int Delete(int id)
        {
            IDbConnection connection = db.GetConnection();
            return connection.Execute("DELETE FROM Rooms WHERE Id = @roomid", new { roomid = id });
        }

        public System.Collections.Generic.IEnumerable<Room> GetAll()
        {
            IDbConnection connection = db.GetConnection();
            return connection.Query<Room>("SELECT * FROM Rooms");
        }

        public Room GetById(int id)
        {
            IDbConnection connection = db.GetConnection();
            return connection.QueryFirstOrDefault<Room>("SELECT * FROM Rooms WHERE Id = @roomid", new { roomid = id });
        }

        public int Insert(Room item)
        {
            IDbConnection connection = db.GetConnection();
            return connection.Execute("INSERT INTO Rooms (@int RtCode, @bool Status)", item);
        }

        public int Update(Room item)
        {
            IDbConnection connection = db.GetConnection();
            return connection.Execute("UPDATE Rooms SET RtCode = @RtCode, Status = @Status", item);
        }
    }
}
