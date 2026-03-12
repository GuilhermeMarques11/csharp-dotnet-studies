using System.Globalization;

class ImportedProduct(string name, double price, double customsFee) : Product(name, price)
{
  public double CustomsFee { get; set; } = customsFee;

   public double TotalPrice()
  {
    return Price + CustomsFee;
  }

  public override string PriceTag()
  {
    return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
  }
}