/*
-->Criar dois vetores A e B cada um com 10 elementos inteiros.
-->Construir um vetor C, onde cada elemento de C é a soma dos
   respectivos elementos em A e B, ou seja,
   C[i]= A[i] + B[i]
*/
using System;
class Program
{
  static void Main(string[] args)
  {
    int[] a = new int[10];
    int[] b = new int[a.Length];
    int[] c = new int[a.Length];

    for (int i = 0; i < a.Length; i++)
    {
      Console.Write($"Insira o valor da posição {i}: ");
      a[i] = int.Parse(System.Console.ReadLine());

      c[i] = a[i] + b[i];
    }

    Console.WriteLine("Vetor a: " + string.Join(",", a));
    Console.WriteLine("Vetor b: " + string.Join(",", b));
    Console.WriteLine("Vetor c: " + string.Join(",", c));

  }
}