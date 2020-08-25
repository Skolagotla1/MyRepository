using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class IMemoryTimeEntryRepository:ITimeEntryRepository
    {
        private readonly IDictionary<long, TimeEntry> te = new Dictionary<long, TimeEntry>();
        public TimeEntry Create(TimeEntry timeEntry)
        {
            var id = te.Count + 1;
            timeEntry.Id = id;
            te.Add(id, timeEntry);
            return timeEntry;
        }
        public TimeEntry Find(long id)
        {
            return te[id];
        }
        public bool Contains(long id)
        {
            return te.ContainsKey(id); 
        }
        public IEnumerable<TimeEntry> List()
        {
            return te.Values.ToList();
        }
        public TimeEntry Update(long id,TimeEntry timeEntry)
        {
            timeEntry.Id = id;
            te[id] = timeEntry;
            return timeEntry;
        }
        public void Delete(long id)
        {
            te.Remove(id);
        }

        
    }
}
