namespace LinqFilters.Filters;

public abstract class FilterBase
{
    public abstract bool Filter(object? source, object? value);
}