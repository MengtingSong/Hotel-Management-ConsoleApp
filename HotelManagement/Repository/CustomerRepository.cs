using System;
using System.Collections.Generic;
using System.Data;
using HotelManagement.Data;
using Dapper;

namespace HotelManagement.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        DbContext db = new DbContext();

        public int Delete(int id)
        {
            IDbConnection connection = db.GetConnection();
            return connection.Execute("DELETE FROM Rooms WHERE Id = @customer", new { customer = id });
        }

        public IEnumerable<Customer> GetAll()
        {
            IDbConnection connection = db.GetConnection();
            return connection.Query<Customer>("SELECT * FROM Customers");
        }

        public Customer GetById(int id)
        {
            IDbConnection connection = db.GetConnection();
            return connection.QueryFirstOrDefault<Customer>("SELECT * FROM Rooms WHERE Id = @customerid", new { customerid = id });
        }

        public int Insert(Customer item)
        {
            IDbConnection connection = db.GetConnection();
            return connection.Execute("INSERT INTO Customers (@RoomNO, @CName, @Address, @Phone, @Email, @Checkin, @TotalPersons, @BookingDays, @Advance)", item);
        }

        public int Update(Customer item)
        {
            IDbConnection connection = db.GetConnection();
            return connection.Execute("UPDATE Customers SET RoomNO = @RoomNO, CName = @CName, Address = @Address, Phone = @Phone, Email = @Email, Checkin = @Checkin, TotalPersons = @TotalPersons, BookingDays = @BookingDays, Advance = @Advance", item);
        }
    }
}
