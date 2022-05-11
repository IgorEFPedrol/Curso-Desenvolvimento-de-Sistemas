using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace prjAcademia
{
    class AlunoDB
    {
        public void Inserir(Aluno reg)
        {
            ServidorSQL academia = new ServidorSQL();
            using (var banco = new SQLiteCommand(academia.Open()))
            {

            }
        }

    }
}
