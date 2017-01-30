using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppData;

namespace TestAppObjects
{
    public class SiteObjects
    {
        private readonly ITestEntities _context;

        public SiteObjects()
        {
            _context = new TestEntities();
        }

        public SiteObjects(ITestEntities context)
        {
            _context = context;
        }

        public IList<Site> GetSites()
        {
            return _context.tblSites.ToList().Select(s => new Site(s)).ToList();
        }

        public ISite CreateSite(Site site)
        {
            var newSite = new tblSite()
            {
                ActionDetails = site.ActionDetails,
                Address = site.Address,
                ContactDetails = site.ContactDetails,
                SICcode = site.SICcode,
                SiteName = site.SiteName
            };

            _context.tblSites.Add(newSite);
            _context.SaveChanges();
            return new Site(newSite);
        }

        public ISite GetSiteByID(int siteID)
        {
            var site = _context.tblSites.FirstOrDefault(s => s.SiteID == siteID);
            return new Site(site);
        }

        public ISite UpdateSite(ISite site)
        {
            var existingSite = _context.tblSites.FirstOrDefault(s => s.SiteID == site.SiteID);
            if (existingSite != null)
            {
                _context.Entry(existingSite).CurrentValues.SetValues(new tblSite(site));
                _context.SaveChanges();
            }
            return site;
        }

        public void DeleteSite(int siteID)
        {
            var existingSite = _context.tblSites.FirstOrDefault(s => s.SiteID == siteID);
            if (existingSite != null)
            {
                _context.tblSites.Remove(existingSite);
                _context.SaveChanges();
            }
        }
    }
}
