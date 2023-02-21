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

        var result = users.Where(u => u.Surname == "Kislov").ToArray();
        Console.WriteLine(result.GetDisplayMessage());
    }
}