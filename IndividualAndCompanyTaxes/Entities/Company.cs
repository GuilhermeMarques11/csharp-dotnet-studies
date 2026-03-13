class Company(string name, double anualIncome, int numberOfEmployees) : TaxPayer(name, anualIncome)
{
  public int NumberOfEmployees { get; set; } = numberOfEmployees;

  public override double TaxCalculation()
  {
    if(NumberOfEmployees <= 10)
    {
      return AnualIncome * 0.16;
    } else
    {
      return AnualIncome * 0.14;
    }
  }
}