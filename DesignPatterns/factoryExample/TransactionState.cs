using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.factoryExample
{
    public class TransactionState : IState
    {
        public void Get()
        {
            Console.WriteLine("Application is in Transaction State");
        }
    }
}
