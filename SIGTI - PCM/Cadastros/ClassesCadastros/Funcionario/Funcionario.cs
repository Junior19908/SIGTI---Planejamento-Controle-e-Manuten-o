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
            DateTime dataDemissao;
            DateTime dataHoje = DateTime.Now.Date;
            if (dataHoje == dataDemissaoFuncionario)
            {
                dataDemissao = DateTime.MinValue;
            }
            else
            {
                dataDemissao = dataDemissaoFuncionario;
            }
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
            oleDbCommand.Parameters.Add("col_dataDemissaoFuncionario", OleDbType.Date).Value = dataDemissao;
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
        public void CadastroSemanaFuncionario(bool domingoCheck, bool segundaCheck, bool tercaCheck, bool quartaCheck, bool quintaCheck, bool sextaCheck, bool sabadoCheck, string idFuncionario)
        {
            OleDbCommand oleDbCommand = new OleDbCommand("INSERT INTO TB_SemanaFuncionarioDB_SIGT (col_domingo,col_segundaFeira,col_tercaFeira,col_quartaFeira,col_quintaFeira,col_sextaFeira,col_sabado,col_funcionarioCadastro)" +
                "VALUES" +
                "(?,?,?,?,?,?,?,?)", DatabaseConnection.DB_SIGT());
            oleDbCommand.Parameters.Add("col_domingo", OleDbType.Boolean).Value = domingoCheck;
            oleDbCommand.Parameters.Add("col_segundaFeira", OleDbType.Boolean).Value = segundaCheck;
            oleDbCommand.Parameters.Add("col_tercaFeira", OleDbType.Boolean).Value = tercaCheck;
            oleDbCommand.Parameters.Add("col_quartaFeira", OleDbType.Boolean).Value = quartaCheck;
            oleDbCommand.Parameters.Add("col_quintaFeira", OleDbType.Boolean).Value = quintaCheck;
            oleDbCommand.Parameters.Add("col_sextaFeira", OleDbType.Boolean).Value = sextaCheck;
            oleDbCommand.Parameters.Add("col_sabado", OleDbType.Boolean).Value = sabadoCheck;
            oleDbCommand.Parameters.Add("col_funcionarioCadastro", OleDbType.BSTR).Value = idFuncionario;
            oleDbCommand.ExecuteNonQuery();
        }
    }
}
