using System.Globalization;

class UsedProduct(string name, double price, DateTime manufactureDate) : Product(name, price)
{
  public DateTime ManufactureDate { get; set; } = manufactureDate;

  public override string PriceTag()
  {
    return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate:dd/MM/yyyy})";
  }
}