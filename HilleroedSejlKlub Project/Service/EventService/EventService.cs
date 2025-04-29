using System.Collections.Generic;
using HilleroedSejlKlub_Project.Models;

namespace HilleroedSejlKlub_Project.Services
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

        public List<Event> GetAllEvents()
        {
            return events;
        }
    }
}
