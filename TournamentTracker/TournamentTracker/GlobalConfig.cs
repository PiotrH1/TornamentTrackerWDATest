using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConection> Connections { get; private set; } = new List<IDataConection>();

        public static void InitializeConnection(bool database, bool textFile)
        {
            
            if (database)
            {
                //TODO- create the SQL connection
                SQLConnection sql = new SQLConnection();
                Connections.Add(sql);
            }
            if (textFile)
            {
                //TODO - text file
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
