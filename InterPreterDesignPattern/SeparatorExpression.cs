using System;
using System.Collections.Generic;
using System.Text;

namespace InterPreterDesignPattern
{
    class SeparatorExpression : AbstractExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.expression;
            context.expression = expression.Replace(" ", "-");
        }
    }
}
