using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FLAPPY_BIRD
{
    class Cripto
    {
        const string chave = "1593574862";

        public static string Codificar(string texto)
        {
            byte[] Results;
            UTF8Encoding UTF8 = new UTF8Encoding();
            MD5CryptoServiceProvider Provedor = new MD5CryptoServiceProvider();
            byte[] TDESKey = Provedor.ComputeHash(UTF8.GetBytes(chave));
        } 
    }
}
