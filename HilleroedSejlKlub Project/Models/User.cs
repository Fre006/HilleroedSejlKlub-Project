namespace HilleroedSejlKlub_Project.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Id { get; private set; }
        public string MemberNumber { get; private set; }
        public int Age { get; set; }
        public bool Admin { get; private set; }
        public User(string name, string id, string memberNumber, int age, bool admin)
        {
            Name = name;
            Id = id;
            MemberNumber = memberNumber;
            Age = age;
            Admin = admin;
        }
    }
}
