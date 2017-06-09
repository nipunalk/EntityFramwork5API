using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork5API
{
    [Serializable(), ClassInterface(ClassInterfaceType.AutoDual), ComVisible(true)]
    public class ConnectionFactory
    {
        private static string connectionString="";
        public ConnectionFactory() { 
        }
        private ConnectionFactory(string provider, string server, string db, string userId, string password) {
            connectionString = provider;
            connectionString="metadata=res://*/EPSEntity.csdl|res://*/EPSEntity.ssdl|res://*/EPSEntity.msl;" +
                             "provider=MySql.Data.MySqlClient;provider connection string=';server="+
                             server+";user id="+userId+";password="+password+";persistsecurityinfo=True;database="+db+"';";
        }
        
        public  void setConnection(string provider, string server, string db, string user, string password)
        {
            if (connectionString == "")
            {
                new ConnectionFactory(provider, server, db, user, password);
            }
        }
        [ComVisible(false)]
        public static string getConnection(String provider){
            return connectionString;
        }
    }
}
