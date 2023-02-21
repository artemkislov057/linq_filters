using LinqFilters.Structs;

namespace LinqFilters.Extensions;

internal static class ObjectExtensions
{
    internal static IEnumerable<FilterUnit> GetFilterUnits(this object source)
        => source
            .GetType()
            .GetProperties()
            .Select(p => p.GetFilterUnit(source));

    internal static bool CheckFiltrationByFilterUnit(this object source, FilterUnit filterUnit)
        => filterUnit.Filter.Filter(source.GetPropertyValue(filterUnit.PropertyName), filterUnit.Value);

    private static object? GetPropertyValue(this object source, string propertyName)
    {
        var type = source.GetType();
        var property = type.GetProperty(propertyName);
        if (property is null)
        {
            throw new NullReferenceException($"Type {type} has no property {propertyName}");
        }

        return property.GetValue(source);
    }
}