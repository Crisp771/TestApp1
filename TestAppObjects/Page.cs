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
    public class Page
    {
        [DataMember]
        [Key]
        public int PageID { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string PageContent { get; set; }

        public Page()
        {

        }

        public Page(IPage page)
        {
            this.PageID = page.PageID;
            this.PageContent = page.PageContent;
            this.Title = page.Title;
        }
    }
}
