using challengeapp;

List<string> grades = new List<string>();
const string initialMessageE =
    "Witamy w Programie XYZ do oceny pracowników\n" +
    "===========================================\n" +
    "Zakres oceny pracownika to 0-100 lub\n" +
    "A-100, B-80, C-60, D-40, E-20, F-0\n";
const string initialMessageS =
    "Witamy w Programie XYZ do oceny kierownika\n" +
    "===========================================\n" +
    "Zakres oceny pracownika to 0-100 lub\n" +
    "A-100, B-80, C-60, D-40, E-20, F-0\n";

Console.WriteLine(initialMessageE);

var employee = new EmployeeInFile("Adam", "Kowalski");
//employee.SayHello(); //Wywołanie merody virtualnej
//employee.AddGrade(0.5f);

while (true)
{
    Console.WriteLine("Koniec wprowadzania wciśnij Q");
    Console.WriteLine("Podaj ocenę pracownika: ");

    var imput = Console.ReadLine();
    Console.Clear();
    if (imput == "q" || imput == "Q")
    {
        break;
    }
    Console.WriteLine(initialMessageE);
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
}
var supervision = new Supervision("Wojtek", "Michałowski", 'G', 25);
Console.WriteLine(initialMessageS);

while (true)
{
    Console.WriteLine("Koniec wprowadzania wciśnij Q");
    Console.WriteLine("Podaj ocenę kierownika: ");

    var imput = Console.ReadLine();
    Console.Clear();
    if (imput == "q" || imput == "Q")
    {
        break;
    }
    Console.WriteLine(initialMessageS);
    try
    {
        supervision.AddGrade(imput);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Błąd wyjątku \n{ex.Message}");
    }
    var statistics4 = supervision.RememberTheCollectedPoints();
    Console.Write($"Zebrane punkty: {statistics4.PointsCollected}\n");
}

Console.Clear();

var statistics = employee.GetStstistics();
Console.WriteLine($"Podsumowanie dla pracownika {employee.Name} {employee.Surname}\n");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Średnia punktacja wyrażona literą - {statistics.AverageLetter}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}\n");


var statistics3 = supervision.GetStstistics();
Console.WriteLine($"Podsumowanie dla kierownika {supervision.Name} {supervision.Surname}\n");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Średnia punktacja wyrażona literą - {statistics3.AverageLetter}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Min: {statistics3.Min}\n");
var imput3 = Console.ReadLine();
Console.Clear();
Console.WriteLine("\n\tKoniec\n");



