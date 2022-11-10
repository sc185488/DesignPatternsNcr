using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.factoryExample2
{
    public class SaleState : IState
    {
        public void Get()
        {
            Console.WriteLine("Application is in Sale State");
        }
    }
}
