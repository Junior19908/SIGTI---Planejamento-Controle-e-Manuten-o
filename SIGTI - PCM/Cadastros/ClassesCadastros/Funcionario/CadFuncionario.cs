using SIGT___PCM.Cadastros.ClassesCadastros;
using SIGT___PCM.Conexoes;
using SIGT___PCM.Mensagem;
using SIGT___PCM.Tema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        int cmbDescTipo;
        DateTime dateTime = DateTime.Now;
        bool[] diasDaSemana = new bool[7]; // Um array para armazenar os valores dos dias da semana
        private void button1_Click(object sender, EventArgs e)
        {
            if (!chDomingo.Checked && !chSegunda.Checked && !chTerca.Checked && !chQuarta.Checked && !chQuinta.Checked && !chSexta.Checked && !chSabado.Checked)
            {
                MensagemClasseDiag mensagemClasseDiag = new MensagemClasseDiag();
                mensagemClasseDiag.MostrarMensagemPersonalizadaSelecaoDias();
            }
            else
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
                        categoriaFuncionario = "Mensalista";
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
                switch (cmbFuncao.Text)
                {
                    case "AJ SERRALHEIRO":
                        cmbDescTipo = 1;
                        break;
                    case "AJ SOLDADOR":
                        cmbDescTipo = 2;
                        break;
                    case "AJ CALDEIREIRO":
                        cmbDescTipo = 3;
                        break;
                    case "AJ ELETRICISTA":
                        cmbDescTipo = 4;
                        break;
                    case "CALDEIREIRO":
                        cmbDescTipo = 5;
                        break;
                    case "CASA DE FORÇA":
                        cmbDescTipo = 6;
                        break;
                    case "ELETRICISTA":
                        cmbDescTipo = 7;
                        break;
                    case "ENC TURBINA AÇÚCAR":
                        cmbDescTipo = 8;
                        break;
                    case "ENC MOENDA":
                        cmbDescTipo = 9;
                        break;
                    case "ENC TURBINA VAPOR":
                        cmbDescTipo = 10;
                        break;
                    case "ENC CALDEIRARIA":
                        cmbDescTipo = 11;
                        break;
                    case "ENC INSTRUMENTAÇÃO":
                        cmbDescTipo = 12;
                        break;
                    case "ENC LUBRIFICAÇÃO":
                        cmbDescTipo = 13;
                        break;
                    case "ENC OFICINA":
                        cmbDescTipo = 14;
                        break;
                    case "INSTRUMENTISTA":
                        cmbDescTipo = 15;
                        break;
                    case "OP PONTE ROLANTE":
                        cmbDescTipo = 16;
                        break;
                    case "OP QUADRO":
                        cmbDescTipo = 17;
                        break;
                    case "OP QUADRO (CASA FORÇA1)":
                        cmbDescTipo = 18;
                        break;
                    case "OP TURBO GERADOR":
                        cmbDescTipo = 19;
                        break;
                    case "SERRALHEIRO":
                        cmbDescTipo = 20;
                        break;
                    case "SERRALHEIRO (MOTOR)":
                        cmbDescTipo = 21;
                        break;
                    case "SERVENTE":
                        cmbDescTipo = 22;
                        break;
                    case "SOLDADOR":
                        cmbDescTipo = 23;
                        break;
                    case "TORNEIRO":
                        cmbDescTipo = 24;
                        break;
                    default:
                        cmbDescTipo = 0; // Valor padrão caso o tipo não seja reconhecido
                        break;
                }
                Funcionario funcionario = new Funcionario();
                funcionario.CadastroFuncionario(txtMatriculaFuncionario.Text, txtNomeCompletoFuncionario.Text, txtCodigoFuncaoFuncionario.Text, txtDescricaoCodigoFuncionario.Text, vinculoFuncionario, categoriaFuncionario, atividadeFuncionario, Convert.ToInt16(txtDisponibilidadeFuncionario.Text.Replace(" %", "")), statusFuncionario, ClassDadosGet.IDUsuario, dateTime, this.dtAdminissaoFuncionario.Value, this.dtDemissaoFuncionario.Value);
                funcionario.CadastroSemanaFuncionario(chDomingo.Checked, chSegunda.Checked, chTerca.Checked, chQuarta.Checked, chQuinta.Checked, chSexta.Checked, chSabado.Checked, txtMatriculaFuncionario.Text);
                LimparBox();
            }
        }
        string novoCodigo;
        private void cmbFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFuncao.SelectedIndex == 0)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("AJSE - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("AJSE - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "AJUDANTE DE SERRALHEIRO";
            }else if (cmbFuncao.SelectedIndex == 1)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("AJSO - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("AJSO - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "AJUDANTE DE SOLDADOR";
            }else if(cmbFuncao.SelectedIndex == 2)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("AJCA - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("AJCA - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "AJUDANTE DE CALDEIREIRO";
            }
            else if (cmbFuncao.SelectedIndex == 3)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("AJEL - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("AJEL - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "AJUDANTE DE ELETRICISTA";
            }
            else if (cmbFuncao.SelectedIndex == 4)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("CAL - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("CAL - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "CALDEIREIRO";
            }
            else if (cmbFuncao.SelectedIndex == 5)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("CF - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("CF - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "CASA DE FORÇA";
            }
            else if (cmbFuncao.SelectedIndex == 6)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("CF - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("CF - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "ELETRICISTA";
            }
            else if (cmbFuncao.SelectedIndex == 7)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("ETA - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("ETA - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "ENCARREGADO DA TURBINA DE AÇÚCAR";
            }
            else if (cmbFuncao.SelectedIndex == 8)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("EMO - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("EMO - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "ENCARREGADO DE MOENDA";
            }
            else if (cmbFuncao.SelectedIndex == 9)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("ETV - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("ETV - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "ENCARREGADO DA TURBINA A VAPOR";
            }
            else if (cmbFuncao.SelectedIndex == 10)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("ECAL - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("ECAL - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "ENCARREGADO DE CALDEIRARIA";
            }
            else if (cmbFuncao.SelectedIndex == 11)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("EINI - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("EINI - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "ENCARREGADO DA INSTRUMENTAÇÃO";
            }
            else if (cmbFuncao.SelectedIndex == 12)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("ELUB - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("ELUB - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "ENCARREGADO DE LUBRIFICAÇÃO";
            }
            else if (cmbFuncao.SelectedIndex == 13)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("EOF - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("EOF - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "ENCARREGADO DE OFICINA";
            }
            else if (cmbFuncao.SelectedIndex == 14)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("INS - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("INS - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "INSTRUMENTISTA ";
            }
            else if (cmbFuncao.SelectedIndex == 15)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("OPR - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("OPR - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "OPERADOR DE PONTE ROLANTE";
            }
            else if (cmbFuncao.SelectedIndex == 16)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("OQ - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("OQ - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "OPERADOR DE QUADRO";
            }
            else if (cmbFuncao.SelectedIndex == 17)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("OQCF1 - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("OQCF1 - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "OPERADOR DE QUADRO (CASA FORÇA1)";
            }
            else if (cmbFuncao.SelectedIndex == 18)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("OTG - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("OTG - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "OPERADOR TURBO GERADOR";
            }
            else if (cmbFuncao.SelectedIndex == 19)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("SE - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("SE - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "SERRALHEIRO";
            }
            else if (cmbFuncao.SelectedIndex == 20)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("SEM - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("SEM - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "SERRALHEIRO (MOTOR)";
            }
            else if (cmbFuncao.SelectedIndex == 21)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("SER - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("SER - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "SERVENTE";
            }
            else if (cmbFuncao.SelectedIndex == 22)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("SOL - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("SOL - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "SOLDADOR";
            }
            else if (cmbFuncao.SelectedIndex == 23)
            {
                CodigoFuncionario codFamiliaEquipamentoManager = new CodigoFuncionario("TOR - ");
                novoCodigo = codFamiliaEquipamentoManager.GerarNovo("TOR - ");
                txtCodigoFuncaoFuncionario.Text = novoCodigo;
                txtDescricaoCodigoFuncionario.Text = "TORNEIRO";
            }
        }
        private void LimparBox()
        {
            txtMatriculaFuncionario.Text = "";
            cmbFuncao.SelectedIndex = -1;
            txtNomeCompletoFuncionario.Text = "";
            txtCodigoFuncaoFuncionario.Text = "";
            txtDescricaoCodigoFuncionario.Text = "";
            txtQuantidadeFuncionario.Text = "";
            txtCaminhoArquivoFuncionario.Text = "";
            dtAdminissaoFuncionario.Value = DateTime.Now;
            dtDemissaoFuncionario.Value = DateTime.Now;
            rdAtivoFuncionario.Checked = false;
            rdDesativadoFuncionario.Checked = false;
            rdCategoriaMensalistaFuncionario.Checked = false;
            rdCategoriaHoristaFuncionario.Checked = false;
            rdAtividadeManutencao.Checked = false;
            rdVinculoInternoFuncionario.Checked = false;
            rdVincuExternoFuncionario.Checked = false;
            rdAtividadeProducao.Checked = false;
            txtDisponibilidadeFuncionario.Text = "100 %";
            chDomingo.Checked = false;
            chSegunda.Checked = false;
            chTerca.Checked = false;
            chQuarta.Checked = false;
            chQuinta.Checked = false;
            chSexta.Checked = false;
            chSabado.Checked = false;
        }
        private void Funcionário_Click(object sender, EventArgs e)
        {

        }
    }
}