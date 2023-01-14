using SOLID_DependencyInversionPrinciple.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DependencyInversionPrinciple.Factory
{
    class DbProductFactory
    {
        public static DbProduct Create()
        {
            if (ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SQLServerProduct();
            }
            else
            {
                return new MongoDBProduct();
            }
        }

        public DbProduct teste()
        {
            return null;
        }
    }
}
