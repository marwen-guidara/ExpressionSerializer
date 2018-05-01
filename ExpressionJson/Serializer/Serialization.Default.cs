using System;
using System.Linq.Expressions;

namespace Root.Services.ExpressionJson
{
    partial class Serializer
    {
        private bool DefaultExpression(Expression expr)
        {
            var expression = expr as DefaultExpression;
            if (expression == null) { return false; }

            this.Prop("typeName", "default");

            return true;
        }
    }
}
