using challengeapp;
using System.Net.NetworkInformation;

var employee = new Employee("Adam", "Kowalski");

employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(200);
employee.AddGrade(1);
employee.AddGrade(6);

var statistics = employee.GetStstistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");


///* 
//SetSth(ref statistics); //wywoływanie ze słowem jawnie ref nadpisuje obiekt w pamięci
SetSth(out statistics);// wymuszenie nadpisanie
void SetSth(out Ststistics ststistics) //Przekazane przez wartość referęcje //ref przekazywanie przez referęcje można wtedy nad pisać

{
    ststistics = new Ststistics();//jeśli jest out wymusza nadpisanie
    //ststistics =new Ststistics();//nie można wymazać obiektu wewnątsz
}
//*/

decimal val1 = 9.99M;
decimal val2 = -5.10M;
Console.WriteLine("Result = " + Math.Ceiling(val1));
Console.WriteLine("Result = " + Math.Ceiling(val2));
Console.WriteLine("Result = " + Math.Floor(val1));
Console.WriteLine("Result = " + Math.Floor(val2));