using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double peso=Convert.ToDouble(txtPeso.Text);
                lista.Items.Add(peso); 
                txtPeso.Focus(); 
                txtPeso.Text="";
            }
            catch (Exception)
            {
            MessageBox.Show("Erro ao inserir o peso na lista");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
       

    }
}
