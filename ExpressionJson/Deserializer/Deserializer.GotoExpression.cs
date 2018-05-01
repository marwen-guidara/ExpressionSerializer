using System;
using System.Linq.Expressions;
using Newtonsoft.Json.Linq;
using Expr = System.Linq.Expressions.Expression;

namespace Root.Services.ExpressionJson
{
    partial class Deserializer
    {
        private GotoExpression GotoExpression(
            ExpressionType nodeType, System.Type type, JObject obj)
        {
            throw new NotImplementedException();
        }
    }
}
