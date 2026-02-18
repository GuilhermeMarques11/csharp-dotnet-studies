using System.Globalization;

namespace BankApp
{
  class BankAccount
{
// Properties
  public int Numero {get; private set;}
  public string Titular {get; set;}
  public double Saldo {get; private set;}
 

// Constructors
  public BankAccount(int numero, string titular)
  {
    Numero = numero;
    Titular = titular;
  }

  public BankAccount(int numero, string titular, double deposito) : this(numero, titular)
  {
    Deposito(deposito);
  }

//  Methods
  public void Deposito(double quantia)
  {
    Saldo += quantia;
  }

  public void Saque(double quantia)
  {
    Saldo -= quantia + 5.0;
  }


  // Object
  public override string ToString()
  {
    return $"Conta {Numero}, Titular: {Titular}, Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
  }
}
}