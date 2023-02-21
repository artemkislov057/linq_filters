namespace LinqFilters.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<T> FilterBy<T>(this IEnumerable<T> source, object filter)
    {
        var filterProperties = filter.GetType().GetProperties();
        foreach (var filterProperty in filterProperties)
        {
            var filterPropertyValue = filterProperty.GetValue(filter);
            if (filterPropertyValue is null)
            {
                continue;
            }

            var filterPropertyName = filterProperty.Name;
            source = source.Where(e => e.GetType().GetProperty(filterPropertyName).GetValue(e) == filterPropertyValue);
        }

        return source;
    }
}