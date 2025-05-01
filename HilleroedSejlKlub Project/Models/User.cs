namespace HilleroedSejlKlub_Project.Models
{
    public class User
    {
        //Instansvariables used in the creation of the User
        //Some are private set because we do not wish anyone the ability to change those parameters after object creation
        public string Name { get; set; }
        public string Password { get; private set; }
        public string MemberNumber { get; private set; }
        public int Age { get; set; }
        public bool Admin { get; private set; }
        
        //Default constructor so the site doesn't break if there are argument lacking.
        public User() { }

        //Constructor we generally wanna use
        public User(string name, string password, string memberNumber, int age, bool admin)
        {
            Name = name;
            Password = password;
            MemberNumber = memberNumber;
            Age = age;
            Admin = admin;
        }
    }
}
