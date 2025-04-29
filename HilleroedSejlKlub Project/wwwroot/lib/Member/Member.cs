namespace HilleroedSejlKlub_Project.wwwroot.lib
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Member(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
