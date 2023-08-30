using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class DatabaseSingleton
    {
        private static KpopZtationDBEntities db = null;

        private DatabaseSingleton()
        {

        }


        public static KpopZtationDBEntities GetInstance()
        {
            if (db == null)
            {
                db = new KpopZtationDBEntities();
            }
            return db;
        }
    }
}