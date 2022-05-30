using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
