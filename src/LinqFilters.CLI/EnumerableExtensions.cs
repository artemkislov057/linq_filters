namespace LinqFilters.CLI;

public static class EnumerableExtensions
{
    public static string GetDisplayMessage<T>(this IEnumerable<T> source)
    {
        return string.Join("\n", source);
    }
}