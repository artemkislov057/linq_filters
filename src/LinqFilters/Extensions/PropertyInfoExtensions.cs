using System.Reflection;
using LinqFilters.Attributes;
using LinqFilters.Filters;
using LinqFilters.Structs;

namespace LinqFilters.Extensions;

internal static class PropertyInfoExtensions
{
    internal static FilterUnit GetFilterUnit(this PropertyInfo source, object sourceValue) =>
        new()
        {
            PropertyName = source.Name,
            Value = source.GetValue(sourceValue),
            Filter = source.GetFilter()
        };

    private static FilterBase GetFilter(this MemberInfo source)
    {
        var attribute = source.GetCustomAttributes().OfType<FilterLinqAttribute>().SingleOrDefault();
        return attribute is null ? new FilterByEquals() : attribute.Filter;
    }
}