using ConsoleApp2;
Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine();
var employee = new EmployeeInFile("Jan", "Kowalski", "male");
employee.ScoreAdded += EmployeeScoreAdded;

void EmployeeScoreAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika?lub wprowadź q by poznac dotychczasowe statystyki");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddScore(input);
    }
    catch (Exception e)
    {

        Console.WriteLine($"Exeption catched:{e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Ocena najniższa:{statistics.Min}");
Console.WriteLine($"Ocena najwyższa:{statistics.Max}");
Console.WriteLine($"Ocena średnia:{statistics.Average:N2}");
Console.WriteLine($"średnia ocen wyrażona literą:{statistics.AverageLetter}");
