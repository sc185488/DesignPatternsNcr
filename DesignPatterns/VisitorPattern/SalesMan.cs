using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class SalesMan : IVisitor
    {
        public string Name { get; set; }
        public SalesMan(string name)
        {
            Name = name;
        }
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine("Salesman: " + this.Name + " gave the school bag to the child: "
                            + kid.KidName);
        }
    }
}
