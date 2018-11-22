using System.Collections.Generic;

namespace DesignPattern.State
{
    public interface IPolicyStateCommands : IPolicyState
    {
        List<string> ListValidOperations();
    }
}