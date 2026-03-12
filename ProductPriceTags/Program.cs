using System.Globalization;

List<Product> products = [];
Console.Write("Enter the number of produtcs: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
  Console.WriteLine($"\nProduct #{i} data");
  Console.Write("Common, used or imported (c/u/i)? ");
  char type = char.Parse(Console.ReadLine());
  Console.Write("Name: ");
  string name = Console.ReadLine();
  Console.Write("Price: ");
  double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

  if(type == 'u')
  {
    Console.Write("Manufacture date (DD/MM/YYYY): ");
    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
    products.Add(new UsedProduct(name, price, manufactureDate));
  } else if(type == 'i')
  {
    Console.Write("Customs fee: ");
    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    products.Add(new ImportedProduct(name, price, customsFee));
  } else
  {
    products.Add(new(name, price));
  }
}

Console.WriteLine("\nPrice tags:".ToUpper());
foreach(Product product in products)
{
  Console.WriteLine(product.PriceTag());
}