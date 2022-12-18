namespace Lab10_OOP.Task2
{
    enum AccessType
    {
        Admin,
        User,
        Operator
    }
    internal class AuthorizedData
    {
        public string Login { get; set; }
        public AccessType Access { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return "Login: " + Login + "\n" + ""
                + "Access type: " + Access + "\n" + ""
                + "Password: " + Password;
        }

        public void Deconstruct(out string Login, out AccessType? Access, out string Password)
        {
            Login = this.Login;
            Access = this.Access;
            Password = this.Password;
        }
    }
}
