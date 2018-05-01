using System;
using System.Linq.Expressions;

namespace Root.Services.ExpressionJson
{
    partial class Serializer
    {
        private bool LabelExpression(Expression expr)
        {
            var expression = expr as LabelExpression;
            if (expression == null) { return false; }

            throw new NotImplementedException();
        }
    }
}
