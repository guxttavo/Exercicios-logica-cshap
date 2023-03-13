/*
-->Criar um vetor a com 10 elementos inteiros.
-->Construir um vetor B de mesmo tipo e tamanho, sendo que cada elemento do vetor B deverá
  ser o respectivo do elemento de A multiplicado por sua posição(ou índice), ou seja,
  B[i] = A[i] * i
*/
class Program
{
  static void Main(string[] args)
  {
    int[] a = new int[10];
    int[] b = new int[a.Length];

    for (int i = 0; i < a.Length; i++)
    {
      Console.Write($"Insira o valor na posicao {i}:");
      a[i] = int.Parse(Console.ReadLine());
      b[i] = a[i] * i;

    }

  }
}