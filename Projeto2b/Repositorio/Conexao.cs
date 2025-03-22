using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto2b.Repositorio
{
    public class Conexao : IDisposable
    {
        //Declaração
        private MySqlConnection _connection;

        //Recebe os comando e leva ao mySql
        public MySqlCommand MySqlCommand()
        {
            return _connection.CreateCommand();
        }

        //Abre conexão
        public Conexao(string connectionString)
        {
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }

        //Fecha conexão
        public void Dispose()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
                _connection.Dispose();
            }
        }
    }
}
