using DatabasePocketQueue.DAO.Database.Context;
using DatabasePocketQueue.DAO.Database.Factory;
using DatabasePocketQueue.DAO.Database.Repositorio;
using DatabasePocketQueue.DAO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasePocketQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Overriding Existing Database...");
            Console.WriteLine((Database.OverrideExistingDatabase() ? "Success!" : "Failure..."));


        }
    }
}
