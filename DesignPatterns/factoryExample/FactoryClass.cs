using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.factoryExample
{
    public class FactoryClass
    {
        public IState factoryMethod()
        {
            string? str = Console.ReadLine();

            if(str == "salestate")
            {
                return new SaleState();
            }
            else if(str == "transactionstate")
            {
                return new TransactionState();
            }
            else
            {
                return new NoSaleState();
            }
        }
    }
}
