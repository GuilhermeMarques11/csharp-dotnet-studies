using System.Globalization;

namespace EmployeeManagementConsole
{
  class Employee
  {

    //Auto-implemented properties
   public int Id {get; set;}
   public string Name {get; set;}
   //The setter is private to ensure the salary is only modified internally
   public double Salary {get; private set;}

  //Constructor resposible fr initializing the object when a new Employee instance is created
   public Employee (int id, string name, double salary)
   {
    Id = id;
    Name = name;
    Salary = salary;
   }

  //Method to increase the emplyee's salary by a given percentage
   public void IncreaseSalary(double percentage)
    {
      Salary += Salary * percentage / 100.0;
    }

  //Provides a formatted string representation of the object
    public override string ToString()
    {
      return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
    }
  }
}