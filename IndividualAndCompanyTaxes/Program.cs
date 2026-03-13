using System.Globalization;

List<TaxPayer> taxPayersList = [];

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
  Console.WriteLine($"\nTax payer #{i} data:");
  Console.Write("Individual or company (i/c)? ");
  char entity = char.Parse(Console.ReadLine());
  Console.Write("Name: ");
  string name = Console.ReadLine();
  Console.Write("Anual income: ");
  double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  if(entity == 'i')
  {
    Console.Write("Health exmpenditures: ");
    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    taxPayersList.Add(new Individual(name, anualIncome, healthExpenditures));
  } else
  {
    Console.Write("Number of employees: ");
    int numberOfEmployees = int.Parse(Console.ReadLine());
    taxPayersList.Add(new Company(name, anualIncome, numberOfEmployees));
  }
}

Console.WriteLine("\nTaxes paid:".ToUpper());
foreach (TaxPayer taxPayer in taxPayersList)
{
  Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.TaxCalculation().ToString("F2", CultureInfo.InvariantCulture)}");
}

double totalTaxes = 0.0;
foreach (TaxPayer taxPayer in taxPayersList)
{
  totalTaxes += taxPayer.TaxCalculation();
}

Console.WriteLine($"\nTOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
