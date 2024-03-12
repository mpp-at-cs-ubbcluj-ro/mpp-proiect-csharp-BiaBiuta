namespace ConsoleApp3.domain.validators;

public interface IValidator<E>
{
    void Validate(E e);
}