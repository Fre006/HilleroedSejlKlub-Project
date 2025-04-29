namespace HilleroedSejlKlub_Project.wwwroot.lib.EventService
{
    public class EventService
    {
        private List<Event> events;

        public EventService()
        {
            events = new List<Event>();
        }

        public void CreateEvent(Event begivenhed)
        {
            events.Add(begivenhed);
        }

        public void RegisterMemberToEvent(int eventId, Member medlem)
        {
            foreach (Event begivenhed in events)
            {
                if (begivenhed.Id == eventId)
                {
                    begivenhed.RegisterMember(medlem);
                    break;
                }
            }
        }
}
