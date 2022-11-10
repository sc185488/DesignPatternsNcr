using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.factoryExample2
{
    public class SaleStateAbstractClass : FactoryClass
    {
        public override IState getStateMethod()
        {
            return new SaleState();
        }
    }
}
