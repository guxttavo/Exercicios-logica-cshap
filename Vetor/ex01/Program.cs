/*
-->Criar um vetor A com 5 elementos inteiros.
-->Construir um vetor B de mesmo tipo e tamanho e com os mesmos
elementos do vetor A, ou seja, B[i] = A[i]
 */

class Program
{
  static void Main(string[] args)
  {
    int[] a = new int[5];

    for (int i = 0; i < a.Length; i++)
    {
      Console.Write($"Insira o {i + 1} valor:");
      a[i] = int.Parse(Console.ReadLine());
    }

    //OBS: Vetor está sendo convertido para string
    Console.WriteLine("Vetor a: " + string.Join(", ", a));

  }
}
