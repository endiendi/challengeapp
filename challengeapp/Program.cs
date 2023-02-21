using challengeapp;
using System.Net.NetworkInformation;

var employee = new Employee("Adam", "Kowalski");

employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(200);
employee.AddGrade(9);
employee.AddGrade(-6);

var statistics = employee.GetStstistics();
//var statistics1 = employee.GetStstisticsForEch();
//var statistics2 = employee.GetStstisticsWithFor();
//var statistics3 = employee.GetStstisticsWithDoWhile();
//var statistics4 = employee.GetStstisticsWithWhile();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
