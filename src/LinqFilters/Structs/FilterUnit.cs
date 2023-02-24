using System.Linq.Expressions;
using LinqFilters.Filters;

namespace LinqFilters.Structs;

internal struct FilterUnit
{
    public string PropertyName { get; init; }
    public object? Value { get; init; }
    public Expression<Filter> Filter { get; init; }
}