class Account(int number, string holder, double balance, double withDrawLimit)
{
  public int Number { get; set; } = number;
  public string? Holder { get; set; } = holder;
  public double Balance { get; private set; } = balance;
  public double WithdrawLimit { get; private set; } = withDrawLimit;

  public void Deposit(double amount)
  {
    Balance += amount;
  }

  public void Withdraw(double amount)
  {
    ValidateWithdraw(amount);
    Balance -= amount;
  }

  private void ValidateWithdraw(double amount)
  {
    if (amount > Balance)
    {
      throw new DomainExecption("Not enough balance");
    }
    if (amount > WithdrawLimit)
    {
      throw new DomainExecption("The amount exceeds withdraw limit");
    }
  }
}