using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Newtonsoft.Json;

namespace Root.Services.ExpressionJson
{
    public static class ExpressionJson
    {
        public static string Serialize(LambdaExpression source)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new ExpressionJsonConverter(
                Assembly.GetAssembly(typeof(ExpressionJson))
            ));
            
            return JsonConvert.SerializeObject(source, settings);
        }

        public static LambdaExpression Deserialize(string json)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new ExpressionJsonConverter(
                Assembly.GetAssembly(typeof(ExpressionJson))
            ));
            
            return JsonConvert.DeserializeObject<LambdaExpression>(json, settings);
        }
    }
}
