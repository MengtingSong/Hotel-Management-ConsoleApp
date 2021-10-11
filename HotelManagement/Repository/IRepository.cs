using System;
using System.Collections.Generic;

namespace HotelManagement.Repository
{
    public interface IRepository<T>
    {
        int Insert(T item);
        int Update(T item);
        int Delete(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
