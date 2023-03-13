/*
-->Criar dois vetores A e B cada um com 10 elementos inteiros.
-->Construir um vetor C, onde cada elemento de C é a subtração dos respectivos
   elementos em A e B, ou seja,
   C[i] = A[i] - B[i]
 */
using System;
class Program
{
  static void Main(string[] args)
  {
    int[] a = new int[3];
    int[] b = new int[3];
    int[] c = new int[3];

    for (int i = 0; i < a.Length; i++)
    {
      Console.Write($"Insira o valor da posição {i} do vetor A: ");
      a[i] = int.Parse(Console.ReadLine());
      Console.Write($"Insira o valor da posição {i} do vetor B: ");
      b[i] = int.Parse(Console.ReadLine());

      c[i] = a[i] - b[i];
    }

    Console.WriteLine("Vetor A:" + string.Join(",", a));
    Console.WriteLine("Vetor B:" + string.Join(",", b));
    Console.WriteLine("Vetor C:" + string.Join(",", c));
  }
}