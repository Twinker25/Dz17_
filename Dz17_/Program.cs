namespace Dz17_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Firma[] firms = new Firma[]
            {
                new Firma
                {
                    Title = "Food Company",
                    Date = "2023-01-25",
                    Profile = "Food",
                    PIB = "John White",
                    CountEmployers = 50,
                    Address = "123 Main St, London"
                },
                new Firma
                {
                    Title = "IT Solutions",
                    Date = "2015-05-10",
                    Profile = "IT",
                    PIB = "Jane Smith",
                    CountEmployers = 200,
                    Address = "456 Elm St, New York"
                },
                new Firma
                {
                    Title = "Marketing White",
                    Date = "2018-09-15",
                    Profile = "Marketing",
                    PIB = "Mike Black",
                    CountEmployers = 120,
                    Address = "789 Oak St, London"
                }
            };

            Console.WriteLine("Information about firms:");
            foreach (var firma in firms)
            {
                Console.WriteLine($"Title: {firma.Title}");
                Console.WriteLine($"Date: {firma.Date}");
                Console.WriteLine($"Profile: {firma.Profile}");
                Console.WriteLine($"Director: {firma.PIB}");
                Console.WriteLine($"Number of employees: {firma.CountEmployers}");
                Console.WriteLine($"Address: {firma.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var firmsWithFoodInTitle = firms.Where(firma => firma.Title.Contains("Food")).ToList();
            Console.WriteLine("Firms with 'Food' in the title:");
            foreach (var firma in firmsWithFoodInTitle)
            {
                Console.WriteLine($"Title: {firma.Title}");
                Console.WriteLine($"Date: {firma.Date}");
                Console.WriteLine($"Profile: {firma.Profile}");
                Console.WriteLine($"Director: {firma.PIB}");
                Console.WriteLine($"Number of employees: {firma.CountEmployers}");
                Console.WriteLine($"Address: {firma.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var marketingFirms = firms.Where(firma => firma.Profile == "Marketing").ToList();
            Console.WriteLine("Marketing firms:");
            foreach (var firma in marketingFirms)
            {
                Console.WriteLine($"Title: {firma.Title}");
                Console.WriteLine($"Date: {firma.Date}");
                Console.WriteLine($"Profile: {firma.Profile}");
                Console.WriteLine($"Director: {firma.PIB}");
                Console.WriteLine($"Number of employees: {firma.CountEmployers}");
                Console.WriteLine($"Address: {firma.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var marketingOrITFirms = firms.Where(firma => firma.Profile == "Marketing" || firma.Profile == "IT").ToList();
            Console.WriteLine("Marketing or IT firms:");
            foreach (var firma in marketingOrITFirms)
            {
                Console.WriteLine($"Title: {firma.Title}");
                Console.WriteLine($"Date: {firma.Date}");
                Console.WriteLine($"Profile: {firma.Profile}");
                Console.WriteLine($"Director: {firma.PIB}");
                Console.WriteLine($"Number of employees: {firma.CountEmployers}");
                Console.WriteLine($"Address: {firma.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var firmsWithMoreThan100Employees = firms.Where(firma => firma.CountEmployers > 100).ToList();
            Console.WriteLine("Firms with more than 100 employees:");
            foreach (var firma in firmsWithMoreThan100Employees)
            {
                Console.WriteLine($"Title: {firma.Title}");
                Console.WriteLine($"Date: {firma.Date}");
                Console.WriteLine($"Profile: {firma.Profile}");
                Console.WriteLine($"Director: {firma.PIB}");
                Console.WriteLine($"Number of employees: {firma.CountEmployers}");
                Console.WriteLine($"Address: {firma.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var firmsWith100to300Employees = firms.Where(firma => firma.CountEmployers >= 100 && firma.CountEmployers <= 300).ToList();
            Console.WriteLine("Firms with 100 to 300 employees:");
            foreach (var firma in firmsWith100to300Employees)
            {
                Console.WriteLine($"Title: {firma.Title}");
                Console.WriteLine($"Date: {firma.Date}");
                Console.WriteLine($"Profile: {firma.Profile}");
                Console.WriteLine($"Director: {firma.PIB}");
                Console.WriteLine($"Number of employees: {firma.CountEmployers}");
                Console.WriteLine($"Address: {firma.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var firmsInLondon = firms.Where(firma => firma.Address.Contains("London")).ToList();
            Console.WriteLine("Firms located in London:");
            foreach (var firma in firmsInLondon)
            {
                Console.WriteLine($"Title: {firma.Title}");
                Console.WriteLine($"Date: {firma.Date}");
                Console.WriteLine($"Profile: {firma.Profile}");
                Console.WriteLine($"Director: {firma.PIB}");
                Console.WriteLine($"Number of employees: {firma.CountEmployers}");
                Console.WriteLine($"Address: {firma.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var firmsWithDirectorLastNameWhite = firms.Where(firma => firma.PIB.Split(' ')[1] == "White").ToList();
            Console.WriteLine("Firms with director's last name 'White':");
            foreach (var firma in firmsWithDirectorLastNameWhite)
            {
                Console.WriteLine($"Title: {firma.Title}");
                Console.WriteLine($"Date: {firma.Date}");
                Console.WriteLine($"Profile: {firma.Profile}");
                Console.WriteLine($"Director: {firma.PIB}");
                Console.WriteLine($"Number of employees: {firma.CountEmployers}");
                Console.WriteLine($"Address: {firma.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var firmsFoundedMoreThanTwoYearsAgo = firms.Where(firma => DateTime.Parse(firma.Date) < DateTime.Now.AddYears(-2)).ToList();
            Console.WriteLine("Firms founded more than two years ago:");
            foreach (var firma in firmsFoundedMoreThanTwoYearsAgo)
            {
                Console.WriteLine($"Title: {firma.Title}");
                Console.WriteLine($"Date: {firma.Date}");
                Console.WriteLine($"Profile: {firma.Profile}");
                Console.WriteLine($"Director: {firma.PIB}");
                Console.WriteLine($"Number of employees: {firma.CountEmployers}");
                Console.WriteLine($"Address: {firma.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var firmsFounded123DaysAgo = firms.Where(firma => DateTime.Parse(firma.Date) == DateTime.Now.AddDays(-123).Date).ToList();
            Console.WriteLine("Firms founded 123 days ago:");
            foreach (var firma in firmsFounded123DaysAgo)
            {
                Console.WriteLine($"Title: {firma.Title}");
                Console.WriteLine($"Date: {firma.Date}");
                Console.WriteLine($"Profile: {firma.Profile}");
                Console.WriteLine($"Director: {firma.PIB}");
                Console.WriteLine($"Number of employees: {firma.CountEmployers}");
                Console.WriteLine($"Address: {firma.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var firmsBlackAndWhite = firms.Where(firma => firma.PIB.Split(' ')[1] == "Black" && firma.Title.Contains("White")).ToList();
            Console.WriteLine("Firms with director's last name 'Black' and 'White' in the title:");
            foreach (var firma in firmsBlackAndWhite)
            {
                Console.WriteLine($"Title: {firma.Title}");
                Console.WriteLine($"Date: {firma.Date}");
                Console.WriteLine($"Profile: {firma.Profile}");
                Console.WriteLine($"Director: {firma.PIB}");
                Console.WriteLine($"Number of employees: {firma.CountEmployers}");
                Console.WriteLine($"Address: {firma.Address}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();





            firms[0].Employees.Add(new Employee { FullName = "Lionel Doe", Position = "Manager", PhoneNumber = "23567890", Email = "din.doe@example.com", Salary = 5000 });
            firms[0].Employees.Add(new Employee { FullName = "Jane Smith", Position = "Developer", PhoneNumber = "23987654", Email = "jane.smith@example.com", Salary = 4000 });

            var employeesOfFirma = firms[0].Employees;
            Console.WriteLine("Employees of a specific firm:");
            foreach (var employee in employeesOfFirma)
            {
                Console.WriteLine($"Full Name: {employee.FullName}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine($"Phone Number: {employee.PhoneNumber}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter minimal salary: ");
            int minimumSalary = int.Parse(Console.ReadLine());
            var employeesWithHigherSalary = firms[0].Employees.Where(employee => employee.Salary > minimumSalary).ToList();
            Console.WriteLine("Employees of a specific firm with a salary higher than a certain amount:");
            foreach (var employee in employeesWithHigherSalary)
            {
                Console.WriteLine($"Full Name: {employee.FullName}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine($"Phone Number: {employee.PhoneNumber}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var employeesWithManagerPosition = firms.SelectMany(firma => firma.Employees.Where(employee => employee.Position == "Manager")).ToList();
            Console.WriteLine("Employees in all firms with the position 'Manager':");
            foreach (var employee in employeesWithManagerPosition)
            {
                Console.WriteLine($"Full Name: {employee.FullName}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine($"Phone Number: {employee.PhoneNumber}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var employeesWithPhoneNumberStartingWith23 = firms.SelectMany(firma => firma.Employees.Where(employee => employee.PhoneNumber.StartsWith("23"))).ToList();
            Console.WriteLine("Employees with a phone number starting with '23':");
            foreach (var employee in employeesWithPhoneNumberStartingWith23)
            {
                Console.WriteLine($"Full Name: {employee.FullName}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine($"Phone Number: {employee.PhoneNumber}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var employeesWithEmailStartingWithDi = firms.SelectMany(firma => firma.Employees.Where(employee => employee.Email.StartsWith("di"))).ToList();
            Console.WriteLine("Employees with an email starting with 'di':");
            foreach (var employee in employeesWithEmailStartingWithDi)
            {
                Console.WriteLine($"Full Name: {employee.FullName}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine($"Phone Number: {employee.PhoneNumber}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            var employeesWithNameLionel = firms.SelectMany(firma => firma.Employees.Where(employee => employee.FullName.StartsWith("Lionel"))).ToList();
            Console.WriteLine("Employees with the name 'Lionel':");
            foreach (var employee in employeesWithNameLionel)
            {
                Console.WriteLine($"Full Name: {employee.FullName}");
                Console.WriteLine($"Position: {employee.Position}");
                Console.WriteLine($"Phone Number: {employee.PhoneNumber}");
                Console.WriteLine($"Email: {employee.Email}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
            }
        }
    }
    class Firma
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Profile { get; set; }
        public string PIB { get; set; }
        public int CountEmployers { get; set; }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; }

        public Firma()
        {
            Employees = new List<Employee>();
        }
    }

    class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
    }
}