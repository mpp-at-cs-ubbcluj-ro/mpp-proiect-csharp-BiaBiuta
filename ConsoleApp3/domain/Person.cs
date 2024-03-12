namespace ConsoleApp3.domain;

public class Person(string name) : Entity<long>
{
    public String Name { get; set; } = name;
}