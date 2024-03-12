namespace ConsoleApp3.domain;

public class Organizing(string name, string username, string password) : Person(name)
{
    public String Username { get; set; } = username;
    public String Password { get; set; } = password;
}