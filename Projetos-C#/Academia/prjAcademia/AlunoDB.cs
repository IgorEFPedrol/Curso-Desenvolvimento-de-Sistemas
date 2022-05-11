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
                string sql = string.Format("INSERT INTO ALUNO(ID, NOME, ALTURA)" +
                    "VALUES ({0}, {1}, {2}, {3}, {4})",
                    reg.ID, reg.Nome, reg.Idade, reg.Peso,
                    reg.Altura.ToString().Replace(',', '.') + ")");
                banco.CommandText = sql;
                banco.ExecuteNonQuery();
            }
        }
        public void Editar (Aluno reg)
        {
             ServidorSQL academia = new ServidorSQL();

             using (var banco = new SQLiteCommand(academia.Open()))
             {
                 string sql = String.Format("UPDATE ALUNO SET NOME = '{0}'" +
                     ", IDADE = {1}, PESO = {2}, ALTURA = {3}) " +
                     "WHERE ID = {4}", reg.Nome, reg.Idade, reg.Peso,
                     reg.Altura.ToString().Replace(',', '.'), reg.ID);
                 banco.CommandText = sql;
                 banco.ExecuteNonQuery();
             }
        }
            
    }
}
