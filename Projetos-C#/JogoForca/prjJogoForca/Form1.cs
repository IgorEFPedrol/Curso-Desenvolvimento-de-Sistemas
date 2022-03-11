using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjJogoForca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> lista = new List<string>()
        {
            "JARARACA", "ROMA", "ESPELHO", "RONDONIA", "JABUTI", "DINAMARCA", "ITALIA", "ENDOSCOPIA", "GOIANIA", "JIBOIA", "GASTRITE", "VARIOLA", "FLUMINENSE",
            "GREMIO", "PALMEIRAS", "DIASPORA", "FILOSOFIA", "GUARATINGUETA", "FILANTROPIA", "HERCULES", "JUPITER", "VASCO", "ANHANGUERA", "MARTE", "INGLATERRA",
            "LEAO", "ANACONDA", "VENUS", "ESCORBUTO", "ANEMIA", "SATURNO", "RUSSIA", "BELGICA"
        };
        Forca jogo;

        private void Form1_Load(object sender, EventArgs e)
        {
            jogo = new Forca(lista);
            jogo.Sortear();
            MessageBox.Show(jogo.DevolvePalavra());
        }
    }
}
