using System;
using DbConnection;

namespace crudMySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get all users from db test
            var allUsers = DbConnector.Query("SELECT * FROM users");
        }
    }
}
