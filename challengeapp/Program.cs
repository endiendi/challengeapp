using challengeapp;
using static challengeapp.EmployeeBase;

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

var employee1 = new EmployeeInMemory("Adam", "Kowalski");
var employee = new EmployeeInFile("Adam", "Kowalski");

employee1.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args, float punkty)
{
    Console.Write($"Zapisano punkty \"Event\" {punkty} \n");
}
void EmployeeGradeAddedS(object sender, EventArgs args, float punkty)
{
    Console.Write($"Zapisano punkty \"Event\" {punkty} \n");
}
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
        employee1.AddGrade(imput);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Błąd wyjątku \n{ex.Message}");
    }
}
var supervision = new SupervisorInMemory("Wojtek", "Michałowski", 'G', 25);
supervision.GradeAdded += EmployeeGradeAddedS;
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
}

Console.Clear();
var statistics = employee1.GetStstistics();
if (statistics.Count != 0)
{
    Console.WriteLine($"Podsumowanie dla pracownika {employee1.Name} {employee1.Surname}\n");
    Console.WriteLine($"Liczna uzuskanych ocen {statistics.Count}. Suma ocen {statistics.Sum}.");
    Console.WriteLine($"Średnia punktacja wyrażona literą - {statistics.AverageLetter}");
    Console.WriteLine($"Average: {statistics.Average:N2}");
    Console.WriteLine($"Max: {statistics.Max}");
    Console.WriteLine($"Min: {statistics.Min}\n");
}
else
{
    Console.WriteLine($"Podsumowanie dla pracownika {employee1.Name} {employee1.Surname}\n");
    Console.WriteLine("Brak danych\n");
}
var statistics3 = supervision.GetStstistics();
if (statistics3.Count != 0)
{
    Console.WriteLine($"Podsumowanie dla kierownika {supervision.Name} {supervision.Surname}\n");
    Console.WriteLine($"Liczna uzuskanych ocen {statistics3.Count}. Suma ocen {statistics3.Sum}.");
    Console.WriteLine($"Średnia punktacja wyrażona literą - {statistics3.AverageLetter}");
    Console.WriteLine($"Average: {statistics3.Average:N2}");
    Console.WriteLine($"Max: {statistics3.Max}");
    Console.WriteLine($"Min: {statistics3.Min}\n");
}
else
{
    Console.WriteLine($"Podsumowanie dla kierownika {supervision.Name} {supervision.Surname}\n");
    Console.WriteLine("Brak danych\n");
}
var imput3 = Console.ReadLine();
Console.Clear();
Console.WriteLine("\n\tKoniec\n");



