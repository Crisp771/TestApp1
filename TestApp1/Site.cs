using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppData
{
    public partial class tblSite : ISite
    {
        public tblSite()
        {

        }
        public tblSite(ISite site)
        {
            this.ActionDetails = site.ActionDetails;
            this.Address = site.Address;
            this.ContactDetails = site.ContactDetails;
            this.SICcode = site.SICcode;
            this.SiteName = site.SiteName;
            this.SiteID = site.SiteID;
        }
    }
}
