using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabasePocketQueue.DAO.Database.Factory
{
   public  static class Database
    {

       private static string ConnectionString = @"Server=.\SQLEXPRESS;Database=PocketQueue;Trusted_Connection=yes;";
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
