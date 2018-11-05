using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    public class ProxyInternet : IInternet
    {
        IInternet internet = new RealInternet();
        static List<string> bannedSites = new List<string> {
                
            "abc.com","def.com","a.com","b.com"
        };

        public string connectTo(string serverHost)
        {
            if(bannedSites.Contains(serverHost))
            {
                return "access to " + serverHost + " is denied";
            }

            return internet.connectTo(serverHost);
        
        }
    }
}
