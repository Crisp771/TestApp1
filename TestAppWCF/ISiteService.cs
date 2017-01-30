using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TestAppData;
using TestAppObjects;

namespace TestAppWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISiteService" in both code and config file together.
    [ServiceContract]
    public interface ISiteService
    {
        [OperationContract]
        IList<Site> GetSites();
        [OperationContract]
        Site GetSiteByID(int siteID);
        [OperationContract]
        Site CreateSite(Site site);
        [OperationContract]
        Site UpdateSite(Site site);
        [OperationContract]
        void DeleteSite(int siteID);
        [OperationContract]
        IList<SICLookup> GetSICLookups();
    }
}
