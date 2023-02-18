using challengeapp;

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
employee2.AddScore(2);

employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(1);
employee3.AddScore(3);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

List<Employee> employees = new List<Employee>()
    {
    employee1, employee2, employee3
    };


int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
 Console.WriteLine(employee.Name + "\t" + employee.Lastname + "\twiek\t"  + employee.Age + "\t" + "Uzyskał wynik\t" + employee.Result);
   
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}
Console.WriteLine("\nNajlepszy wynik uzyskał pracownik:\n");
Console.WriteLine(employeeWithMaxResult.Name + "\t" + employeeWithMaxResult.Lastname + "\twiek\t" + employeeWithMaxResult.Age + "\t" + "Uzyskał wynik\t" + employeeWithMaxResult.Result);
