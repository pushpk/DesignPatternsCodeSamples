using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Iterator.IteratorInterface
{
    public interface IJellyBeanIterator
    {
        JellyBean First();
        JellyBean Next();

        JellyBean Last();


        bool IsDone { get; }
        JellyBean CurrentBean { get; }
        ConcreteIterator.JellyBeanIterator JellyBeanIterator { get; set; }
    }
}
