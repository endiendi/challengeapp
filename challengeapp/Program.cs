using challengeapp;

List<string> grades = new List<string>();

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================\n");

var employee = new Employee("Adam", "Kowalski");

while (true)
{

    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    Console.WriteLine("Wyjścia wciśnij q");


    var imput = Console.ReadLine();
    Console.Clear();
    string pointsCollected = "";
    grades.Add(imput);
    if (imput == "q" || imput == "Q")
    {
        if (pointsCollected=="")
        {
            employee.AddGrade(0);
        }
        break;
    }
    Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
    Console.WriteLine("===========================================\n");


    foreach (var grade in grades)
    {

pointsCollected += ($"{grade},");

        
    }
Console.Write($"Zebrane punkty: {pointsCollected}");
    Console.WriteLine("");
    employee.AddGrade(imput);

}
Console.Clear();

var statistics1 = employee.GetStstisticsForEch();
Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================\n");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Min: {statistics1.Min}\n");
Console.WriteLine($"Średnia punktacja wyrażona w wartościach literowych A-100, B-80, C-60, D-40, E-20");
Console.WriteLine($"Średnia literowa to: {statistics1.AverageLetter}");
