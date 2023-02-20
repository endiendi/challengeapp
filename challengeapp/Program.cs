using challengeapp;
using System.Net.NetworkInformation;

var employee = new Employee("Adam", "Kowalski");//, 25);

employee.AddGrade(6);
employee.AddGrade(2);
employee.AddGrade(6);
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