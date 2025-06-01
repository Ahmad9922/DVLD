using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccess
{
    static public class clsDataAccessSettings
    {
        static internal string ConnectionString 
        { 
            get
            {
                return ConfigurationManager.AppSettings["ConnectionString"];
            }
        }

        static internal string NewGuidPath 
        { 
            get
            {
                return @"C:\DVLD\Persons Images\" + Guid.NewGuid().ToString() + ".png";
            }
        }

        static internal long EncryptionKey = 782931043201;
    }
}
