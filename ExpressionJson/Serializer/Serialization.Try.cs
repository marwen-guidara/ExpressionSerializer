using System;
using System.Linq.Expressions;

namespace Root.Services.ExpressionJson
{
    partial class Serializer
    {
        private bool TryExpression(Expression expr)
        {
            var expression = expr as TryExpression;
            if (expression == null) { return false; }

            throw new NotImplementedException();
        }
    }
}
