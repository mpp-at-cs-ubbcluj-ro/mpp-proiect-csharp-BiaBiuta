namespace ConsoleApp3.domain;

public class Sample(SampleCategory sampleCategory, AgeCategory ageCategory) : Entity<int>
{
    private SampleCategory SampleCategory { get; set; } = sampleCategory;
    private AgeCategory AgeCategory { get; set; } = ageCategory;
}