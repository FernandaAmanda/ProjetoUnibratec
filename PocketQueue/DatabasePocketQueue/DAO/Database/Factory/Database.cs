using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue.DAO.Database.Factory
{
    static class Database
    {

        private static string ConnectionString = "Server=192.168.25.50;Database=PocketQueue;User Id=SQLAdmin;Password=123456;";
        private static DbContext DatabaseContext = new DbContext(ConnectionString);

        public static bool OverrideExistingDatabase()
        {
            try
            {
                DatabaseContext.Database.Delete();
                DatabaseContext.Database.Create();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static bool CreateNewDatabase()
        {
            try
            {
                return DatabaseContext.Database.CreateIfNotExists();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
