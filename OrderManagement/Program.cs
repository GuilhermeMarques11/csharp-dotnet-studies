using System.Globalization;

Console.WriteLine("Entender client data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birthdate (DD/MM/YYYY): ");
DateTime birthday = DateTime.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

DateTime moment = DateTime.Now;
Order order = new(moment, status);
Client client = new(name, email, birthday, order);

Console.Write("How many items to this order? ");
int numberOfitems = int.Parse(Console.ReadLine());

Console.WriteLine();

for(int i = 1; i <= numberOfitems; i++)
{
  Console.WriteLine($"Enter #{i} item data:");
  Console.Write("Product name: ");
  string productName = Console.ReadLine();
  Console.Write("Product price: ");
  double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  Console.Write("Quantity: ");
  int quantity = int.Parse(Console.ReadLine());
  Product product = new(productName, productPrice);
  OrderItem orderItem = new(quantity, product);
  order.AddItem(orderItem);
  Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine(client);