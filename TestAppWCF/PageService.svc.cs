using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TestAppObjects;

namespace TestAppWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PageService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PageService.svc or PageService.svc.cs at the Solution Explorer and start debugging.
    public class PageService : IPageService
    {
        public Page GetPageByID(int pageId)
        {
            var page = new PageObjects().Page(pageId);
            return page;
        }

        public IList<Page> GetPages()
        {
            var pages = new PageObjects().GetPages();
            return pages;
        }
    }
}
