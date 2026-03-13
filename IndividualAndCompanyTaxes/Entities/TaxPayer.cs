abstract class TaxPayer(string name, double anualIncome)
{
  public string Name { get; set; } = name;
  public double AnualIncome { get; set; } = anualIncome;

  public abstract double TaxCalculation();
}