using Org.BouncyCastle.Math.EC;
using SIGT___PCM.Conexoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SIGT___PCM.Login
{
    internal class LoginLogar
    {
        public bool FMP = false;
        public bool RetornoFMP()
        {
            return FMP;
        }
        class ClassDadosGet
        {
            static public string Usuario { get; set; }
            static public string Senha { get; set; }
            static public Int32 IDUsuario { get; set; }
            static public Int32 Nivel { get; set; }
            static public Int32 Status { get; set; }
        }
        public void LogarAcesso(string user, string pass) 
        {
            try
            {
                if(DatabaseConnection.DB_SIGT().State == ConnectionState.Open)
                {
                    string tb_usuario = "SELECT * FROM TB_LoginDB_SIGT WHERE col_usuario = @user";
                    OleDbCommand oleDbCommand = new OleDbCommand(tb_usuario, DatabaseConnection.DB_SIGT());
                    oleDbCommand.Parameters.Add(new OleDbParameter("@user", user));
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.CloseConnection);

                    while (oleDbDataReader.Read())
                    {
                            ClassDadosGet.Usuario = Convert.ToString(oleDbDataReader["col_usuario"]);
                            ClassDadosGet.Senha = Convert.ToString(oleDbDataReader["col_senha"]);
                            ClassDadosGet.Status = Convert.ToInt32(oleDbDataReader["col_status"]);
                            ClassDadosGet.Nivel = Convert.ToInt32(oleDbDataReader["col_nivel"]);
                            ClassDadosGet.IDUsuario = Convert.ToInt32(oleDbDataReader["col_id"]);
                        }
                        if (ClassDadosGet.Senha == pass)
                        {
                            if (ClassDadosGet.Status == 1)
                            {
                                FMP = true;
                            }
                        }
                    }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
