using DesignPattern.Iterator.AggregateInterface;
using DesignPattern.Iterator.ConcreteAggregate;
using DesignPattern.Iterator.IteratorInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Iterator.ConcreteIterator
{
    public class JellyBeanIterator : IJellyBeanIterator
    {
        private JellyBeanCollection _jellyBeans;
        private int _current = 0;
        private int _step = 1;

        public JellyBeanIterator(JellyBeanCollection beansCollection)
        {
            this._jellyBeans = beansCollection;
        }

        public bool IsDone
        {
            get { return _current >= _jellyBeans.Count; }
        }

        public JellyBean CurrentBean
        {
            get { return _jellyBeans[_current] as JellyBean; }
        }


    public JellyBean First()
        {
            _current = 0;
            return _jellyBeans[_current] as JellyBean;
        }

        public JellyBean Last()
        {
            _current = _jellyBeans.Count - 1;
            return _jellyBeans[_current] as JellyBean;
        }

        public JellyBean Next()
        {
            _current += _step;
            if(!IsDone)
            {
                return _jellyBeans[_current] as JellyBean;
            }
            else
            {
                return null;
            }
        }
    }
}
