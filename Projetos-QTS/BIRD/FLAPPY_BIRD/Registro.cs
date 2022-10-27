using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace FLAPPY_BIRD
{
    class Registro
    {
        public static void Gravar(string caminho, string parametro, string valor)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(caminho);
            key.SetValue(parametro, valor);
        }
        public static string Ler(string caminho, string parametro)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(caminho);
            if (key != null)
                return key.GetValue(parametro).ToString();
            else return "0";
        }
    }
}
