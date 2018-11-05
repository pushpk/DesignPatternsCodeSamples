using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
public  interface IInternet
    {
        string connectTo(string serverHost);

    }
}
