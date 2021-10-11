using System;
using System.Collections.Generic;
using HotelManagement.Data;

namespace HotelManagement.Repository
{
    public class ServiceRepository : IRepository<Service>
    {
        DbContext db = new DbContext();

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Service> GetAll()
        {
            throw new NotImplementedException();
        }

        public Service GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Service item)
        {
            throw new NotImplementedException();
        }

        public int Update(Service item)
        {
            throw new NotImplementedException();
        }
    }
}
