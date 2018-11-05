using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    public class RealInternet : IInternet
    {
        public string connectTo(string serverHost)
        {
            return "Connecting to " + serverHost;
        }
    }
}
