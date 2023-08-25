using SIGT___PCM.Cadastros.ClassesCadastros;
using SIGT___PCM.Conexoes;
using SIGT___PCM.Tema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGT___PCM.Cadastros
{
    public partial class CadFuncionario : MetroFramework.Forms.MetroForm
    {
        public CadFuncionario()
        {
            InitializeComponent();
            TemaGeralPrograma.SetPurpleStyle(metroStyleManagerCadastroFuncionario);
        }

        private void CadFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Visible = false;
        }
        bool vinculoFuncionario;
        bool statusFuncionario;
        string categoriaFuncionario;
        string atividadeFuncionario;
        DateTime dateTime = DateTime.Now;
        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (rdVinculoInternoFuncionario.Checked)
                {
                    vinculoFuncionario = true;
                }
                if (rdVincuExternoFuncionario.Checked)
                {
                    vinculoFuncionario = false;
                }
                if (rdCategoriaHoristaFuncionario.Checked)
                {
                    categoriaFuncionario = "Horista";
                }
                if (rdCategoriaMensalistaFuncionario.Checked)
                {
                    categoriaFuncionario = "Mensalidade";
                }
                if (rdAtividadeManutencao.Checked)
                {
                    atividadeFuncionario = "Mantenção";
                }
                if (rdAtividadeProducao.Checked)
                {
                    atividadeFuncionario = "Produção";
                }
                if (rdAtivoFuncionario.Checked)
                {
                    statusFuncionario = true;
                }
                if (rdDesativadoFuncionario.Checked)
                {
                    statusFuncionario = false;
                }
            }
            Funcionario funcionario = new Funcionario();
            funcionario.CadastroFuncionario(txtMatriculaFuncionario.Text, txtNomeCompletoFuncionario.Text, txtCodigoFuncaoFuncionario.Text, txtDescricaoCodigoFuncionario.Text, vinculoFuncionario, categoriaFuncionario, atividadeFuncionario, Convert.ToInt16(txtDisponibilidadeFuncionario.Text.Replace(" %","")), statusFuncionario, ClassDadosGet.IDUsuario, dateTime, this.dtAdminissaoFuncionario.Value, this.dtDemissaoFuncionario.Value);
        }
    }
}
