using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TestAppData;

namespace TestAppObjects
{
    [DataContract(Namespace = "http://example.com")]
    public class Site : ISite
    {
        [DataMember]
        public string ActionDetails { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string ContactDetails { get; set; }
        [DataMember]
        public int SICcode { get; set; }
        [DataMember]
        [Key]
        [ScaffoldColumn(false)]
        public int SiteID { get; set; }
        [DataMember]
        public string SiteName { get; set; }

        public Site()
        {

        }

        public Site(ISite site)
        {
            this.ActionDetails = site.ActionDetails;
            this.Address = site.Address;
            this.ContactDetails = site.ContactDetails;
            this.SICcode = site.SICcode;
            this.SiteID = site.SiteID;
            this.SiteName = site.SiteName;
        }

    }
}
