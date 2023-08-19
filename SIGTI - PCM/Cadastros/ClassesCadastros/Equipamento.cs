using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using SIGT___PCM.Conexoes;
using System.Windows.Forms;
using System.IO;

namespace SIGT___PCM.Cadastros.ClassesCadastros
{
    internal class Equipamento
    {
        public void CadastroEquipamento(Int32 codEquipamento, string descricaoEquipamento, string funcaoEquipamento, string codFamiliaEquipamento, string familiaDescEquipamento, string fichaEquipamento, string fabricanteEquipamento, string modeloEquipamento, string nSerieEquipamento, DateTime anoFabricacaoEquipamento, DateTime dataGarantiaEquipamento, DateTime dataAquisicaoEquipamento, string complementoEquipamento, string localizacaoEquipamento, bool statusEquipamento, DateTime dataInicioStatusEquipamento, DateTime dataFimStatusEquipamento, Int32 codTipoEquipamento, string descTipoEquipamento, string notaFiscalEquipamento, string chaveAcessoNotaFiscalEquipamento, Int32 usuarioCadastroEquipamento, DateTime dataCadatroUsuarioEquipamento) 
        {
            OleDbCommand oleDbCommand = new OleDbCommand("INSERT INTO TB_CadastroEquipamentosDB_SIGT (col_codEquipamento, col_descricaoEquipamento, col_funcaoEquipamento, col_codFamiliaEquipamento, col_familiaDescEquipamento, col_fabricanteEquipamento, col_modeloEquipamento, col_nSerieEquipamento, col_anoFabricacaoEquipamento, col_dataGarantiaEquipamento, col_dataAquisicaoEquipamento, col_complementoEquipamento, col_localizacaoEquipamento, col_statusEquipamento, col_dataInicioStatusEquipamento, col_dataFimStatusEquipamento, col_codTipoEquipamento, col_descTipoEquipamento, col_notaFiscalEquipamento, col_chaveAcessoNotaFiscalEquipamento, col_usuarioCadastroEquipamento, col_dataCadatroUsuarioEquipamento, col_fichaEquipamentoNome, col_fichaEquipamento)" +
                "VALUES" +
                "(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", DatabaseConnection.DB_SIGT());
            oleDbCommand.Parameters.Add("col_codEquipamento", OleDbType.Integer).Value = codEquipamento;
            oleDbCommand.Parameters.Add("col_descricaoEquipamento", OleDbType.BSTR).Value = descricaoEquipamento;
            oleDbCommand.Parameters.Add("col_funcaoEquipamento", OleDbType.BSTR).Value = funcaoEquipamento;
            oleDbCommand.Parameters.Add("col_codFamiliaEquipamento", OleDbType.VarChar).Value = codFamiliaEquipamento;
            oleDbCommand.Parameters.Add("col_familiaDescEquipamento", OleDbType.BSTR).Value = familiaDescEquipamento;
            oleDbCommand.Parameters.Add("col_fabricanteEquipamento", OleDbType.BSTR).Value = fabricanteEquipamento;
            oleDbCommand.Parameters.Add("col_modeloEquipamento", OleDbType.BSTR).Value = modeloEquipamento;
            oleDbCommand.Parameters.Add("col_nSerieEquipamento", OleDbType.BSTR).Value = nSerieEquipamento;
            oleDbCommand.Parameters.Add("col_anoFabricacaoEquipamento", OleDbType.Date).Value = anoFabricacaoEquipamento;
            oleDbCommand.Parameters.Add("col_dataGarantiaEquipamento", OleDbType.Date).Value = dataGarantiaEquipamento;
            oleDbCommand.Parameters.Add("col_dataAquisicaoEquipamento", OleDbType.Date).Value = dataAquisicaoEquipamento;
            oleDbCommand.Parameters.Add("col_complementoEquipamento", OleDbType.BSTR).Value = complementoEquipamento;
            oleDbCommand.Parameters.Add("col_localizacaoEquipamento", OleDbType.BSTR).Value = localizacaoEquipamento;
            oleDbCommand.Parameters.Add("col_statusEquipamento", OleDbType.Boolean).Value = statusEquipamento;
            oleDbCommand.Parameters.Add("col_dataInicioStatusEquipamento", OleDbType.Date).Value = dataInicioStatusEquipamento;
            oleDbCommand.Parameters.Add("col_dataFimStatusEquipamento", OleDbType.Date).Value = dataFimStatusEquipamento;
            oleDbCommand.Parameters.Add("col_codTipoEquipamento", OleDbType.Integer).Value = codTipoEquipamento;
            oleDbCommand.Parameters.Add("col_descTipoEquipamento", OleDbType.BSTR).Value = descTipoEquipamento;
            oleDbCommand.Parameters.Add("col_notaFiscalEquipamento", OleDbType.BSTR).Value = notaFiscalEquipamento;
            oleDbCommand.Parameters.Add("col_chaveAcessoNotaFiscalEquipamento", OleDbType.BSTR).Value = chaveAcessoNotaFiscalEquipamento;
            oleDbCommand.Parameters.Add("col_usuarioCadastroEquipamento", OleDbType.BSTR).Value = usuarioCadastroEquipamento;
            oleDbCommand.Parameters.Add("col_dataCadatroUsuarioEquipamento", OleDbType.Date).Value = dataCadatroUsuarioEquipamento;
            oleDbCommand.Parameters.Add("col_fichaEquipamentoNome", OleDbType.BSTR).Value = Path.GetFileName(fichaEquipamento);
            if (String.IsNullOrEmpty(fichaEquipamento))
            {
                oleDbCommand.Parameters.Add("col_fichaEquipamento", OleDbType.VarBinary).Value = "";
            }
            else
            {
                byte[] arquivosByte = File.ReadAllBytes(fichaEquipamento);
                oleDbCommand.Parameters.Add("col_fichaEquipamento", OleDbType.VarBinary).Value = arquivosByte;
            }
            int rowsAffected = oleDbCommand.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Equipamento inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A inserção falhou. Verifique os dados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
