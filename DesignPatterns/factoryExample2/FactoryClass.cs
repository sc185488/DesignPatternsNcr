using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.factoryExample2
{
    public abstract class FactoryClass
    {
        public abstract IState getStateMethod();
        public void getState()
        {
            var state = getStateMethod();
            state.Get();
        }
        
    }
}
