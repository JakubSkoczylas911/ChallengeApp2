using ConsoleApp2;

var employee = new Employee("Renata", "Skoczylas", 57);

employee.AddScore(5);
employee.AddScore(10);

employee.AddScore(6);
var statistics = employee.GetStatistics();

Console.WriteLine("Statistics with method Foreach");
Console.WriteLine($"Pracownik:{employee.Name} {employee.Surname}");
Console.WriteLine($"Średnia ocen:{statistics.Average:N2}");
Console.WriteLine($"Najniższa ocena:{statistics.Min:N2}");
Console.WriteLine($"Najwyższa ocena:{statistics.Max:N2}");
var statistics1 = employee.GetStatisticsWithFor();
Console.WriteLine("Statistics with method For");
Console.WriteLine($"Średnia ocen:{statistics1.Average}");
Console.WriteLine($"Najniższa ocena:{statistics1.Min}");
Console.WriteLine($"Najwyższa ocena:{statistics1.Max}");
var statistics2 = employee.GetStatisticsWithDoWhile();
Console.WriteLine("Statistics with method Do While");
Console.WriteLine($"Średnia ocena:{statistics2.Average:N2}");
Console.WriteLine($"Najwyższa ocena:{statistics2.Max}");
Console.WriteLine($"Najniższa ocena:{statistics2.Min}");
var statistics3 = employee.GetStatisticsWithWhile();
Console.WriteLine("Statistics with method While");
Console.WriteLine($"Średnia ocen:{statistics3.Average:N2}");
Console.WriteLine($"Najwyższa ocena:{statistics3.Max}");
Console.WriteLine($"Najniższa ocena:{statistics3.Min}");




