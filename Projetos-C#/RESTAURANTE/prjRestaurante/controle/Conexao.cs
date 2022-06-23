using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prjRestaurante.controle
{
    class Conexao
    {
        public static string Open(
            string servidor, string database, string
           usuario, string senha)
        {
            string strcon = "server=" + servidor + ";"
             + "user id=" + usuario + ";"
             + "database=" + database + ";" +
             "password=" + senha + ";" +
             "persist security info=True";
            return strcon;
        }
    }
}