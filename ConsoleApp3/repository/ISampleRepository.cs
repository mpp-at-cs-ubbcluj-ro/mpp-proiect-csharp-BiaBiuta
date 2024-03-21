using ConsoleApp3.domain;

namespace ConsoleApp3.repository;

public interface ISampleRepository:IRepository<int,Sample>
{
    Sample FindOneByCategoryAndAge(string category, string ageCategory);

}