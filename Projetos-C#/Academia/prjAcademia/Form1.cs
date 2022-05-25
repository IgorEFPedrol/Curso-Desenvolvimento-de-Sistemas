using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAcademia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        Academia BoaForma;

        private void Form1_Load(object sender, EventArgs e)
        {
            ServidorSQL Servidor = new ServidorSQL();
            if (Servidor.CriarBanco() == true)
            {
                MessageBox.Show("Banco de dados gerado com sucesso!");
            }
            BoaForma = new Academia(new BindingList<Aluno>());
            BoaForma.Preencher();
            bs.DataSource = BoaForma.Alunos;
            dgvAlunos.DataSource = bs;
            dgvAlunos.AutoResizeColumns();

        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            FormFichaAluno ficha = new FormFichaAluno();
            ficha.Registro = null;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                BoaForma.Matricular(ficha.Registro);
                bs.ResetBindings(false);
                bs.MoveLast();
                dgvAlunos.AutoResizeColumns();
                bs_PositionChanged(sender, e);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormFichaAluno ficha = new FormFichaAluno();
            ficha.Registro = (Aluno)bs.Current;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                BoaForma.Editar(ficha.Registro);
                bs.ResetBindings(false);
                dgvAlunos.AutoResizeColumns();
                bs_PositionChanged(sender, e);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (bs.Count == 0) return;

            Aluno atual = (Aluno)bs.Current;
            DialogResult op;
            op = MessageBox.Show("Deseja Excluir: " + atual.Nome, "ALERTA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (op == DialogResult.Yes)
            {
                BoaForma.Excluir(atual);
                bs.ResetBindings(false);
                dgvAlunos.AutoResizeColumns();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisar pesquisa = new FormPesquisar();
            pesquisa.ShowDialog();
            if (pesquisa.Registro != null)
            {
                var obj = bs.List.OfType<Aluno>().ToList().
                    Find(f => f.Id == pesquisa.Registro.Id);
                bs.Position = bs.IndexOf(obj);
                btnEditar_Click(sender, e);
            }
        }

        private void bs_PositionChanged(object sender, EventArgs e)
        {
            if (bs.Count != 0)
            {
                Aluno atual = (Aluno)bs.Current;
                string caminho = Environment.CurrentDirectory + "\\" +
                    atual.Id + ".png";
                if (File.Exists(caminho))
                {
                    pbFoto.Image = Image.FromFile(caminho);
                }
                else
                {
                    pbFoto.Image = null;
                }
            }
        }

    }
}
