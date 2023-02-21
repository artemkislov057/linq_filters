using LinqFilters.CLI.Entities;
using LinqFilters.CLI.Extensions;
using LinqFilters.CLI.Filters;
using LinqFilters.Extensions;

namespace LinqFilters.CLI;

public static class Program
{
    public static void Main(string[] args)
    {
        var users = new[]
        {
            new User("Artem", "Kislov", 20),
            new User("Artem", "Ivanov", 19)
        };

        var userFilter = new UserFilter { Surname = "Kislov" };
        var result = users.FilterBy(userFilter).ToArray();
        Console.WriteLine(result.GetDisplayMessage());
    }
}