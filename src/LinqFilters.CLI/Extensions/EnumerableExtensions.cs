namespace LinqFilters.CLI.Extensions;

public static class EnumerableExtensions
{
    public static string GetDisplayMessage<T>(this IEnumerable<T> source)
    {
        return string.Join("\n", source);
    }
}