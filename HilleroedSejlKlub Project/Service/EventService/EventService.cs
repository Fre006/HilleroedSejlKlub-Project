using HilleroedSejlKlub_Project.Models;
using System;
using System.Collections.Generic;

namespace HilleroedSejlKlub_Project.Services
{
    public class EventService
    {
        private List<Event> _events = new List<Event>();

        public EventService()
        {
            CreateEvent(new Event(1, "Informationsaften", new DateTime(2025, 4, 1)));
            CreateEvent(new Event(2, "Arbejdsdag", new DateTime(2025, 5, 1)));

            RegisterMemberToEvent(1, new Member(1, "Frederick"));
            RegisterMemberToEvent(1, new Member(2, "Youssef"));
            RegisterMemberToEvent(2, new Member(3, "Omar"));
            RegisterMemberToEvent(2, new Member(4, "Ahmed"));
        }

        public void CreateEvent(Event evt)
        {
            _events.Add(evt);
        }

        public List<Event> GetAllEvents()
        {
            return _events;
        }

        public Event GetEventById(int id)
        {
            foreach (Event evt in _events)
            {
                if (evt.Id == id)
                {
                    return evt;
                }
            }
            return null;
        }

        public void RegisterMemberToEvent(int eventId, Member member)
        {
            Event evt = GetEventById(eventId);
            if (evt != null)
            {
                evt.RegisterMember(member);
            }
        }

        public void UnregisterMemberFromEvent(int eventId, int memberId)
        {
            Event evt = GetEventById(eventId);
            if (evt != null)
            {
                evt.UnregisterMember(memberId);
            }
        }
    }
}
