namespace ConsoleApp3.domain;

public class Organizing(string name, string username, string password):Entity<Int32>
{
    public String Name { get; set; } = name;
    public String Username { get; set; } = username;
    public String Password { get; set; } = password;
}