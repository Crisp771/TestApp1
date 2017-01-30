using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppData;

namespace TestAppObjects
{
    public class PageObjects
    {
        private readonly ITestEntities _context;

        public PageObjects()
        {
            _context = new TestEntities();
        }

        public PageObjects(ITestEntities context)
        {
            _context = context;
        }

        public IList<Page> GetPages()
        {
            return _context.tblPages.ToList().Select(s => new Page(s)).ToList();
        }

        public Page Page(int pageId)
        {
            var page = new Page(_context.tblPages.FirstOrDefault(s => s.PageID == pageId));
            return page;
        }

    }
}
