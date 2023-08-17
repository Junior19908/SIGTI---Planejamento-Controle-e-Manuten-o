using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace SIGT___PCM.Conexoes
{
    public class DatabaseConnection
    {
        private OleDbConnection _connection;
        private string _connectionString;
        
        public AccessDatabaseConnection(string databasePath)
        {
            // Construa a string de conexão para o banco de dados Access
            _connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};Persist Security Info=False;";
            _connection = new OleDbConnection(_connectionString);
            _connection.Open();
        }
        public bool OpenConnection()
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir conexão: " + ex.Message);
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                if (_connection.State != ConnectionState.Closed)
                {
                    _connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao fechar conexão: " + ex.Message);
                return false;
            }
        }
        public DataTable ExecuteQuery(string query)
        {
            try
            {
                if (OpenConnection())
                {
                    OleDbCommand command = new OleDbCommand(query, _connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    CloseConnection();
                    return dataTable;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao executar consulta: " + ex.Message);
                CloseConnection();
                return null;
            }
        }
        public int ExecuteNonQuery(string query)
        {
            try
            {
                if (OpenConnection())
                {
                    OleDbCommand command = new OleDbCommand(query, _connection);
                    int rowsAffected = command.ExecuteNonQuery();
                    CloseConnection();
                    return rowsAffected;
                }
                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao executar consulta não query: " + ex.Message);
                CloseConnection();
                return -1;
            }
        }
    }
}
