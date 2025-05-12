using System.Data;
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


    }
}
