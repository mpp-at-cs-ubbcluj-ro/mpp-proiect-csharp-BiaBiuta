namespace ConsoleApp3.domain;

public class Registration(Child child, Sample sample):Entity<int>
{
    public Child Child { get; set; } = child;
    public Sample Sample { get; set; } = sample;
    
}