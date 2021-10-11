using System;
using System.Collections.Generic;
using HotelManagement.Data;

namespace HotelManagement.Repository
{
    public class RoomTypeRepository : IRepository<RoomType>
    {
        DbContext db = new DbContext();

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoomType> GetAll()
        {
            throw new NotImplementedException();
        }

        public RoomType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(RoomType item)
        {
            throw new NotImplementedException();
        }

        public int Update(RoomType item)
        {
            throw new NotImplementedException();
        }
    }
}
