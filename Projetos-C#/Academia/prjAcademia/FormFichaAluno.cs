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
    public partial class FormFichaAluno : Form
    {
        internal Aluno Registro { get; set; }

        public FormFichaAluno()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (validacao() == false) return;

            if (Registro == null) novo();
            else editar();
            this.Dispose();
        }

        private bool validacao()
        {
            if (txtNome.Text.Equals(""))
            {
                ep.SetError(txtNome, "Nome Vazio");
                ep.SetIconPadding(txtNome, -30);
                return false;
            }
            else
            {
                ep.SetError(txtNome, "");
            }

            if (Convert.ToInt16(txtIdade.Text) < 15)
            {
                ep.SetError(txtIdade, "Idade Inválida (<15)");
                ep.SetIconPadding(txtIdade, -30);
                return false;
            }
            else
            {
                ep.SetError(txtIdade, "");
            }

            if (Convert.ToInt16(txtPeso.Text) < 50)
            {
                ep.SetError(txtPeso, "Peso Inválido (<50)");
                ep.SetIconPadding(txtPeso, -30);
                return false;
            }
            else
            {
                ep.SetError(txtPeso, "");
            }
            return true;
        }

        private void novo()
        {
            Registro = new Aluno(
                Int32.Parse(txtId.Text),
                txtNome.Text,
                Int16.Parse(txtIdade.Text),
                Double.Parse(txtPeso.Text),
                Double.Parse(txtAltura.Text));
            MessageBox.Show("Matrícula Cadastrada");

        }

        private void editar()
        {
            Registro.Id = Int32.Parse(txtId.Text);
            Registro.Nome = txtNome.Text;
            Registro.Idade = Int16.Parse(txtIdade.Text);
            Registro.Peso = Double.Parse(txtPeso.Text);
            Registro.Altura =  Double.Parse(txtAltura.Text);       
            MessageBox.Show("Matrícula Editada");
        }

        private void FormFichaAluno_Load(object sender, EventArgs e)
        {
            if (Registro != null)
            {
                txtId.Text = Registro.Id.ToString();
                txtNome.Text = Registro.Nome;
                txtIdade.Text = Registro.Idade.ToString();
                txtPeso.Text = Registro.Peso.ToString();
                txtAltura.Text = Registro.Altura.ToString();
                txtId.ReadOnly = true;
            }
            else
            {
                AlunoDB tabela = new AlunoDB();
                txtId.Text = tabela.ProximoCodigo().ToString();
                txtId.ReadOnly = true;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Registro = null;
            this.Dispose();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        { 
            string caminho = Environment.CurrentDirectory + "\\" +
                txtId.Text + ".png";
            saveFoto.ShowDialog();
            if (File.Exists(saveFoto.FileName))
            {
                pbFoto.Image = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(caminho);
                File.Copy(saveFoto.FileName, caminho);
                pbFoto.Image = Image.FromFile(caminho);
                MessageBox.Show("Foto Salva com Sucesso!");
            }
        }
    }


}
