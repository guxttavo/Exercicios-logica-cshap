class Program
{
  static void Main(string[] args)
  {
    int linha = 3;
    int coluna = 4;

    Random rdn = new Random();
    int[,] matriz = new int[linha, coluna];

    for (int i = 0; i < linha; i++)
    {
      for (int j = 0; j < coluna; j++)
      {
        matriz[i, j] = rdn.Next(1, 101);
      }
    }

    for (int i = 0; i < linha; i++)
    {
      for (int j = 0; j < coluna; j++)
      {
        Console.Write(matriz[i, j] + " ");
      }
      Console.WriteLine();
    }
  }
}