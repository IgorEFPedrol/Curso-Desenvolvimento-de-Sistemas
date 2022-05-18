﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAcademia
{
    class Academia
    {
        public BindingList<Aluno> Alunos;
        public Academia(BindingList<Aluno> Alunos)
        {
            this.Alunos = Alunos;
        }

        public void Preencher()
        {
            try
            {
                AlunoDB tabela = new AlunoDB();
                tabela.Select(Alunos);
            }
            catch (Exception Erro)
            {
                System.Windows.Forms.MessageBox.Show(
                    "ERRO: " + Erro.Message);
            }
        }

        public void Matricular(Aluno novo)
        {
            try
            {
                if (novo != null)
                {
                    AlunoDB tabela = new AlunoDB();
                    tabela.Inserir(novo);
                    Alunos.Add(novo);
                }
            }
            catch (Exception Erro)
            {
                System.Windows.Forms.MessageBox.Show(
                    "ERRO: " + Erro.Message);
            }

        }

        public void Editar(Aluno aluno)
        {
            Aluno p = Alunos.FirstOrDefault(i => i.Id == aluno.Id);
            if (p != null)
            {
                p.Nome = aluno.Nome;
                p.Idade = aluno.Idade;
                p.Peso = aluno.Peso ;
                p.Altura= aluno.Altura;
                try
                {
                    AlunoDB tabela = new AlunoDB();
                    tabela.Editar(p);
                }
                catch (Exception Erro)
                {
                    System.Windows.Forms.MessageBox.Show(
                        "ERRO: " + Erro.Message);
                }
            }    
        }

        public void Excluir(Aluno atual)
        {
            Aluno p = Alunos.FirstOrDefault(i => i.Id == atual.Id);
            try
            {
                AlunoDB tabela = new AlunoDB();
                tabela.Excluir(p);
                Alunos.Remove(p);
            }
            catch (Exception Erro)
            {
                System.Windows.Forms.MessageBox.Show(
                    "ERRO: " + Erro.Message);
            }
        }
    }
}
