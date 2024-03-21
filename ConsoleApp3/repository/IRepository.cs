using ConsoleApp3.domain;

namespace ConsoleApp3.repository;

public interface IRepository<ID, E> where E : Entity<ID>
{
    E FindOne(ID id);
    IEnumerable<E> FindAll();
    E Save(E entity);
}