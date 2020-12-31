using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horizon.AppHelper
{
    public static class Connection
    {
        private static string _connectionString= null;
        public static string ConnectionString
        {
            get
            {
                return _connectionString ?? EncryptDecrypt.Decrypt( ConfigurationManager.ConnectionStrings["ApplicationConnectionString"].ConnectionString,"HO20");
            }

        }
    }
}
