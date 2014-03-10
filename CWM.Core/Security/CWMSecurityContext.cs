using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IdeaSeed.Core;
using CWM.Core.Domain.Interfaces;

namespace CWM.Core.Security
{
    public interface CWMSecurityContext : ISecurityContext
    {
        AuthenticationResponse AuthenticateUser(string userName, string password, string url, ISecurityContext securityContext);
        ApplicationContext AppContext { get; set; }
    }
}
