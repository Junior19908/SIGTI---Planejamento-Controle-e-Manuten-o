using System;
using System.Data.OleDb;
using System.Windows.Forms;
using SIGT___PCM.Conexoes;

namespace SIGT___PCM.Cadastros.ClassesCadastros
{
    internal class CodigoEquipamentos
    {
        private string ultimoNumeroGerado;
        public CodigoEquipamentos(string abrevFamilia)
        {
            OleDbCommand oleDb = new OleDbCommand("SELECT TOP 1 col_codFamiliaEquipamento FROM TB_CadastroEquipamentosDB_SIGT WHERE col_codFamiliaEquipamento LIKE ? ORDER BY col_codFamiliaEquipamento DESC", DatabaseConnection.DB_SIGT());
            string padrao = "%"+abrevFamilia+ "%";
            oleDb.Parameters.Add("col_codFamiliaEquipamento", OleDbType.BSTR, 12).Value = padrao;
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
            decimal soma1 = Convert.ToDecimal(ultimoNumeroGerado.Replace(abrev,""));
            decimal soma2 = soma1 + 1;
            string generarNumero = $"{abrev} {soma2.ToString().PadLeft(6, '0')}";
            return generarNumero;
        }
        public bool EDuplicado(string codigo)
        {
            // Aqui você faria a verificação no banco de dados para verificar se o código já existe
            // Retorne true se estiver duplicado, e false se não estiver.
            // Exemplo fictício:
            // return Database.CheckIfCodeExists(code);
            return false;
        }
    }
}
