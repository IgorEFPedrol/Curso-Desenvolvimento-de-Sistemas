using API_CEP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTE_CEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            WebCEP consulta = new WebCEP();
            try
            {
                dynamic resultado = await consulta.Consultar(txtCep.Text);
                if (resultado != null)
                {
                    lbLog.Text = resultado.logradouro;
                    lbBairro.Text = resultado.bairro;
                    lbCidade.Text = resultado.localidade + "       DDD: " +
                        resultado.ddd;
                    lbEstado.Text = resultado.uf;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }
    }
}
