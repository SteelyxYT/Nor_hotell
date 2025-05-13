using AuthAPI.application.repository_interfaces;
using AuthAPI.domain.entities;

namespace AuthAPI.application.use_cases
{
    public class RegisterUser
    {
        private readonly IUserRepository userRepository;

        public RegisterUser(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<User?> execute(string username, string password, string email)
        {
            User? existing = await this.userRepository.findByUsername(username);
            if (existing != null) { throw new Exception("User already exists"); }

            User user = new User(username, password, email);
            await this.userRepository.save(user);

            return user;
        }
    }
}
