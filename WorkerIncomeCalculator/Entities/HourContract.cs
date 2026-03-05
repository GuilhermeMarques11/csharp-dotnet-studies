class HourContract(DateTime date, double valuePerHour, int hours)
{
  public DateTime Date { get; set; } = date;
  public double ValuePerHour { get; set; } = valuePerHour;
  public int Hours { get; set; } = hours;

  public double TotalValue()
  {
    return Hours * ValuePerHour;
  }
}