/*
-->Crie um vetor A com 10 elementos inteiros.
-->Implementar um programa que defina e escreva a soma de todos os elementos armazenados
   neste velor.
*/
class Program
{
  static void Main(string[] args)
  {
    int[] a = new int[2];

    for (int i = 0; i < a.Length; i++)
    {
      Console.Write($"Insira o valor da posição {i} do vetor A: ");
      a[i] = int.Parse(Console.ReadLine());
    }

    int soma = 0;
    for (int i = 0; i < a.Length; i++)
    {
      soma += a[i];
    }

    Console.WriteLine("Vetor a: " + soma);
  }
}