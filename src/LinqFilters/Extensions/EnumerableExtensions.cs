using LinqFilters.Extensions.Internal;

namespace LinqFilters.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<T> FilterBy<T>(this IEnumerable<T> source, object filter) where T : notnull
        => filter.GetFilterUnits().Aggregate(source,
            (current, filterUnit) => current.Where(filterUnit.GenerateExpression<T>().Compile()));
}