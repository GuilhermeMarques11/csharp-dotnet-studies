using System.Globalization;

Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());

List<Employee> employees = [];

for(int i = 1; i <= n; i++)
{
  Console.WriteLine($"Employee #{i} data:");
  Console.Write("Outsorced (y/n)? ");
  char isOutsourced = char.Parse(Console.ReadLine());
  Console.Write("Name: ");
  string name = Console.ReadLine();
  Console.Write("Hours: ");
  int hours = int.Parse(Console.ReadLine());
  Console.Write("Value per hour: ");
  double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  if(isOutsourced == 'y')
  {
    Console.Write("Additional charge: ");
    double addditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, addditionalCharge));
  }
  if(isOutsourced == 'n')
  {
    employees.Add(new Employee(name, hours, valuePerHour));
  }
  Console.WriteLine();
}

Console.WriteLine("Payments:".ToUpper());
foreach (Employee employee in employees)
{
  Console.WriteLine($"{employee.Name} - $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
}