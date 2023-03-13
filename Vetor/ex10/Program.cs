/*
-->Crie um vetor A com 10 elementos inteiros.
-->Implementar um programa que defina e escreva a quantidade de elementos armazenados
   neste vetor que são pares e ímpares.
*/
class Program
{
  static void Main(string[] args)
  {
    Random rnd = new Random();

    int[] a = new int[10];

    for (int i = 0; i < a.Length; i++)
    {
      a[i] = rnd.Next(30);
    }

    Console.WriteLine("Vetor A:" + string.Join(",", a));

    int qtdPar = 0;
    int qtdImpar = 0;
    for (int i = 0; i < a.Length; i++)
    {
      if (a[i] % 2 == 0)
      {
        qtdPar++;
      }
      else
      {
        qtdImpar++;
      }
    }

    Console.WriteLine("Quantidade de números pares: " + qtdPar);
    Console.Write("Quantidade de números pares: " + qtdImpar);

  }
}