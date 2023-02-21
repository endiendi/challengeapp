using challengeapp;
using System.Net.NetworkInformation;

var employee = new Employee("Adam", "Kowalski");

employee.AddGrade(2);
employee.AddGrade(5.5);
employee.AddGrade(200);
employee.AddGrade(9223372036854775807);
employee.AddGrade(-6);

var statistics = employee.GetStstistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
