/*
-->Criar um vetor A com 10 elementos inteiros.
-->Implementar um programa que defina e escreva a soma apenas dos elementos
   ímpares armazenados neste valor.
 */
class Program
{
  static void Main(string[] args)
  {
    Random rdn = new Random();
    int[] a = new int[10];

    for (int i = 0; i < a.Length; i++)
    {
      a[i] = rdn.Next(20);
    }

    int soma = 0;
    for (int i = 0; i < a.Length; i++)
    {
      if (a[i] % 2 != 0)
      {
        soma += a[i];
      }
    }

    Console.WriteLine("Vetor a: " + soma);
  }
}