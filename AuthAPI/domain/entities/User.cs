using Google.Protobuf.WellKnownTypes;

namespace AuthAPI.domain.entities
{
    public class User
    {
        public string id { get; }
        public string username { get; }
        public string email { get; }
        public string password { get; }
        public Timestamp createdAt { get; }

        public User(string username, string password, string email)
        {

            if (!email.Contains("@"))
            {
                throw new ArgumentException("Invalid email/does not contain @");
            }

            this.id = new Random().ToString().Substring(2, 9);

            this.username = username;
            this.email = email;
            this.password = password;

            this.createdAt = new Timestamp();
        }
    }
}
