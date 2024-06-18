using ConsoleApp2;

var employee = new Employee("Renata", "Skoczylas", 57);

employee.AddScore(5);
employee.AddScore(10);

employee.AddScore(6);
var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithFor();
var statistics2 = employee.GetStatisticsWithDoWhile();
var statistics3 = employee.GetStatisticsWithWhile();
Console.WriteLine("Statistics with method Foreach");
Console.WriteLine($"Pracownik:{employee.Name} {employee.Surname}");
Console.WriteLine($"Średnia ocen:{statistics.Average:N2}");
Console.WriteLine($"Najniższa ocena:{statistics.Min:N2}");
Console.WriteLine($"Najwyższa ocena:{statistics.Max:N2}");
Console.WriteLine("Statistics with method For");
Console.WriteLine($"Średnia ocen:{statistics.Average}");
Console.WriteLine($"Najniższa ocena:{statistics.Min}");
Console.WriteLine($"Najwyższa ocena:{statistics.Max}");
Console.WriteLine("Statistics with method Do While");
Console.WriteLine($"Średnia ocena:{statistics.Average:N2}");
Console.WriteLine($"Najwyższa ocena:{statistics.Max}");
Console.WriteLine($"Najniższa ocena:{statistics.Min}");
Console.WriteLine("Statistics with method While");
Console.WriteLine($"Średnia ocen:{statistics.Average:N2}");
Console.WriteLine($"Najwyższa ocena:{statistics.Max}");
Console.WriteLine($"Najniższa ocena:{statistics.Min}");




