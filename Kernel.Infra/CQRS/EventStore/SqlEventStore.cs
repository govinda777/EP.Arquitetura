using System.Collections.Generic;
using System.Web.Script.Serialization;
using Kernel.Infra.EventStore.SqlServer.Context;
using Kernel.Infra.EventStore.SqlServer.Repository;

namespace Kernel.Infra.CQRS.EventStore
{
    public class SqlEventStore : IEventStore
    {
        private static readonly EventRepository EventRepository = new EventRepository();

        public IEnumerable<Event> All(string matchId)
        {
            return null; //EventRepository.All(matchId);
        }

        public void Save<T>(T theEvent) where T : Event
        {
            var loggedEvent = new LoggedEvent()
            {
                Action = theEvent.Name,
                Cargo = new JavaScriptSerializer().Serialize(theEvent)
            };

            EventRepository.Store(loggedEvent);
        }
    }
}