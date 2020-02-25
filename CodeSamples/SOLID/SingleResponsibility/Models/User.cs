namespace CodeSamples.SOLID.SingleResponsibility.Models
{
    public class User
    {
        private string _email;
        private string _password;

        public User(string email, string password)
        {
            this._email = email;
            this._password = password;
        }
    }
}