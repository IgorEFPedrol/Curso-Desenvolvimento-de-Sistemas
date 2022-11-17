using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLAPPY_BIRD
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Splash();
            Application.Run(new Form1());
        }

        private static void Registrar()
        {
            try
            {
                string Serial = Registro.Ler("FLAPPY", "serial");
                if (Serial.Equals(""))
                {
                    Application.Run(new FormRegistro());
                }
                else if (!Serial.Equals("YTt2crwtYoo7"))
                {
                    Application.Run(new FormRegistro());
                }
            }
            catch (Exception)
            {
                Application.Run(new FormRegistro());
            }
        }

        private static void Splash()
        {
            ThreadStart start = new ThreadStart(BemVindo);
            Thread t = new Thread(start);
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
        }

        private static void BemVindo()
        {
            Application.Run(new FormSplash());
        }
    }
}
