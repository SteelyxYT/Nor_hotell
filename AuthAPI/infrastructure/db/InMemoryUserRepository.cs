using AuthAPI.application.repository_interfaces;
using AuthAPI.domain.entities;

namespace AuthAPI.infrastructure.db
{
    public class InMemoryUserRepository: IUserRepository
    {
        private List<User> Users { get; set; }

        public InMemoryUserRepository() : base()
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
            return this.Users.Find(user => user.username == username);
        }

    }
}
