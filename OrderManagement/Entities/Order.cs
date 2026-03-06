class Order(DateTime moment, OrderStatus status)
{
  public DateTime Moment{get; set;} = moment;
  public OrderStatus Status{get; set;} = status;
  public List<OrderItem> OrderItems{get; set;} = [];

  public void AddItem(OrderItem item)
  {
    OrderItems.Add(item);
  }

  public void RemoveItem(OrderItem item)
  {
    OrderItems.Add(item);
  }

  public double Total()
  {
    double sum = 0;
     foreach (OrderItem item in OrderItems)
    {
      sum += item.SubTotal();
    }

    return sum;
  }
}