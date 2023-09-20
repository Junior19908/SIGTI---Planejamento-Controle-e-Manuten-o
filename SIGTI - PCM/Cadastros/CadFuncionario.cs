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
        bool[] diasDaSemana = new bool[7]; // Um array para armazenar os valores dos dias da semana
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
            //funcionario.CadastroFuncionario(txtMatriculaFuncionario.Text, txtNomeCompletoFuncionario.Text, txtCodigoFuncaoFuncionario.Text, txtDescricaoCodigoFuncionario.Text, vinculoFuncionario, categoriaFuncionario, atividadeFuncionario, Convert.ToInt16(txtDisponibilidadeFuncionario.Text.Replace(" %","")), statusFuncionario, ClassDadosGet.IDUsuario, dateTime, this.dtAdminissaoFuncionario.Value, this.dtDemissaoFuncionario.Value);
            dataGridViewSemanaFuncionario.RowCount = 1;

            for (int rowIndex = 0; rowIndex < dataGridViewSemanaFuncionario.Rows.Count; rowIndex++)
            {
                DataGridViewRow row = dataGridViewSemanaFuncionario.Rows[rowIndex];
                bool[] diasDaSemana = new bool[7]; // Um array para armazenar os valores dos dias da semana

                // Loop through each cell in the row (skip first two cells - matriculaFuncionario and nomeCompletoFuncionario)
                for (int cellIndex = 2; cellIndex < row.Cells.Count; cellIndex++)
                {
                    DataGridViewCheckBoxCell cell = row.Cells[cellIndex] as DataGridViewCheckBoxCell;
                    diasDaSemana[cellIndex - 2] = Convert.ToBoolean(cell.Value);
                }

                // Adicione os parâmetros para os dias da semana
                for (int dayIndex = 0; dayIndex < diasDaSemana.Length; dayIndex++)
                {
                    //command.Parameters.AddWithValue($"col_{Enum.GetName(typeof(DayOfWeek), dayIndex)}", diasDaSemana[dayIndex]);
                    string parameterName = $"col_{Enum.GetName(typeof(DayOfWeek), dayIndex)}";
                    //command.Parameters.AddWithValue(parameterName, diasDaSemana[dayIndex]);

                    MessageBox.Show($"Parameter Name: {parameterName}\nParameter Value: {diasDaSemana[dayIndex]}");
                }
            }
        }

        private void dataGridViewSemanaFuncionario_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
