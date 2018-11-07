using DesignPattern.Iterator.AggregateInterface;
using DesignPattern.Iterator.ConcreteIterator;
using DesignPattern.Iterator.IteratorInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Iterator.ConcreteAggregate
{
   public class JellyBeanCollection : ICandyCollection
    {
        private ArrayList _items = new ArrayList();


        public JellyBeanIterator CreateIterator()
        {
            return new JellyBeanIterator(this);
        }


        // Gets jelly bean count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }

        public JellyBeanIterator JellyBeanIterator
        {
            get => default(JellyBeanIterator);
            set
            {
            }
        }
    }
}
