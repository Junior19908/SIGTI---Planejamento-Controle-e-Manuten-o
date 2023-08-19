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
using SIGT___PCM.Conexoes;
using SIGT___PCM.Relatorio;
using SIGT___PCM.Tema;

namespace SIGT___PCM
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            TemaGeralPrograma.SetPurpleStyle(metroStyleManagerMenu, ClassDadosGet.TemaUser);
            temaAtivo.Text = ClassDadosGet.Tema;
            userAtivo.Text = ClassDadosGet.Usuario;
            if(temaAtivo.Text == "Vermelho")
            {
                temaAtivo.BackColor = Color.Red;
                temaAtivo.ForeColor = Color.White;
            }
        }

        private void btnOS_Click(object sender, EventArgs e)
        {
            frmOS frmOS = new frmOS();
            frmOS.Show();
            this.Visible = false;
            //relatorioOS relatorio = new relatorioOS();
            //relatorio.GerarRelatorioPDF();
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

        private void btnCadastroEquipamento_Click(object sender, EventArgs e)
        {
            Cadastros.CadEquipamento cadEquipamento = new Cadastros.CadEquipamento();
            cadEquipamento.Show();
            this.Visible = false;
        }
    }
}
