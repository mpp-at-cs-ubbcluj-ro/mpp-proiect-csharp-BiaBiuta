using ConsoleApp3.domain;

namespace ConsoleApp3.repository;

public interface IOrganizingRepository:IRepository<int,Organizing>
{
    Organizing FindByName(string username,string password);
}