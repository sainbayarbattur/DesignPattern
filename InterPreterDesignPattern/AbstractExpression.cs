using System;
using System.Collections.Generic;
using System.Text;

namespace InterPreterDesignPattern
{
    public interface AbstractExpression
    {
        void Evaluate(Context context);
    }
}
