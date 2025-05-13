using MySql.Data.MySqlClient;

namespace AuthAPI.infrastructure.db
{
    public class db
    {

        private readonly string _connectionstring;

        public db()
        {
            _connectionstring = "Server=localhost;Database=nor_hotell_auth;Uid=root;Pwd=skole123;";
        }

        public async Task<MySqlConnection> getConnection()
        {
            return new MySqlConnection(_connectionstring);
        }

    }
}
