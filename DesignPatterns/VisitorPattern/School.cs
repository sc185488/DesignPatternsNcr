using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class School
    {
        private static List<IElement> elements;
        static School()
        {
            elements = new List<IElement>
            {
                new Kid("Sai Maharshi"),
                new Kid("Nagarjuna M"),
                new Kid("Krishna Reddy")
            };
        }
        public void PerformOperation(IVisitor visitor)
        {
            foreach (var kid in elements)
            {
                kid.Accept(visitor);
            }
        }
    }
}
