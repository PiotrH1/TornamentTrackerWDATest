﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConection Connection { get; private set; }

        public static void InitializeConnection(DatabaseType db)
        {

            if (db == DatabaseType.Sql)
            {
                //TODO- create the SQL connection
                SQLConnection sql = new SQLConnection();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                //TODO - text file
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
