using SIGT___PCM.Cadastros.ClassesCadastros;
using SIGT___PCM.Conexoes;
using SIGT___PCM.Tema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGT___PCM.Cadastros
{
    public partial class CadEquipamento : MetroFramework.Forms.MetroForm
    {
        public CadEquipamento()
        {
            InitializeComponent();
            TemaGeralPrograma.SetPurpleStyle(metroStyleManagerCadastroEquipamentos);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        bool statusOperacao;
        int cmbDescTipo;
        private void btnGravarEquipamento_Click(object sender, EventArgs e)
        {
            if(txtFichaEquipamento.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios antes de prosseguir.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rdStatusAtivoEquipamento.Checked)
                {
                    statusOperacao = true;
                }
                else
                {
                    statusOperacao = false;
                }
                switch (cmbTipoEquipamento.Text)
                {
                    case "BOMBA CENTRIFUGA":
                        cmbDescTipo = 0;
                        break;
                    case "TURBINAS":
                        cmbDescTipo = 1;
                        break;
                    case "BOMBAS":
                        cmbDescTipo = 2;
                        break;
                    case "BOMBAS DE VÁCUO":
                        cmbDescTipo = 3;
                        break;
                    case "CENTRIFUGA DE AÇÚCAR":
                        cmbDescTipo = 4;
                        break;
                    case "ELEVADOR DE CANECAS":
                        cmbDescTipo = 5;
                        break;
                    case "EXAUSTOR":
                        cmbDescTipo = 6;
                        break;
                    case "ESTEIRAS":
                        cmbDescTipo = 7;
                        break;
                    case "PENEIRA VIBRATORIA":
                        cmbDescTipo = 8;
                        break;
                    case "TRANSPORTADOR HELICOIDAL":
                        cmbDescTipo = 9;
                        break;
                    case "MOTOR ELETRICO":
                        cmbDescTipo = 10;
                        break;
                    case "BOMBA HELICOIDAL":
                        cmbDescTipo = 11;
                        break;
                    case "COMPRESSOR":
                        cmbDescTipo = 12;
                        break;
                    case "PLAINA LIMADORA":
                        cmbDescTipo = 13;
                        break;
                    default:
                        cmbDescTipo = 0; // Valor padrão caso o tipo não seja reconhecido
                        break;
                }

                Equipamento equipamento = new Equipamento();
                equipamento.CadastroEquipamento(Convert.ToInt32(txtcodEquipamento.Text), txtDescEquipamento.Text, txtFuncaoEquipamento.Text, txtCodFamiliaEquipamento.Text, txtDescFamiliaEquipamento.Text, txtFichaEquipamento.Text, txtFabricanteEquipamento.Text, txtModeloEquipamento.Text, txtNserieEquipamentos.Text, this.dtAnoFabricacaoEquipamento.Value, this.dtGarantiaEquipamento.Value, this.dtAquisicaoEquipamento.Value, rcComplementoEquipamento.Text, txtLocalizacaoEquipamento.Text, statusOperacao, this.dtStatusInicioEquipamento.Value, this.dtStatusFimEquipamento.Value, cmbDescTipo, cmbTipoEquipamento.Text, txtNumNotaFiscalEquipamento.Text, txtChaveDeAcessoEquipamento.Text, ClassDadosGet.IDUsuario, DateTime.Now);

                LimparBox();
            }
        }
        private void LimparBox()
        {
            // Limpe os campos do formulário
            txtcodEquipamento.Text = "";
            txtDescEquipamento.Text = "";
            txtFuncaoEquipamento.Text = "";
            txtCodFamiliaEquipamento.Text = "";
            txtDescFamiliaEquipamento.Text = "";
            txtFichaEquipamento.Text = "";
            txtFabricanteEquipamento.Text = "";
            txtModeloEquipamento.Text = "";
            txtNserieEquipamentos.Text = "";
            dtAnoFabricacaoEquipamento.Value = DateTime.Now;
            dtGarantiaEquipamento.Value = DateTime.Now;
            dtAquisicaoEquipamento.Value = DateTime.Now;
            rcComplementoEquipamento.Text = "";
            txtLocalizacaoEquipamento.Text = "";
            // Continue limpando os outros campos

            // Defina os valores padrão para os campos
            rdStatusAtivoEquipamento.Checked = false;
            rdStatusInativoEquipamento.Checked = false;
            dtStatusInicioEquipamento.Value = DateTime.Now;
            dtStatusFimEquipamento.Value = DateTime.Now;
            cmbDescTipo = -1;
            cmbTipoEquipamento.SelectedIndex = -1;
            txtNumNotaFiscalEquipamento.Text = "";
            txtChaveDeAcessoEquipamento.Text = "";

            // Limpe o foco do controle atual
            ActiveControl = null;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 menuIni = new Form1();
            menuIni.Show();
            this.Visible = false;
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos (*.txt; *.doc)|*.txt;*.doc;*.docx|Todos os Arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFichaEquipamento.Text = openFileDialog.FileName;
            }
        }
        //private CodigoEquipamentos codFamiliaEquipamentoManager = new CodigoEquipamentos();
        private void cmbTipoEquipamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodigoEquipamentos codFamiliaEquipamentoManager = new CodigoEquipamentos("BC - ");
            if (cmbTipoEquipamento.SelectedIndex == 0)
            {
                string novoCodigo = codFamiliaEquipamentoManager.GerarNovo("BC - ");
                while (codFamiliaEquipamentoManager.EDuplicado(novoCodigo))
                {
                    novoCodigo = codFamiliaEquipamentoManager.GerarNovo("BC - ");
                }
                txtCodFamiliaEquipamento.Text = novoCodigo;
                txtDescFamiliaEquipamento.Text = cmbTipoEquipamento.Text;
            }
            else if(cmbTipoEquipamento.SelectedIndex == 1)
            {
                codFamiliaEquipamentoManager = new CodigoEquipamentos("BH - ");
                string novoCodigo = codFamiliaEquipamentoManager.GerarNovo("BH - ");
                while (codFamiliaEquipamentoManager.EDuplicado(novoCodigo))
                {
                    novoCodigo = codFamiliaEquipamentoManager.GerarNovo("BH - ");
                }
                txtCodFamiliaEquipamento.Text = novoCodigo;
                txtDescFamiliaEquipamento.Text = cmbTipoEquipamento.Text;
            }
            else if (cmbTipoEquipamento.SelectedIndex == 2)
            {
                codFamiliaEquipamentoManager = new CodigoEquipamentos("BB - ");
                string novoCodigo = codFamiliaEquipamentoManager.GerarNovo("BB - ");
                while (codFamiliaEquipamentoManager.EDuplicado(novoCodigo))
                {
                    novoCodigo = codFamiliaEquipamentoManager.GerarNovo("BB - ");
                }
                txtCodFamiliaEquipamento.Text = novoCodigo;
                txtDescFamiliaEquipamento.Text = cmbTipoEquipamento.Text;
            }
            else if (cmbTipoEquipamento.SelectedIndex == 3)
            {
                codFamiliaEquipamentoManager = new CodigoEquipamentos("BV - ");
                string novoCodigo = codFamiliaEquipamentoManager.GerarNovo("BV - ");
                while (codFamiliaEquipamentoManager.EDuplicado(novoCodigo))
                {
                    novoCodigo = codFamiliaEquipamentoManager.GerarNovo("BV - ");
                }
                txtCodFamiliaEquipamento.Text = novoCodigo;
                txtDescFamiliaEquipamento.Text = cmbTipoEquipamento.Text;
            }
            else if (cmbTipoEquipamento.SelectedIndex == 4)
            {
                codFamiliaEquipamentoManager = new CodigoEquipamentos("CA - ");
                string novoCodigo = codFamiliaEquipamentoManager.GerarNovo("CA - ");
                while (codFamiliaEquipamentoManager.EDuplicado(novoCodigo))
                {
                    novoCodigo = codFamiliaEquipamentoManager.GerarNovo("CA - ");
                }
                txtCodFamiliaEquipamento.Text = novoCodigo;
                txtDescFamiliaEquipamento.Text = cmbTipoEquipamento.Text;
            }
            else if (cmbTipoEquipamento.SelectedIndex == 5)
            {
                codFamiliaEquipamentoManager = new CodigoEquipamentos("CP - ");
                string novoCodigo = codFamiliaEquipamentoManager.GerarNovo("CP - ");
                while (codFamiliaEquipamentoManager.EDuplicado(novoCodigo))
                {
                    novoCodigo = codFamiliaEquipamentoManager.GerarNovo("CP - ");
                }
                txtCodFamiliaEquipamento.Text = novoCodigo;
                txtDescFamiliaEquipamento.Text = cmbTipoEquipamento.Text;
            }
            else if (cmbTipoEquipamento.SelectedIndex == 6)
            {
                codFamiliaEquipamentoManager = new CodigoEquipamentos("EC - ");
                string novoCodigo = codFamiliaEquipamentoManager.GerarNovo("EC - ");
                while (codFamiliaEquipamentoManager.EDuplicado(novoCodigo))
                {
                    novoCodigo = codFamiliaEquipamentoManager.GerarNovo("EC - ");
                }
                txtCodFamiliaEquipamento.Text = novoCodigo;
                txtDescFamiliaEquipamento.Text = cmbTipoEquipamento.Text;
            }
            else if (cmbTipoEquipamento.SelectedIndex == 7)
            {
                codFamiliaEquipamentoManager = new CodigoEquipamentos("ES - ");
                string novoCodigo = codFamiliaEquipamentoManager.GerarNovo("ES - ");
                while (codFamiliaEquipamentoManager.EDuplicado(novoCodigo))
                {
                    novoCodigo = codFamiliaEquipamentoManager.GerarNovo("ES - ");
                }
                txtCodFamiliaEquipamento.Text = novoCodigo;
                txtDescFamiliaEquipamento.Text = cmbTipoEquipamento.Text;
            }
            else if (cmbTipoEquipamento.SelectedIndex == 8)
            {
                codFamiliaEquipamentoManager = new CodigoEquipamentos("EX - ");
                string novoCodigo = codFamiliaEquipamentoManager.GerarNovo("EX - ");
                while (codFamiliaEquipamentoManager.EDuplicado(novoCodigo))
                {
                    novoCodigo = codFamiliaEquipamentoManager.GerarNovo("EX - ");
                }
                txtCodFamiliaEquipamento.Text = novoCodigo;
                txtDescFamiliaEquipamento.Text = cmbTipoEquipamento.Text;
            }
            else if (cmbTipoEquipamento.SelectedIndex == 9)
            {
                codFamiliaEquipamentoManager = new CodigoEquipamentos("ME - ");
                string novoCodigo = codFamiliaEquipamentoManager.GerarNovo("ME - ");
                while (codFamiliaEquipamentoManager.EDuplicado(novoCodigo))
                {
                    novoCodigo = codFamiliaEquipamentoManager.GerarNovo("ME - ");
                }
                txtCodFamiliaEquipamento.Text = novoCodigo;
                txtDescFamiliaEquipamento.Text = cmbTipoEquipamento.Text;
            }
            else if (cmbTipoEquipamento.SelectedIndex == 10)
            {
                codFamiliaEquipamentoManager = new CodigoEquipamentos("PV - ");
                string novoCodigo = codFamiliaEquipamentoManager.GerarNovo("PV - ");
                while (codFamiliaEquipamentoManager.EDuplicado(novoCodigo))
                {
                    novoCodigo = codFamiliaEquipamentoManager.GerarNovo("PV - ");
                }
                txtCodFamiliaEquipamento.Text = novoCodigo;
                txtDescFamiliaEquipamento.Text = cmbTipoEquipamento.Text;
            }
            else if (cmbTipoEquipamento.SelectedIndex == 11)
            {
                codFamiliaEquipamentoManager = new CodigoEquipamentos("PL - ");
                string novoCodigo = codFamiliaEquipamentoManager.GerarNovo("PL - ");
                while (codFamiliaEquipamentoManager.EDuplicado(novoCodigo))
                {
                    novoCodigo = codFamiliaEquipamentoManager.GerarNovo("PL - ");
                }
                txtCodFamiliaEquipamento.Text = novoCodigo;
                txtDescFamiliaEquipamento.Text = cmbTipoEquipamento.Text;
            }
            else if (cmbTipoEquipamento.SelectedIndex == 12)
            {
                codFamiliaEquipamentoManager = new CodigoEquipamentos("TH - ");
                string novoCodigo = codFamiliaEquipamentoManager.GerarNovo("TH - ");
                while (codFamiliaEquipamentoManager.EDuplicado(novoCodigo))
                {
                    novoCodigo = codFamiliaEquipamentoManager.GerarNovo("TH - ");
                }
                txtCodFamiliaEquipamento.Text = novoCodigo;
                txtDescFamiliaEquipamento.Text = cmbTipoEquipamento.Text;
            }
            else if (cmbTipoEquipamento.SelectedIndex == 13)
            {
                codFamiliaEquipamentoManager = new CodigoEquipamentos("TB - ");
                string novoCodigo = codFamiliaEquipamentoManager.GerarNovo("TB - ");
                while (codFamiliaEquipamentoManager.EDuplicado(novoCodigo))
                {
                    novoCodigo = codFamiliaEquipamentoManager.GerarNovo("TB - ");
                }
                txtCodFamiliaEquipamento.Text = novoCodigo;
                txtDescFamiliaEquipamento.Text = cmbTipoEquipamento.Text;
            }
        }

        private void btnImprimirFichaEquipamento_Click(object sender, EventArgs e)
        {
            OleDbCommand dbCommand = new OleDbCommand("SELECT col_codEquipamento,col_fichaEquipamento,col_fichaEquipamentoNome FROM TB_CadastroEquipamentosDB_SIGT WHERE col_codEquipamento = ?", DatabaseConnection.DB_SIGT());
            dbCommand.Parameters.Add("col_codEquipamento", OleDbType.BSTR).Value = txtcodEquipamento.Text;
            OleDbDataReader reader = dbCommand.ExecuteReader();
            if (reader.Read())
            {
                byte[] arquivoBytes = (byte[])reader["col_fichaEquipamento"];
                string caminhoDoArquivo = (string)reader["col_fichaEquipamentoNome"];
                File.WriteAllBytes(caminhoDoArquivo, arquivoBytes);
                Process.Start(caminhoDoArquivo);
            }
        }

        private void txtFichaEquipamento_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFichaEquipamento.Text))
            {
                errorProvider1.SetError(txtFichaEquipamento, "Este campo é obrigatório.");
                e.Cancel = true; // Impede que o foco mude se a validação falhar
            }
            else
            {
                errorProvider1.SetError(txtFichaEquipamento, null); // Limpa qualquer erro existente
            }
        }
    }
}
