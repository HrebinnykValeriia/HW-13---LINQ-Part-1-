namespace LINQ13;
using static System.Console;
using System.Linq;
public class Tasks
{
    public static void Task1()
    {
        Random random = new Random();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }
        array
            .ToList()
            .ForEach(item => Write(item + " ") );
        WriteLine();
        int [] even = array.Where(num => num % 2 == 0)
            .ToArray();
        even
            .ToList()
            .ForEach(item => Write(item + " ") );
        WriteLine();
        int [] odd = array.Where(num => num % 2 != 0)
            .ToArray();
        odd
            .ToList()
            .ForEach(item => Write(item + " ") );
        WriteLine();
        int first, second;
        Write("Enter First element: ");
        first = int.Parse(ReadLine());
        Write("Enter Second element: ");
        second = int.Parse(ReadLine());
        if (first > second)
        {
            (first, second) = (second, first);
        }
        int [] diapasonic = array.Where(num => num >= first && num <= second)
            .ToArray();
        diapasonic
            .ToList()
            .ForEach(item => Write(item + " ") );
        WriteLine();
        int[] query = array.Where(num => num % 7 == 0)
            .OrderBy(num => num)
            .ToArray();
        query
            .ToList()
            .ForEach(item => Write(item + " ") );
        WriteLine();
        int [] query8 = array.Where(num => num % 8 == 0)
            .OrderByDescending(num => num)
            .ToArray();
        query8
            .ToList()
            .ForEach(item => Write(item + " ") );
        WriteLine();
        ReadKey();
        Clear();
    }

    public static void Task2()
    {
        string[] cities =
        {
            "Kyiv",
            "London",
            "Paris",
            "Sydney",
            "Barcelona",
            "Athens",
            "Amsterdam",
            "Berlin",
            "New York"
        };
        cities 
            .ToList()
            .ForEach(item => Write(item + " ") );
        WriteLine();
        int length;
        Write("Enter length of the word: ");
        length = int.Parse(ReadLine());
        string[] arrayLength = cities.Where(city => city.Length == length)
            .ToArray();
        arrayLength
            .ToList()
            .ForEach(item => Write(item + " ") );
        WriteLine();
        string [] cityA = cities.Where(city => city.StartsWith("A"))
            .ToArray();
        cityA
            .ToList()
            .ForEach(item => Write(item + " ") );
        WriteLine();
        string [] cityB = cities.Where(city => city.EndsWith("m"))
            .ToArray();
        cityB
            .ToList()
            .ForEach(item => Write(item + " ") );
        WriteLine();
        string [] cityC = cities
            .Where(city => city.ToUpper().StartsWith("N") && city.EndsWith("k", StringComparison.OrdinalIgnoreCase))
            .ToArray();
        cityC
            .ToList()
            .ForEach(item => Write(item + " ") );
        WriteLine();
        ReadKey();
        Clear();
    }

    public static void Task3()
    {
        Student[] students = 
        {
            new Student("Valeriia", "Hrebinnyk", 22, "LNU"),
            new Student("Svyat", "Vladyka", 23, "MIT"),
            new Student("Bogdan", "Brother", 24, "Oxford"),
            new Student("Fedya", "Brown", 25, "Oxford"),
        };
        WriteLine("All students: ");
        students
            .ToList()
            .ForEach(item => WriteLine(item) );
        WriteLine();
        WriteLine("Last Name starts with 'Bro'");
        var studentsBro = students.Where(stud => stud.LastName.StartsWith("Bro"));
        studentsBro
            .ToList()
            .ForEach(item => WriteLine(item));
        WriteLine();
        WriteLine("Who older than 19: ");

        var students19 = students.Where(stud => stud.Age > 19);
        students19
            .ToList()
            .ForEach(item => WriteLine(item));
        WriteLine();
        WriteLine("Who older than 20 and younger than 23: ");
        var students20 = students.Where(stud => stud.Age > 20 && stud.Age < 23);
        students20
            .ToList()
            .ForEach(item => WriteLine(item));
        WriteLine();
        WriteLine("Who older than 19 and younger than 23 are and study at Oxford: ");
        var studentOxford = students.Where(stud => stud.School == "Oxford" && stud.Age > 18)
            .OrderByDescending(stud => stud.Age);
        studentOxford
            .ToList()
            .ForEach(item => WriteLine(item));
        ReadKey();
        Clear();
    }

    public static void Task4()
    {
        List<Firma> firmas = new List<Firma>
        {
            new Firma("White Food GmbH", new DateOnly(2018, 5, 12), FirmaType.Food,
                "John Black", 150, "London", new()),
            new Firma("Fresh Food Company", new DateOnly(2020, 3, 20), FirmaType.Food,
                "Michael White", 80, "Berlin", new()),
            new Firma("Digital Solutions", new DateOnly(2021, 8, 15), FirmaType.IT,
                "Robert Black", 250, "London", new()),
            new Firma("Smart Marketing", new DateOnly(2019, 11, 5), FirmaType.Marketing,
                "David White", 120, "Hamburg", new()),
            new Firma("TechWorld", new DateOnly(2022, 6, 10), FirmaType.IT, "James Brown",
                95, "London", new()),
            new Firma("Global Sales", new DateOnly(2023, 2, 18), FirmaType.Sales,
                "William Smith", 180, "Paris", new()),
            new Firma("White Marketing Group", new DateOnly(2017, 9, 25), FirmaType.Marketing, 
                "Thomas Black", 320, "London", new()),
            new Firma("Best Service", new DateOnly(2024, 1, 10), FirmaType.Service,
                "Daniel Wilson", 45, "Granada", new()),
            new Firma("Food Paradise", new DateOnly(2021, 4, 7), FirmaType.Food,
                "George Miller", 110, "London", new()),
            new Firma("IT Experts", new DateOnly(2020, 12, 1), FirmaType.IT, "Edward White",
                290, "Wittenberge", new()),
            new Firma("Fashion Merchandising", new DateOnly(2016, 7, 14), FirmaType.Merchandising,
                "Lera Black", 75, "Munich", new()),
            new Firma("White Manufacturing", new DateOnly(2015, 10, 30), FirmaType.Manufacturing,
                "Oliver Black", 450, "London", new()),
            new Firma("Marketing Pro", new DateOnly(2022, 2, 11), FirmaType.Marketing,
                "Jack Taylor", 200, "Kyiv", new()),
            new Firma("Black Food Ltd", new DateOnly(2024, 5, 19), FirmaType.Food, 
                "Peter White", 130, "Kharkiv", new()),
            new Firma("Creative IT", new DateOnly(2025, 1, 15), FirmaType.IT,
                "Christopher White", 60, "London", new()),
            new Firma("Summer Food", new DateOnly(2026, 7, 12), FirmaType.Food,
                "John White", 150, "London", new())
        };
        WriteLine("\nALL FIRMS: ");
        firmas
            .ForEach(item => WriteLine(item + "\n"));
        
        WriteLine("\nALL FIRMS WITH <<FOOD>>");
        var food = firmas.Where(item => item.Name.Contains("Food", StringComparison.CurrentCultureIgnoreCase));
        food
            .ToList()
            .ForEach(item => WriteLine(item + "\n"));
        
        WriteLine("\nMARKETING FIRMS: ");
        var marketing = firmas.Where(item => item.Type == FirmaType.Marketing);
        marketing
            .ToList()
            .ForEach(item => WriteLine(item + "\n"));
        
        WriteLine("\nMARKETING AND IT FIRMS: ");
        var it = firmas.Where(item => item.Type == FirmaType.IT || item.Type == FirmaType.Marketing);
        it
            .ToList()
            .ForEach(item => WriteLine(item + "\n"));
        
        WriteLine("\nFIRMS WITH MORE THAN 100 EMPLOYEES: ");
        var employees100 = firmas.Where(item => item.Workers >= 100);
        employees100
            .ToList()
            .ForEach(item => WriteLine(item + "\n"));
        
        WriteLine("\nFIRMS WHERE WORK 100-300 EMPLOYEES: ");
        var workers100 = firmas.Where(item => item.Workers >= 100 && item.Workers <= 300);
        workers100
            .ToList()
            .ForEach(item => WriteLine(item + "\n"));

        WriteLine("\nLONDON FIRMS: ");
        var london = firmas.Where(item => item.Address.Contains("London", StringComparison.CurrentCultureIgnoreCase));
        london
            .ToList()
            .ForEach(item => WriteLine(item + "\n"));

        WriteLine("\nCEO'S LAST NAME IS <<WHITE>>");
        var white = firmas.Where(item => item.CEO.Contains("White", StringComparison.CurrentCultureIgnoreCase));
        white
            .ToList()
            .ForEach(item => WriteLine(item + "\n"));

        WriteLine("\nCEO'S LAST NAME IS <<BLACK>> and OWNS COMPANY WITH WORD <<WHITE>> ");
        var black = firmas.Where(item => item.CEO.Contains("Black", StringComparison.CurrentCultureIgnoreCase) &&
                                         item.Name.Contains("White", StringComparison.CurrentCultureIgnoreCase));
        black
            .ToList()
            .ForEach(item => WriteLine(item + "\n"));
        
        WriteLine("\nFIRMAS THAT ARE OLDER THAN 2 YEARS: ");
        var older = firmas.Where(item => item.Date.Year < DateTime.Now.Year - 2 );
        older
            .ToList()
            .ForEach(item => WriteLine(item + "\n"));
        
        WriteLine("\nFIRMAS RELEASED 123 DAYS AGO");
        var day123 = firmas.Where(item => item.Date == DateOnly.FromDateTime(DateTime.Now).AddDays(-123));
        day123
            .ToList()
            .ForEach(item => WriteLine(item + "\n"));
        ReadKey();
        Clear();
    }

    public static void Task5()
    {
        WriteLine("\nDEFAULT ARRAY: ");
        Random random = new Random();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 1001);
        }
        array
            .ToList()
            .ForEach(item => Write(item + "\t") );
        
        WriteLine("\nSUM ARRAY: ");
        var sum = array
            .Select(x =>Sum(x))
            .ToArray();
        sum
            .ToList()
            .ForEach(item => Write(item + "\t") );

        
        WriteLine("\nSORTED ASCENDING: ");
        var arrAsc = array.OrderBy(x => Sum(x)).ToArray();
        arrAsc.ToList()
            .ForEach(item => Write(item + "\t") );
        
        WriteLine("\nSORTED DESCENDING: ");
        var arrDesc = array.OrderByDescending(x => Sum(x)).ToArray();
        arrDesc.ToList()
            .ForEach(item => Write(item + "\t"));
    }

    public static int Sum(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    public static void Task6()
    {
        WriteLine("\nFirst ARRAY: ");
        Random random = new Random();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 11);
        }
        array
            .ToList()
            .ForEach(item => Write(item + "\t") );
        
        WriteLine("\nSecond ARRAY: ");
        int[] array2 = new int[10];
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = random.Next(1, 11);
        }
        array2
            .ToList()
            .ForEach(item => Write(item + "\t") );
        
        WriteLine("\nUnique numbers: ");
        var unique = array.Distinct().ToArray();
        unique
            .ToList()
            .ForEach(item => Write(item + "\t") );
        
        WriteLine("\nFirst array without numbers from second array: ");
        var array3 = array
            .Except(array2)
            .ToArray();
        array3
            .ToList()
            .ForEach(item => Write(item + "\t") );
        
        WriteLine("\nThe same numbers from both arrays: ");
        var array4 = array.Intersect(array2).ToArray();
        array4
            .ToList()
            .ForEach(item => Write(item + "\t") );
        
        WriteLine("\nUnique numbers from both arrays: ");
        var array5 = array.Union(array2).ToArray();
        array5
            .Distinct()
            .ToList()
            .ForEach(item => Write(item + "\t") );
    }

    public static void Task7()
    {
        List<Employee> digitalEmployees = new List<Employee>
        {
            new Employee("Lionel Messi", WorkType.Developer, "231234567", "lionel@gmail.com", 5000),
            new Employee("Diana White", WorkType.Manager, "491234567", "diana@gmail.com", 4200),
            new Employee("Daniel Brown", WorkType.Developer, "239876543", "daniel@gmail.com", 3500)
        };

        List<Employee> marketingEmployees = new List<Employee>
        {
            new Employee("David Miller", WorkType.Marketer, "231112233", "david@gmail.com", 2800),
            new Employee("Diana Black", WorkType.SMM, "491112233", "diana.black@gmail.com", 2400),
            new Employee("Lionel Johnson", WorkType.Accountant, "491234111", "lionel.j@gmail.com", 3100)
        };

        List<Employee> foodEmployees = new List<Employee>
        {
            new Employee("Michael Smith", WorkType.CustomerSupport, "231234111", "michael@gmail.com", 2200),
            new Employee("Dmitry Ivanov", WorkType.HR, "491234222", "dmitry@gmail.com", 2700)
        };

        List<Employee> salesEmployees = new List<Employee>
        {
            new Employee("John White", WorkType.Manager, "231111222", "john@gmail.com", 3900),
            new Employee("Diana Wilson", WorkType.Secretary, "491111222", "diana.wilson@gmail.com", 2100)
        };

        List<Employee> serviceEmployees = new List<Employee>
        {
            new Employee("Lionel Brown", WorkType.CustomerSupport, "231555666", "lionel.brown@gmail.com", 2600),
            new Employee("Maria Laguerta", WorkType.Lawyer, "491555666", "olivia@gmail.com", 4500)
        };
        
        List<Firma> firmas = new List<Firma>
        {
            new Firma("White Food GmbH", new DateOnly(2018, 5, 12), FirmaType.Food,
                "John Black", 150, "London", foodEmployees),

            new Firma("Digital Solutions", new DateOnly(2021, 8, 15), FirmaType.IT,
                "Robert Black", 250, "London", digitalEmployees),

            new Firma("Smart Marketing", new DateOnly(2019, 11, 5), FirmaType.Marketing,
                "David White", 120, "Hamburg", marketingEmployees),

            new Firma("Global Sales", new DateOnly(2023, 2, 18), FirmaType.Sales,
                "William Smith", 180, "Paris", salesEmployees),

            new Firma("Best Service", new DateOnly(2024, 1, 10), FirmaType.Service,
                "Daniel Wilson", 45, "Granada", serviceEmployees)
        };
        WriteLine("\n ALL EMPLOYEES: ");
        var allEmployees = firmas.SelectMany(firma => firma.Employees);
        allEmployees
            .ToList()
            .ForEach(employee => WriteLine(employee + Environment.NewLine));
        
        WriteLine("\nALL <<DIGITAL SOLUTION>> EMPLOYEES, WHICH EARN MORE THAN 4000$");
        var employee = firmas
            .Where(firma => firma.Name == "Digital Solutions")
            .SelectMany(firma => firma.Employees)
            .Where(employee => employee.Salary > 4000);
        employee
            .ToList()
            .ForEach(employee => WriteLine(employee + Environment.NewLine));

        WriteLine("\nALL MANAGERS: ");
        var manager = firmas
            .SelectMany(firma => firma.Employees)
            .Where(employee => employee.Type == WorkType.Manager);
        manager
            .ToList()
            .ForEach(employee => WriteLine(employee + Environment.NewLine));

        WriteLine("\nALL PHONE NUMBERS, WHICH STARTS WITH 23: ");
        var phone = firmas
            .SelectMany(firma => firma.Employees)
            .Where(employee => employee.Phone.StartsWith("23"));
        phone
            .ToList()
            .ForEach(employee => WriteLine(employee + Environment.NewLine));
        
        WriteLine("\nALL EMAILS, WHICH STARTS WITH <<di>>: ");
        var email = firmas
            .SelectMany(firma => firma.Employees)
            .Where(employee => employee.Email.StartsWith("di", StringComparison.CurrentCultureIgnoreCase));
        email
            .ToList()
            .ForEach(employee => WriteLine(employee + Environment.NewLine));
        
        WriteLine("\nALL LIONEL EMPLOYEES: ");
        var lionel = firmas
            .SelectMany(firma => firma.Employees)
            .Where(employee => employee.Name.Contains("lionel",  StringComparison.CurrentCultureIgnoreCase));
        lionel
            .ToList()
            .ForEach(employee => WriteLine(employee + Environment.NewLine));

        

    }
}