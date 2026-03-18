using System.Globalization;

try
{
  Console.WriteLine("Enter account data:");
  Console.Write("Number: ");
  int number = int.Parse(Console.ReadLine());
  Console.Write("Holder: ");
  string holder = Console.ReadLine();
  Console.Write("Initial balance: ");
  double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  Console.Write("Withdraw limit: ");
  double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

  Account acc = new(number, holder, initialBalance, withDrawLimit);

  Console.Write("\nEnter amount for withdraw: ");
  double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  acc.Withdraw(withdraw);

  Console.WriteLine($"New balance: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
}
catch (DomainExecption e)
{
  Console.WriteLine(e.Message);
}
catch (Exception e)
{
  Console.WriteLine($"Unexpected error: {e.Message}");
}