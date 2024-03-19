using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisVendas.Controller;
using SisVendas1;


namespace SisVendas
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Connection conexao = new Connection();
            if (conexao.conectaPG() != null)
            {
                Application.Run(new Form1());
            }

        }
    }
}
