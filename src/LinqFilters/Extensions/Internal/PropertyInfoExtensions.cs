using System.Linq.Expressions;
using System.Reflection;
using LinqFilters.Attributes;
using LinqFilters.Filters;
using LinqFilters.Structs;

namespace LinqFilters.Extensions.Internal;

internal static class PropertyInfoExtensions
{
    internal static FilterUnit GetFilterUnit(this PropertyInfo source, object sourceValue) =>
        new()
        {
            PropertyName = source.Name,
            Value = source.GetValue(sourceValue),
            Filter = source.GetFilter()
        };

    private static Expression<Filter> GetFilter(this MemberInfo source)
    {
        var attribute = source.GetCustomAttributes().OfType<FilterLinqAttribute>().SingleOrDefault();
        return attribute is null ? DefaultFilters.FilterByEquals : attribute.Filter;
    }
}