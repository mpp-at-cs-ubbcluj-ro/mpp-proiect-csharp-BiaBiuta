using ConsoleApp3.domain;

namespace ConsoleApp3.repository;

public interface IRegistrationRepository:IRepository<int,Registration>
{
    List<Child> ListChildrenForSample(Sample sample);
    int NumberOfChildrenForSample(Sample sample);
}