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
            TripleDESCryptoServiceProvider TDESAlgoritmo = new TripleDESCryptoServiceProvider();
            TDESAlgoritmo.Mode = CipherMode.ECB;
            TDESAlgoritmo.Key = TDESKey;
            TDESAlgoritmo.Padding = PaddingMode.PKCS7;
            if (texto.Equals("")) return "";
            byte[] dados = UTF8.GetBytes(texto);
            try
            {
                ICryptoTransform Enc = TDESAlgoritmo.CreateEncryptor();
                Results = Enc.TransformFinalBlock(dados, 0, dados.Length);
            }
            finally
            {
                TDESAlgoritmo.Clear();
                Provedor.Clear();
            }
            return Convert.ToBase64String(Results);
        } 
    }
}
