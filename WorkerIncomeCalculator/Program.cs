using System.Globalization;

Console.Write("Enter department's name: ");
string deptName = Console.ReadLine();
Console.WriteLine("Enter worker data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department department = new(deptName);
Worker worker = new(name, level, baseSalary, department);

Console.Write("How many contracts to this worker? ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i <= n; i++)
{
  Console.WriteLine($"Enter #{i} contract data:");
  Console.Write("Date (DD/MM/YYYY): ");
  DateTime date = DateTime.Parse(Console.ReadLine());
  Console.Write("Value per hour: ");
  double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  Console.Write("Duration (hours): ");
  int hours = int.Parse(Console.ReadLine());
  HourContract contract = new(date, valuePerHour, hours);
  worker.AddContract(contract);
  Console.WriteLine();
}

Console.WriteLine();

Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear[..2]);
int year = int.Parse(monthAndYear[3..]);

Console.WriteLine($"Name: {worker.Name}");
Console.WriteLine($"Department: {worker.Department.Name}");
Console.WriteLine($"Income for {monthAndYear}: {worker.Income(month, year).ToString("F2", CultureInfo.InvariantCulture)}");