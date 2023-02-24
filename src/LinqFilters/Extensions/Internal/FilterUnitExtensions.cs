using System.Linq.Expressions;
using LinqFilters.Structs;

namespace LinqFilters.Extensions.Internal;

internal static class FilterUnitExtensions
{
    internal static Expression<Func<T, bool>> GenerateExpression<T>(this FilterUnit filterUnit)
    {
        var objectArgument = Expression.Parameter(typeof(T));

        var property = Expression.Property(objectArgument, filterUnit.PropertyName);
        var convertedProperty = Expression.Convert(property, typeof(object));

        var value = Expression.Constant(filterUnit.Value);
        var convertedValue = Expression.Convert(value, typeof(object));

        var filter = Expression.Invoke(filterUnit.Filter, convertedProperty, convertedValue);

        var resultLambda = Expression.Lambda(filter, objectArgument);
        var resultExpression = (Expression<Func<T, bool>>)resultLambda;
        return resultExpression;
    }
}