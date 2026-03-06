using System.Globalization;
using System.Text;

class Client(string name, string email, DateTime birthday, Order order)
{
  public string Name{get; set;} = name;
  public string Email { get; set; } = email;
  public DateTime Birthday { get; set; } = birthday;
  public Order Order{get; set;} = order;

  public override string ToString()
  {
    StringBuilder sb = new();
    sb.AppendLine("Order Summary:".ToUpper());
    sb.AppendLine($"Order moment: {Order.Moment.ToString("dd/MM/yyyy - HH:mm:ss")}");
    sb.AppendLine($"Order status: {Order.Status.ToString()}");
    sb.AppendLine($"Client: {Name} ({Birthday.ToString("dd/MM/yyyy")}) - {Email}");
    sb.AppendLine("Order items:");
    foreach ( OrderItem item in Order.OrderItems)
    {
      sb.AppendLine($"{item.Product.Name}, ${item.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {item.Quantity}, SubTotal: ${item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
    }
    sb.AppendLine($"Total price: ${Order.Total().ToString("F2", CultureInfo.InvariantCulture)}");
    return sb.ToString();
  }
}