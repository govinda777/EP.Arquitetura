using System;
using Kernel.Infra.EventStore.SqlServer.Context;

namespace Kernel.Infra.EventStore.SqlServer.Repository
{
    public class EventRepository
    {
        private readonly EscolaEventStoreContext _db = new EscolaEventStoreContext();

        public void Store(LoggedEvent eventToLog)
        {
            eventToLog.TimeStamp = DateTime.Now;
            _db.LoggedEvents.Add(eventToLog);
            _db.SaveChanges();
        }
    }
}