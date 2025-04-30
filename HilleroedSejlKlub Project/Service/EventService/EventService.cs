//using System;
//using System.Collections.Generic;
//using System.Linq;
//using HilleroedSejlKlub_Project.Models;

//namespace HilleroedSejlKlub_Project.Services
//{
//    public class EventService
//    {
//        private List<Event> events;

//        public EventService()
//        {
//            events = new List<Event>(); 
//        }

//        public void CreateEvent(Event ev)
//        {
//            events.Add(ev); 
//        }

//        public Event GetEventById(int id)
//        {
//            foreach (Event evt in events)
//            {
//                if (evt.Id == id)
//                {
//                    return evt; 
//                }
//            }

//            return null; 
//        }

//        public void RegisterMemberToEvent(int eventId, Member member)
//        {
//            Event evt = GetEventById(eventId); 
//            if (evt != null)
//            {
//                evt.RegisteredMembers.Add(member); 
//            }
//        }

//        public void UnregisterMemberFromEvent(int eventId, int memberId)
//        {
//            Event evt = GetEventById(eventId); 
//            if (evt != null)
//            {
//                Member memberToRemove = null;

//                foreach (Member m in evt.RegisteredMembers)
//                {
//                    if (m.Id == memberId)
//                    {
//                        memberToRemove = m; 
//                        break;
//                    }
//                }

//                if (memberToRemove != null)
//                {
//                    evt.RegisteredMembers.Remove(memberToRemove); 
//                }
//            }
//        }

//        public List<Event> GetAllEvents()
//        {
//            return events; 
//        }
//    }
//}



using System;
using System.Collections.Generic;
using HilleroedSejlKlub_Project.Models;

namespace HilleroedSejlKlub_Project.Services
{
    public class EventService
    {
        private List<Event> _events;

        public EventService()
        {
            Event e1 = new Event(1, "Arbejdsdag", new DateTime(2025, 5, 1));
            e1.RegisterMember(new Member(2, "Youssef"));
            e1.RegisterMember(new Member(3, "Omar"));

            Event e2 = new Event(2, "Sejladsdag", new DateTime(2025, 6, 1));
            e2.RegisterMember(new Member(4, "Ahmed"));
            e2.RegisterMember(new Member(1, "Frederick"));


            _events = new List<Event> { e1, e2 };
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
