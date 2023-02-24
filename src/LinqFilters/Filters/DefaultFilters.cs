using System.Linq.Expressions;

namespace LinqFilters.Filters;

public static class DefaultFilters
{
    public static readonly Expression<Filter> FilterByEquals = (a, b) => Equals(a, b);
}