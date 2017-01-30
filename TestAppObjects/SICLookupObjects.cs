using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppData;

namespace TestAppObjects
{
    public class SICLookupObjects
    {
        private readonly ITestEntities _context;
        public SICLookupObjects()
        {
            _context = new TestEntities();
        }

        public SICLookupObjects(ITestEntities context)
        {
            _context = context;
        }

        public IList<SICLookup> GetSICLookups()
        {
            return _context.tblSICLookups.ToList().Select(s => new SICLookup(s)).ToList();
        }
    }
}
