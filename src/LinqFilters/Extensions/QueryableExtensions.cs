using LinqFilters.Extensions.Internal;

namespace LinqFilters.Extensions;

public static class QueryableExtensions
{
    public static IQueryable<T> FilterBy<T>(this IQueryable<T> source, object filter) where T : notnull
        => filter.GetFilterUnits().Aggregate(source,
            (current, filterUnit) => current.Where(filterUnit.GenerateExpression<T>()));
}