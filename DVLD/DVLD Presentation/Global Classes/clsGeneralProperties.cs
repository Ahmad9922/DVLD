using DVLDBusiness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLD
{
    static internal class clsGeneralProperties
    {
        static public clsUser RegisteredUser { get; set; }

        static public string DVLDRegistryKey
        {
            get 
            {
                return @"SOFTWARE\DVLD";
            } 
        }
    }
}
