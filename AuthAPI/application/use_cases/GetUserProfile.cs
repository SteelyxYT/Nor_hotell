using AuthAPI.application.repository_interfaces;
using AuthAPI.domain.entities;

namespace AuthAPI.application.use_cases
{
    public class GetUserProfile
    {
        private readonly IUserRepository userRepository;

        public GetUserProfile(IUserRepository userRepository) {
            this.userRepository = userRepository;
        }

        public async Task<User?> execute(string username)
        {
            User? user = await this.userRepository.findByUsername(username);
            if (user == null) { throw new Exception("User not found"); }
            return user;
        }
    }
}
