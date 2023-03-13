/*
-->Criar um vetor A com 15 elementos inteiros.
-->Construir um vetor B de mesmo tipo e tamanho, sendo que cada elemento do vetor B deverá
   ser o quadrado do respectivo elemento de A, ou seja, B[i]=A[i] * A[i]
*/
class Program
{
  static void Main(string[] args)
  {
    int[] a = new int[15];
    int[] b = new int[a.Length];

    for (int i = 0; i < a.Length; i++)
    {
      Console.Write($"Insira o valor na posicao {i}:");
      a[i] = int.Parse(Console.ReadLine());

      b[i] = a[i] * a[i];
    }

    Console.WriteLine("Vetor a: " + string.Join(",", a));
    Console.WriteLine("Vetor b: " + string.Join(",", b));

  }
}
