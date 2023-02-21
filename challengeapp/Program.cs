using challengeapp;
using System.Net.NetworkInformation;

var employee = new Employee("Adam", "Kowalski");

employee.AddGrade(2f);
employee.AddGrade(5);
employee.AddGrade("200");
employee.AddGrade(9);
employee.AddGrade(-6);

var statistics1 = employee.GetStstisticsForEch();
var statistics2 = employee.GetStstisticsWithFor();
var statistics3 = employee.GetStstisticsWithDoWhile();
var statistics4 = employee.GetStstisticsWithWhile();

Console.WriteLine("ForEch");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Min: {statistics1.Min}\n");

Console.WriteLine("WithFor");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Min: {statistics2.Min}\n");

Console.WriteLine("WithDoWhile");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Min: {statistics3.Min}\n");

Console.WriteLine("WithWhile");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine($"Min: {statistics4.Min}\n");
