using System.Text.RegularExpressions;

namespace ConsoleApp3.domain.validators;

public class PersonValidator:IValidator<Person>
{
    public void Validate(Person e)
    {
        if (e.Name=="") {
            throw new ValidationException("Name cannot be empty");
        }
        if(!Regex.IsMatch(e.Name,"^[a-z].*")){
            throw  new ValidationException("the name must first with capslock");
        }
    }
}