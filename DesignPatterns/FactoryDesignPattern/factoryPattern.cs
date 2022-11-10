using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryDesignPattern
{
    public interface IProduct
    {
        public void someOperation();
    }
    public class concreteProduct1 : IProduct
    {
        public void someOperation()
        {
            Console.WriteLine("{ Result Of ConcreteProduct1 }");
        }
    }
    public class concreteProduct2 : IProduct
    {
        public void someOperation()
        {
            Console.WriteLine("{ Result Of ConcreteProduct2 }");
        }
    }
    public class factoryClass
    {
        public IProduct factoryMethod(string str)
        {
            if (str == "one")
            {
                return new concreteProduct1();
            }
            else { return new concreteProduct2(); }
        }
    }
    public class client
    {
        //public static void Main(string[] args)
        //{
        //    string? str = Console.ReadLine();
        //    factoryClass factoryClass = new factoryClass();
        //    IProduct product = factoryClass.factoryMethod(str);
        //    product.someOperation();
        //}
    }
}
