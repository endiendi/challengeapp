using challengeapp;
using System.Reflection;

Employee employee1 = new Employee("Monika", "Kowalska", 35);
Employee employee2 = new Employee("Zuzia", "Makowska", 24);
Employee employee3 = new Employee("Dominik", "Dzikowski", 43);

employee1.AddScore(1);
employee1.AddScore(1);
employee1.AddScore(1);
employee1.AddScore(1);
employee1.AddScore(1);

employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(1);

employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(1);
employee3.AddScore(1);

var sameMax = new List<int>();
List<Employee> employees = new List<Employee>()
    {
    employee1, employee2, employee3
    };

int maxResult = -1;

foreach (var employee in employees)
{
    Console.WriteLine(employee.Name + "\t" + employee.Lastname + "\twiek\t" + employee.Age + "\t" + "Uzyskał wynik\t" + employee.Result);

    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
    }

}
Console.WriteLine("\nLista pracowników którzy uzyskali najlepszy wynik:\n");
foreach (var employee in employees)
    if (employee.Result == maxResult)
    {
        maxResult = employee.Result;
        Console.WriteLine(employee.Name + "\t" + employee.Lastname + "\twiek\t" + employee.Age + "\t" + "Uzyskał wynik\t" + employee.Result);

    }