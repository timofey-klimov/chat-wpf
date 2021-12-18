using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Chat.Core.Expressions
{
    public static class ExpressionExtensions
    {
        public static void SetPropertyValue<T>(this Expression<Func<T>> lambda, T value)
        {
            var expression = lambda.Body as MemberExpression;

            var propertyInfo = expression.Member as PropertyInfo;

            var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();

            propertyInfo.SetValue(target, value);
        }
    }
}
