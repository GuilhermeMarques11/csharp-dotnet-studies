class OrderItem(int quantity, Product product)
{
  public int Quantity{get; set;} = quantity;
  public Product Product{get; set;} = product;

  public double SubTotal()
  {
    return Quantity * Product.Price;
  }
}