/*
  -->Criar um vetor A com 8 elementos inteiros.
  -->Construir um vetor B de mesmo tipo e tamanho e com os elementos do vetor A
     multiplicados por 2, ou seja, B[i] = A[i] * 2
*/
class Program
{
  static void Main(string[] args)
  {
    int[] a = new int[8];
    int[] b = new int[a.Length];

    for (int i = 0; i < a.Length; i++)
    {
      Console.Write($"Insira o valor na posicao {i}:");
      a[i] = int.Parse(Console.ReadLine());

      b[i] = a[i] * 2;
    }

    Console.WriteLine("Vetor a: " + string.Join(", ", a));
    Console.WriteLine("Vetor b: " + string.Join(", ", b));

  }
}
