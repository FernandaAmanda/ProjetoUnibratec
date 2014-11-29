using System;
using System.Data.Entity;

namespace DatabasePocketQueue.DAO.Database.Factory
{
    static class Database
    {

        private static string ConnectionString = "Server=localhost;Database=PocketQueue;User Id=sa;Password=sa;";
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
