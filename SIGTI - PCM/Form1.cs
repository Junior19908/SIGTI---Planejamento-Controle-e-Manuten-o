using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using SIGT___PCM.Relatorio;

namespace SIGT___PCM
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
        }

        private void btnOS_Click(object sender, EventArgs e)
        {
            /*frmOS frmOS = new frmOS();
            frmOS.Show();
            this.Visible = false;*/
            relatorioOS relatorio = new relatorioOS();
            relatorio.GerarRelatorioPDF();
        }

        private void btnOS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void novoFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.CadFuncionario funcionario = new Cadastros.CadFuncionario();
            funcionario.Show();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
