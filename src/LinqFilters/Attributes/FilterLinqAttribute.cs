using LinqFilters.Filters;

namespace LinqFilters.Attributes;

public abstract class FilterLinqAttribute : Attribute
{
    public abstract FilterBase Filter { get; }
}