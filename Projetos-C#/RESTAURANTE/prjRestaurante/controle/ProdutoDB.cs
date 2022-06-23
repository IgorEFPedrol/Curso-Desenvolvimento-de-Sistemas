using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRestaurante.controle
{
    class ProdutoDB
    {
        string con = Conexao.Open("localhost",
            "restaurantedb", "root", "minas");
        public void Listar(BindingSource bs)
        {
            using (var banco = new modelo.restaurantedbEntidades())
            {
                banco.Database.Connection.ConnectionString = con;
                var query = from linhas in banco.produto.Include("tipo")
                            orderby linhas.idproduto
                            select linhas;
                bs.DataSource = query.ToList();
            }
        }
    }
}
