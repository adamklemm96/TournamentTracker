using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.DataAccess;

namespace Tracker
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }



        public static void InitializeConnections(DatabaseType db)
        {
            if(db == DatabaseType.Sql)
            {
                // TODO - Set up the SQL connector properly 
                SqlConnector sql = new SqlConnector();
                Connection=sql;
            }
            else if(db == DatabaseType.TextFile)
            {
                // TODO - Create the text connection 
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
