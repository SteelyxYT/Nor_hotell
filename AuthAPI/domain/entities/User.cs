namespace AuthAPI.domain.entities
{
    public class User
    {
        public int id { get; }
        public string username { get; }
        public string email { get; }
        public string password { get; }

        public string role { get; }

        public User(int id, string username, string email, string password, string role)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.password = password;
            this.role = role;
        }
    }
}
