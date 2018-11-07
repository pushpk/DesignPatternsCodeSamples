using DesignPattern.Iterator.ConcreteIterator;
using DesignPattern.Iterator.IteratorInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Iterator.AggregateInterface
{
    public interface ICandyCollection
    {
    
        JellyBeanIterator CreateIterator();
    }
}
