using AuthAPI.domain.entities;

namespace AuthAPI.application.repository_interfaces
{
    public interface IUserRepository
    {
        Task save(User user);

        Task<User?> findByUsername(string username);
    }
}
