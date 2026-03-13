class Individual(string name, double anualIncome, double healthExpenditures) : TaxPayer(name, anualIncome)
{
  public double HealthExpenditures { get; set; } = healthExpenditures;

  public override double TaxCalculation()
  {
    
    if(AnualIncome < 20000.00)
    {
      if(HealthExpenditures > 0.0)
      {
        return (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
      } else
      {
        return AnualIncome * 0.15;
      }
    } else
    {
      if(HealthExpenditures > 0.0)
      {
        return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
      } else
      {
        return AnualIncome * 0.25;
      }
    }
  }
}