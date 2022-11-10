using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.factoryExample2
{
    public class Client
    {
        public void Main()
        {
            string? str = Console.ReadLine();
            if (str == "salestate")
            {
                ClientMode(new SaleStateAbstractClass());
            }
            else if(str == "transactionstate")
            {
                ClientMode(new TransactionStateAbstractClass());
            }
            else
            {
                ClientMode(new NoSaleStateAbstractClass());
            }
        }
        public void ClientMode(FactoryClass factoryClass)
        {
            factoryClass.getState();
        }
    }
}
