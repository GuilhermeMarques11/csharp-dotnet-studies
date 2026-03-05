using System.Diagnostics.Contracts;

class Worker(string name, WorkerLevel level, double baseSalary, Department department)
{
  public string Name { get; set; } = name;
  public WorkerLevel Level { get; set; } = level;
  public double BaseSalary { get; set; } = baseSalary;
  public Department Department { get; set; } = department;
  public List<HourContract> Contracts { get; set; } = [];

  public void AddContract(HourContract contract)
  {
    Contracts.Add(contract);
  }

  public void RemoveContract(HourContract contract)
  {
    Contracts.Remove(contract);
  }

  public double Income(int month, int year)
  {
   double sum = BaseSalary;
   foreach(HourContract contract in Contracts)
    {
      if (contract.Date.Month == month && contract.Date.Year == year)
      {
        sum += contract.TotalValue();
      }
    }
    return sum;
  }
}