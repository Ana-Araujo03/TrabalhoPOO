using System;

namespace TrabalhoPOO.Banco
{
    public static class Configuracao_DB
    {
        private static string _connectionString = null!;

        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    _connectionString = PegarConnectionString();
                }
                return _connectionString;
            }
        }

        private static string PegarConnectionString()
        {
            // Configuração padrão
            return "Host=localhost;Username=postgres;Password=password;Database=estoque;Port=5432";
        }

        public static bool TestarConnection()
        {
            try
            {
                using (var conn = new Npgsql.NpgsqlConnection(ConnectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}