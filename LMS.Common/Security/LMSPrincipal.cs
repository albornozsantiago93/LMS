using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Common.Security
{
    public class LMSPrincipal : IPrincipal
    {
        public IIdentity Identity { internal set; get; }

        public LMSPrincipal(string userEmail)
        {
            IIdentity identity = new LMSIdentity(userEmail);
            Identity = identity;
        }
        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }
    }
}
