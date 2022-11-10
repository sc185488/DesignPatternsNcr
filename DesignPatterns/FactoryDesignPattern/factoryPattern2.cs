//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPatterns.FactoryDesignPattern
//{
//    public abstract class creator
//    {
//        public abstract IProduct FactoryMethod();
//        public void someOperation()
//        {
//            var product = FactoryMethod();
//            product.someOperation();
//        }
        
//    }
//    public class creatorContent1 : creator
//    {
//        public override IProduct FactoryMethod()
//        {
//            return new creatorProduct1();
//        }
//    }
//    public class creatorContent2 : creator
//    {
//        public override IProduct FactoryMethod()
//        {
//            return new creatorProduct2();
//        }
//    }
//    public interface IProduct
//    {
//        public void someOperation();
//    }
//    public class creatorProduct1 : IProduct
//    {
//        public void someOperation()
//        {
//            Console.WriteLine("{ Result Of Product1 }");
//        }
//    }
//    public class creatorProduct2 : IProduct
//    {
//        public void someOperation()
//        {
//            Console.WriteLine("{ Result Of Product2 }");
//        }
//    }
//    public  class client
//    {
//        public void Main()
//        {
//            string? str = Console.ReadLine();
//            if(str == "one")
//            {
//                ClientCode(new creatorContent1());
//            }
//            if (str == "two")
//            {
//                ClientCode(new creatorContent2());
//            }
//        }

//        private void ClientCode(creator creator)
//        {
//            creator.someOperation();
//        }
//    }
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            new client().Main();
//        }
//    }
//}
