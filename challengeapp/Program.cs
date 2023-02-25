using challengeapp;

List<string> grades = new List<string>();
const string initialMessage =
    "Witamy w Programie XYZ do oceny Pracowników\n" +
    "===========================================\n" +
    "Zakres oceny pracownika to 0-100 lub\n" +
    "A-100, B-80, C-60, D-40, E-20, F-0\n";

Console.WriteLine(initialMessage);

var employee = new Employee("Adam", "Kowalski",'G',25);

while (true)
{
    Console.WriteLine("Koniec wprowadzania wciśnij Q");
    Console.WriteLine("Podaj ocenę pracownika: ");

    var imput = Console.ReadLine();
    Console.Clear();
    grades.Add(imput);

    if (imput == "q" || imput == "Q")
    {
        break;
    }
    Console.WriteLine(initialMessage);
    try
    {
        employee.AddGrade(imput);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Błąd wyjątku \n{ex.Message}");
    }

    var statistics1 = employee.RememberTheCollectedPoints();
    Console.Write($"Zebrane punkty: {statistics1.PointsCollected}\n");
    Console.WriteLine("");

}
Console.Clear();

var statistics = employee.GetStstisticsForEch();
Console.WriteLine(initialMessage);

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Średnia punktacja wyrażona literą - {statistics.AverageLetter}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}\n");
var imput2 = Console.ReadLine();
Console.Clear();
Console.WriteLine("\n\tKoniec\n");



