using SIGT___PCM.Conexoes;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGT___PCM.Cadastros.ClassesCadastros
{
    internal class CodigoFuncionario
    {
        private string ultimoNumeroGerado;
        public CodigoFuncionario(string abrevFuncao)
        {
            OleDbCommand oleDb = new OleDbCommand("SELECT TOP 1 col_codFuncaoFuncionario FROM TB_CadastroFuncionarioDB_SIGT WHERE col_codFuncaoFuncionario LIKE ? ORDER BY col_codFuncaoFuncionario DESC", DatabaseConnection.DB_SIGT());
            string padrao = "%" + abrevFuncao + "%";
            oleDb.Parameters.Add("col_codFuncaoFuncionario", OleDbType.BSTR, 12).Value = padrao;
            OleDbDataReader reader = oleDb.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                ultimoNumeroGerado = reader.GetString(0);
            }
            else
            {
                ultimoNumeroGerado = "0";
            }
        }
        public string GerarNovo(string abrev)
        {
            ultimoNumeroGerado.ToString();
            decimal soma1 = Convert.ToDecimal(ultimoNumeroGerado.Replace(abrev, ""));
            decimal soma2 = soma1 + 1;
            string generarNumero = $"{abrev} {soma2.ToString().PadLeft(6, '0')}";
            return generarNumero;
        }
    }
}
