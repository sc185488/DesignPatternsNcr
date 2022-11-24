﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}
