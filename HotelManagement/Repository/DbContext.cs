using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace HotelManagement.Repository
{
    class DbContext
    {
        public IDbConnection GetConnection()
        {
            string connection = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("HotelManagement");
            return new SqlConnection(connection);
        }
    }
}
