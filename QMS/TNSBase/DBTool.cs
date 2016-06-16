using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;

namespace TNSBase
{
    public static class DBTool
    {
        /// <summary>
        /// DB連線
        /// </summary>
        /// <param name="dbConnType"></param>
        /// <returns></returns>
        public static string getDBConnectionString(DBConnType dbConnType)
        {
            return getDBConnectionString(dbConnType.ToString());
        }

        /// <summary>
        /// DB連線
        /// </summary>
        /// <param name="strDBConn"></param>
        /// <returns></returns>
        public static string getDBConnectionString(string strDBConn)
        {
            string ConnectionString = string.Empty;
            ConnectionStringSettings Setting = ConfigurationManager.ConnectionStrings[strDBConn];
            if (Setting != null)
                ConnectionString = Setting.ConnectionString;

            return ConnectionString;
        }
    }
}
