using ConsoleApp2;

Employee employee1 = new Employee("Renata", "Skoczylas", 57);
Employee employee2 = new Employee("Marcin", "Skoczylas", 43);
Employee employee3 = new Employee("Jakub", "Skoczylas", 39);
employee1.AddScore(10);
employee1.AddScore(5);
employee1.AddScore(1);
employee1.AddScore(5);
employee1.AddScore(2);

employee2.AddScore(3);
employee2.AddScore(6);
employee2.AddScore(7);
employee2.AddScore(8);
employee2.AddScore(9);

employee3.AddScore(8);
employee3.AddScore(4);
employee3.AddScore(4);
employee3.AddScore(10);
employee3.AddScore(10);
List<Employee> employees = new List<Employee>()
{
    employee1 , employee2,employee3
    };
int maxScore = -1;
Employee employeeWithMaxScore = null;

foreach (var employee in employees)
{
    if (employee.score > maxScore)
    {
        employeeWithMaxScore = employee;
    }
}

Console.WriteLine($" (Najlepszy wynik) - {employeeWithMaxScore.Name} {employeeWithMaxScore.Surname}, z Wynikiem {employeeWithMaxScore.score}!");


