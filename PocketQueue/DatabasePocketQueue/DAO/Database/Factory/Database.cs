﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.Data.SqlClient;

namespace DatabasePocketQueue.DAO.Database.Factory
{
   public  static class Database
    {

       private static string ConnectionString = @"Server=.\SQLEXPRESS;Database=PocketQueue;Trusted_Connection=yes;";
       private static DbContext DatabaseContext = new DbContext(ConnectionString);
=======

namespace DatabasePocketQueue.DAO.Database.Factory
{
    static class Database
    {

        private static string ConnectionString = "Server=J-PC;Database=PocketQueue;User Id=sa;Password=sa;";
        private static DbContext DatabaseContext = new DbContext(ConnectionString);
>>>>>>> 5f0932a4f32660179c6da99316c64471225192d7

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
