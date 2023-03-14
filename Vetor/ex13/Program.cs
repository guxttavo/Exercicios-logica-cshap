/*
-->Criar um vetor A com 10 elmentos inteiros.
-->Desenvolver um programa que defina o percentual de elementos pares e ímpares, respectivamente, armazenados neste vetor.
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

    double porcPar = (qtdPar * 100) / a.Length;
    double porcImpar = 100 - porcPar;

    Console.Write("Porcentagem Par:" + porcPar);
    Console.Write("Porcentagem Impar:" + porcImpar);
  }
}