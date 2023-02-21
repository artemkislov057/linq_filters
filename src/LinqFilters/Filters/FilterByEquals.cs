namespace LinqFilters.Filters;

public sealed class FilterByEquals : FilterBase
{
    public override bool Filter(object? source, object? value)
        => Equals(source, value);
}