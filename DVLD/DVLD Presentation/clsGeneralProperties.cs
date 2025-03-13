using DVLDBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD
{
    static internal class clsGeneralProperties
    {
        static public clsUser RegisteredUser { get; set; }

        static public string RegisteredUserFile { get { return @"C:\DVLD\RegisteredUserFile.txt"; } }
    }
}
