using System.Globalization;

namespace EmployeeManagementConsole {
  class Program {
    static void Main(string[] args)
    {
      // List responsible for storing all registered employees in memory
      List<Employee> list = [];

      // Read how many employees will be created
      Console.Write("How many employees will be registered? ");
      int employeesQuantity = int.Parse(Console.ReadLine());

      // Loop to collect employee data and add each one to the list
      for (int i = 0; i < employeesQuantity; i++ )
      {
        Console.WriteLine($"Employee #{i + 1}:");
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Salary: ");
        double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        // Instantiate a new Employee object and add it to the list
        list.Add(new Employee(id, name, salary));
        Console.WriteLine();
      }

       // Display the initial list of employees
      Console.WriteLine("List of employees:");
      foreach (Employee obj in list)
      {
        Console.WriteLine(obj);
      }
      
      Console.WriteLine();

      // Search for an employee by ID to apply a salary increase
      Console.Write("Enter the employee id that will have salary increase: ");
      int searchId = int.Parse(Console.ReadLine());
      // Attempt to find the employee with the provided ID
      Employee emp = list.Find(e => e.Id == searchId);

      // Apply salary increase only if the employee exists
      if (emp != null)
      {
        Console.Write("Enter the percentage: ");
        double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
        // Business rule: salary update is handled internally by the Employee class
        emp.IncreaseSalary(percentage);
      } else
      {
        // Validation feedback if ID is not found
        Console.WriteLine("This id does not exist!");
      }

      Console.WriteLine();

       // Display updated employee list after possible salary modification
      Console.WriteLine("Updated list of employees:");
      foreach (Employee obj in list)
      {
        Console.WriteLine(obj);
      }
    }
  }
}