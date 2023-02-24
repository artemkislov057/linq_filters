using LinqFilters.Structs;

namespace LinqFilters.Extensions.Internal;

internal static class ObjectExtensions
{
    internal static IEnumerable<FilterUnit> GetFilterUnits(this object source)
        => source
            .GetType()
            .GetProperties()
            .Select(p => p.GetFilterUnit(source));
}