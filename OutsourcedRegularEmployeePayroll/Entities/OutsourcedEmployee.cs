class OutsourcedEmployee(string name, int hours, double valuePerHour, double addditionalCharge) : Employee(name, hours, valuePerHour)
{
  public double AdditionalCharge { get; set; } = addditionalCharge;

  sealed public override double Payment()
  {
    return base.Payment() + AdditionalCharge * 1.1;
  }
}