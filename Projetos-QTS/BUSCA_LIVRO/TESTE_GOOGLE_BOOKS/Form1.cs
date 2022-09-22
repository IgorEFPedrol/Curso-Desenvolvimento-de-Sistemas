using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API_LIVRO;

namespace TESTE_GOOGLE_BOOKS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                GoogleAPI pesquisa = new GoogleAPI();
                dynamic query = await pesquisa.GoogleBooks(txtCodigo.Text);
                if (query != null)
                {
                    lbTitulo.Text = query.items[0].volumeInfo.title;
                    lbAutor.Text = query.items[0].volumeInfo.authors[0];
                    lbPublicacao.Text = query.items[0].volumeInfo.publishedDate;
                    lbPaginas.Text = query.items[0].volumeInfo.pageCount;
                    lbEditora.Text = query.items[0].volumeInfo.publisher;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha: " + erro.Message);
            }
        } 
    }
}
