using AuthAPI.application.repository_interfaces;
using AuthAPI.domain.entities;
using MySql.Data.MySqlClient;

namespace AuthAPI.infrastructure.db
{
    public class InSQLUserRepository : IUserRepository
    {
        private List<User> Users { get; set; }

        public InSQLUserRepository() : base()
        {
            this.Users = [];
        }

        public async Task save(User user)
        {
            string hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(user.password, 10);

            User userObj = new User(user.username, user.password, user.email);
            Console.WriteLine("User created:", userObj.ToString());


            this.Users.Add(userObj);
        }

        public async Task<User?> findByUsername(string username)
        {
            try
            {
                db database = new db();
                MySqlConnection conn = await database.getConnection();

                string sql = "SELECT * FROM users WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return new User(reader.GetString("username"), reader.GetString("password"), reader.GetString("email"));
                }
                
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return new User("", "", "a@b.com");
        }

    }
}
