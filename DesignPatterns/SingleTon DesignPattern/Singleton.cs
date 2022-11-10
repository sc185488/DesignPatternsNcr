using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingleTon_DesignPattern
{
    public sealed class Singleton
    {
        public static int count = 0;

        public static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        public static Singleton getInstance
        {
            get
            {
                return instance.Value;
            }
        }

        private Singleton()
        {
            count++;
        }
        public void printDetails(string s)
        {
            Console.WriteLine($"{s} and count is {count}");
        }
    }
}
