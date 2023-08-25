using SIGT___PCM.Conexoes;
using SIGT___PCM.Mensagem;
using System;
using System.Data.OleDb;


namespace SIGT___PCM.Cadastros.ClassesCadastros
{
    internal class Funcionario
    {
        public void CadastroFuncionario(string matriculaFuncionario, string nomeCompletoFuncionario, string codFuncaoFuncionario, string descFuncaoFuncionario, bool vinculoEmpregaticioFuncionario, string categoriaFuncionario, string atividadePrincipalFuncionario, int disponibilidadeFuncionario, bool statusAtivadoDesativadoFuncionario, int usuarioCadastroFuncionario, DateTime dataCadastroUsuarioEquipamento, DateTime dataAdminissaoFuncionario, DateTime dataDemissaoFuncionario)
        {
            OleDbCommand oleDbCommand = new OleDbCommand("INSERT INTO TB_CadastroFuncionarioDB_SIGT (col_matriculaFuncionario, col_nomeCompletoFuncionario, col_codFuncaoFuncionario, col_descFuncaoFuncionario, col_vinculoEmpregaticioFuncionario, col_categoriaFuncionario, col_atividadePrincipalFuncionario, col_disponibilidadeFuncionario, col_statusAtivadoDesativadoFuncionario, col_usuarioCadastroFuncionario, col_dataCadatroUsuarioEquipamento, col_dataAdminissaoFuncionario, col_dataDemissaoFuncionario) " +
                "VALUES" +
                "(?,?,?,?,?,?,?,?,?,?,?,?,?)", DatabaseConnection.DB_SIGT());
            oleDbCommand.Parameters.Add("col_matriculaFuncionario", OleDbType.BSTR).Value = matriculaFuncionario;
            oleDbCommand.Parameters.Add("col_nomeCompletoFuncionario", OleDbType.BSTR).Value = nomeCompletoFuncionario;
            oleDbCommand.Parameters.Add("col_codFuncaoFuncionario", OleDbType.BSTR).Value = codFuncaoFuncionario;
            oleDbCommand.Parameters.Add("col_descFuncaoFuncionario", OleDbType.BSTR).Value = descFuncaoFuncionario;
            oleDbCommand.Parameters.Add("col_vinculoEmpregaticioFuncionario", OleDbType.Boolean).Value = vinculoEmpregaticioFuncionario;
            oleDbCommand.Parameters.Add("col_categoriaFuncionario", OleDbType.BSTR).Value = categoriaFuncionario;
            oleDbCommand.Parameters.Add("col_atividadePrincipalFuncionario", OleDbType.BSTR).Value = atividadePrincipalFuncionario;
            oleDbCommand.Parameters.Add("col_disponibilidadeFuncionario", OleDbType.Integer).Value = disponibilidadeFuncionario;
            oleDbCommand.Parameters.Add("col_statusAtivadoDesativadoFuncionario", OleDbType.Boolean).Value = statusAtivadoDesativadoFuncionario;
            oleDbCommand.Parameters.Add("col_usuarioCadastroFuncionario", OleDbType.BSTR).Value = usuarioCadastroFuncionario;
            oleDbCommand.Parameters.Add("col_dataCadatroUsuarioEquipamento", OleDbType.Date).Value = dataCadastroUsuarioEquipamento;
            oleDbCommand.Parameters.Add("col_dataAdminissaoFuncionario", OleDbType.Date).Value = dataAdminissaoFuncionario;
            oleDbCommand.Parameters.Add("col_dataDemissaoFuncionario", OleDbType.Date).Value = dataDemissaoFuncionario;
            try
            {
                int rowsInsert = oleDbCommand.ExecuteNonQuery();
                MensagemClasseDiag mensagem = new MensagemClasseDiag();
                mensagem.MostrarMensagemPersonalizadaInseridaCorretamente(matriculaFuncionario, "Funcionário");
            }
            catch
            {
                MensagemClasseDiag mensagem = new MensagemClasseDiag();
                mensagem.MostrarMensagemPersonalizadaInseridaErro("Funcionário");
            }
        }
        public void CadastroArquivosFuncionario()
        {

        }
        public void CadastroSemanaFuncionario()
        {

        }
    }
}
