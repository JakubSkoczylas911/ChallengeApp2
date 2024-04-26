using ConsoleApp2;

var employee1 = new Employee("Renata", "Skoczylas", 57);

employee1.AddScore(10);
employee1.AddScore(5);
employee1.AddScore(1);
employee1.AddScore(5);
employee1.AddScore(2);
var statistics = employee1.GetStatistics();
Console.WriteLine($"Pracownik:{employee1.Name} {employee1.Surname}");
Console.WriteLine($"Średnia ocen:{statistics.Average:N2}");
Console.WriteLine($"Najniższa ocena:{statistics.Min:N2}");
Console.WriteLine($"Najwyższa ocena:{statistics.Max:N2}");



