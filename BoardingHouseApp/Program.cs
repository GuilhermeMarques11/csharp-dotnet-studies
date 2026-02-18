namespace BoardingHouseApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Estudante[] vect = new Estudante[10];
      Console.Write("Quantos quartos serão alugados? ");
      int numeroQuartos = int.Parse(Console.ReadLine());

      for (int i = 0; i < numeroQuartos; i++)
      {
        Console.WriteLine();
        Console.WriteLine($"Alguel {i + 1}:");
        Console.Write("Nome: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Quarto: ");
        int quarto = int.Parse(Console.ReadLine());
        vect[quarto] = new Estudante(name, email);
      }

      Console.WriteLine();
      Console.WriteLine("Quartos ocupados:");
      for (int i = 0; i < 10; i++)
      {
        if (vect[i] != null)
        {
          Console.WriteLine($"{i}: {vect[i]}");
        }
      }
    }
  }
}