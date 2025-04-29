namespace HilleroedSejlKlub_Project.wwwroot.lib.Event
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<Member> RegisteredMembers { get; set; }

        public Event(int id, string name, DateTime date)
        {
            Id = id;
            Name = name;
            Date = date;
            RegisteredMembers = new List<Member>();
        }

        public void RegisterMember(Member member)
        {
            RegisteredMembers.Add(member);
        }
    }
}
