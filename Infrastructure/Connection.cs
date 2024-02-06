using Dapper;
using MySql.Data.MySqlClient;

namespace MinhaApiBonita.Infrastructure
{
    public class Connection
    {
        protected string connectionString = "Server=viaduct.proxy.rlwy.net;Port=20821;Database=railway;User ID=root;Password=ebGcaaHCFHBhH2caAEdgde1Da51FafbG;";


        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        protected async Task<int> Execute(string sql, object obj)
        {
            using (MySqlConnection con = GetConnection())
            {
                return await con.ExecuteAsync(sql, obj);
            }
        }
    }
}
