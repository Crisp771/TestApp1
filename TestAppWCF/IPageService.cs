using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TestAppObjects;

namespace TestAppWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPageService" in both code and config file together.
    [ServiceContract]
    public interface IPageService
    {
        [OperationContract]
        Page GetPageByID(int pageId);
        [OperationContract]
        IList<Page> GetPages();
    }
}
