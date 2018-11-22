using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public interface IPolicyState
    {
         void Open(DateTime? writtenDate = null);
        void Void();
        void Update();
        void Close(DateTime closedDate);
        void Cancel();

    }
}
