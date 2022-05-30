using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern
{
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}
