namespace LINQ13;

public enum FirmaType
{
    Marketing,
    Sales,
    IT,
    Service,
    Merchandising,
    Manufacturing,
    Food
}

public enum WorkType
{
    Marketer,
    HR,
    Manager,
    TeamLead,
    Accountant,
    CustomerSupport,
    SMM,
    Developer,
    Lawyer,
    Security,
    Secretary
    
}
public record Firma(string Name, DateOnly Date, FirmaType Type, string CEO, int Workers, string Address, List<Employee> Employees)
{
public override string ToString()
{
    return $"{Name} since {Date}. ({Type})\nCEO - {CEO}\n{Workers} employees are located in {Address} ";
}
}

public record Employee(string Name, WorkType Type, string Phone, string Email, decimal Salary)
{
    public override string ToString()
    {
        return $"{Name} is a {Type} and earns {Salary}$\nPhone: {Phone}\nEmail: {Email}";
    }
}