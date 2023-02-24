using System.Linq.Expressions;
using LinqFilters.Filters;

namespace LinqFilters.Attributes;

public abstract class FilterLinqAttribute : Attribute
{
    public abstract Expression<Filter> Filter { get; }
}