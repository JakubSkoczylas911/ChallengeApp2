using ConsoleApp2;

var employee = new Employee("Renata", "Skoczylas", 57);

employee.AddScore(5);
employee.AddScore(10);

employee.AddScore(6);
var statistics = employee.GetStatistics();

Console.WriteLine($"Pracownik:{employee.Name} {employee.Surname}");
Console.WriteLine($"Średnia ocen:{statistics.Average:N2}");
Console.WriteLine($"Najniższa ocena:{statistics.Min:N2}");
Console.WriteLine($"Najwyższa ocena:{statistics.Max:N2}");
