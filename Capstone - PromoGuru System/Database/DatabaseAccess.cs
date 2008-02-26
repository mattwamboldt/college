using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class DatabaseAccess
    {
        private static MSAccessDatabase myDatabase;
        private DatabaseAccess()
        {
        }

        public static void createInstance(string databasePath, params string[] tablenames)
        {
            myDatabase = new MSAccessDatabase(databasePath);
            myDatabase.LoadTableData(tablenames);
        }

        public static MSAccessDatabase getInstance()
        {
            return myDatabase;
        }
    }
}
