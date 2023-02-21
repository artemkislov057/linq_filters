namespace LinqFilters.CLI;

public sealed class User
{
    public User(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public string Name { get; }
    public string Surname { get; }
    public int Age { get; }

    public override string ToString()
    {
        return $"User {Surname} {Name} {Age} years old.";
    }
}