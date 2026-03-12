using System.Globalization;

class Product(string name, double price)
{
  public string Name { get; set; } = name;
  public double Price { get; set; } = price;

  virtual public string PriceTag()
  {
    return $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
  }
}