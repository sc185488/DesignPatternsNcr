using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
