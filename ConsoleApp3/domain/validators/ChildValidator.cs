namespace ConsoleApp3.domain.validators;

public class ChildValidator:IValidator<Child>
{
    public void Validate(Child e)
    {
        if(e.Age<6){
            throw new ValidationException("The child is too young");
        }
        if(e.Age>15){
            throw new ValidationException("There is not an ageCategory for this age");
        }
    }
}