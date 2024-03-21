namespace ConsoleApp3.domain;

public class Child (String name,Int32 age):Entity<Int32>
{
    public String Name { get; set; } = name;
    public Int32 Age { get; set; } = age;
    public Int32 NumberOfSamples { get; set; } = 0;
}