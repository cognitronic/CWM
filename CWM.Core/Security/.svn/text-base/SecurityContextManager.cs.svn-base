using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CWM.Core.Security
{
    public class SecurityContextManager
    {
        private static CWMSecurityContext _securityContext;

        private SecurityContextManager()
        { 
        
        }

        public static CWMSecurityContext Current
        {
            get
            {
                return _securityContext;
            }
            set
            {
                _securityContext = value;
            }
        }

    }
}
