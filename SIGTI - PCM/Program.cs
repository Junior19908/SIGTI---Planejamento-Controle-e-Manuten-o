using MetroFramework.Components;
using SIGT___PCM.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGT___PCM
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


            Relatorio.OS oS = new Relatorio.OS();
            oS.ShowDialog();

            //frmLogin frmLogin = new frmLogin();
            //frmLogin.ShowDialog();
            //
            //if (frmLogin.FMP == true)
            //{
            //    Application.Run(new Form1());
            //}
        }
    }
}
