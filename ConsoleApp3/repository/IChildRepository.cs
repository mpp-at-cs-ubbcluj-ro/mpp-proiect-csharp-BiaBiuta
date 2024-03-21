using ConsoleApp3.domain;

namespace ConsoleApp3.repository;

public interface IChildRepository:IRepository<int,Child>
{
    Child Update(Child entityForUpdate);

    Child FindByName(string name);
}