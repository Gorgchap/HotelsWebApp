namespace Models
{
    public class UserModel
    {
        public int Id { get; }
        public string Login { get; }
        public string Name { get; }
        public string Surname { get; }
        public string Email { get; }
        public string Phone { get; }
        public UserModel(int id, string login, string name, string surname, string email, string phone) { Id = id; Login = login; Name = name; Surname = surname; Email = email; Phone = phone; }
    }
}
