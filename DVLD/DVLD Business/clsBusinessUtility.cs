using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusiness
{
    public class clsBusinessUtility
    {
        static public string ComputeHash(string Input)
        {
            using (SHA256 SHA = SHA256.Create())
            {
                byte[] HashByte = SHA.ComputeHash(Encoding.UTF8.GetBytes(Input));

                return BitConverter.ToString(HashByte).Replace("-", "");
            }

        }
    }
}
