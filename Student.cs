namespace LINQ13;

public record Student(string FirstName, string LastName, int Age, string School)
{
    public override string ToString()
    {
        return $"{FirstName} {LastName} is {Age} years old and studies at {School}";
    }
}