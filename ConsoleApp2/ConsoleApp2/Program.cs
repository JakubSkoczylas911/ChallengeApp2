using ConsoleApp2;
Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine();
var employee = new Employee();
while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika?");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddScore(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Ocena najniższa:{statistics.Min}");
Console.WriteLine($"Ocena najwyższa:{statistics.Max}");
Console.WriteLine($"Ocena średnia:{statistics.Average}");