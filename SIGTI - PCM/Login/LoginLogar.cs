using Org.BouncyCastle.Math.EC;
using SIGT___PCM.Conexoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using MetroFramework;
namespace SIGT___PCM.Login
{
    internal class LoginLogar
    {
        public void LogarAcesso(string user, string pass) 
        {
            try
            {
                if(DatabaseConnection.DB_SIGT().State == ConnectionState.Open)
                {
                    string tb_usuario = "SELECT * FROM TB_LoginDB_SIGT WHERE col_usuario = ?";
                    OleDbCommand oleDbCommand = new OleDbCommand(tb_usuario, DatabaseConnection.DB_SIGT());
                    oleDbCommand.Parameters.Add(new OleDbParameter("@user", user));
                    OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    string salt = "randomsalt";

                    while (oleDbDataReader.Read())
                    {
                            ClassDadosGet.Usuario = Convert.ToString(oleDbDataReader["col_usuario"]);
                            ClassDadosGet.Senha = HashPassword(Convert.ToString(oleDbDataReader["col_senha"]), salt);
                            ClassDadosGet.Status = Convert.ToInt32(oleDbDataReader["col_status"]);
                            ClassDadosGet.Nivel = Convert.ToInt32(oleDbDataReader["col_nivel"]);
                            ClassDadosGet.IDUsuario = Convert.ToInt32(oleDbDataReader["col_id"]);
                            string temaString = oleDbDataReader["col_userTema"].ToString();
                            if (Enum.TryParse(temaString, out MetroColorStyle tema))
                            {
                                ClassDadosGet.TemaUser = tema;
                            }
                            else
                            {
                                ClassDadosGet.TemaUser = MetroColorStyle.Default;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                byte[] combinedBytes = new byte[saltBytes.Length + passwordBytes.Length];
                Array.Copy(saltBytes, 0, combinedBytes, 0, saltBytes.Length);
                Array.Copy(passwordBytes, 0, combinedBytes, saltBytes.Length, passwordBytes.Length);

                byte[] hashBytes = sha256.ComputeHash(combinedBytes);

                return Convert.ToBase64String(hashBytes);
            }
        }
    }
}
