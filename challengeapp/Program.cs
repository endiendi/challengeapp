using challengeapp;

List<string> grades = new List<string>();
const string initialMessage =
    "Witamy w Programie XYZ do oceny Pracowników\n" +
    "===========================================\n" +
    "Zakres oceny pracownika to 0-100 lub\n" +
    "A-100, B-80, C-60, D-40, E-20, F-0\n";

Console.WriteLine(initialMessage);

var employee = new Employee("Adam", "Kowalski");

while (true)
{
    Console.WriteLine("Koniec wprowadzania wciśnij q");
    Console.WriteLine("Podaj ocenę pracownika: ");

    var imput = Console.ReadLine();
    Console.Clear();
    string pointsCollected = "";
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
    
    var statistics2 = employee.RememberTheCollectedPoints();
    Console.Write($"Zebrane punkty: {statistics2.PointsCollected}\n");
    Console.WriteLine("");

}
Console.Clear();

var statistics1 = employee.GetStstisticsForEch();
Console.WriteLine(initialMessage);

Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Średnia punktacja wyrażona literą - {statistics1.AverageLetter}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Min: {statistics1.Min}\n");
var imput2 = Console.ReadLine();
Console.Clear();
Console.WriteLine("\n\tKoniec\n");



