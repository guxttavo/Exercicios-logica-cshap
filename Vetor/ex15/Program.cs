/*
-->Criar um vetor A com 10 elementos inteiros.
-->Escrever um programa que calcule e escreva:
   -A quantidade de elementos armazenados no vetor que são iguais a 15.
   -A soma dos elementos armazenados neste vator que são inferiores a 15.
   -A média dos elementos armazendos no vetor que são superiores a 15.
 */

class Program
{
  static void Main(string[] args)
  {
    Random rdn = new Random();
    int[] a = new int[10];

    for (int i = 0; i < a.Length; i++)
    {
      a[i] = rdn.Next(50);
    }

    int qtdQuinze = 0;
    for (int i = 0; i < a.Length; i++)
    {
      if (a[i] == 15)
      {
        qtdQuinze++;
      }
    }

    int soma = 0;
    for (int i = 0; i < a.Length; i++)
    {
      if (a[i] < 15)
      {
        soma += a[i];
      }
    }

    int somaMaioresQuinze = 0;
    for (int i = 0; i < a.Length; i++)
    {
      if (a[i] < 15)
      {

      }
    }

    Console.WriteLine("Vetor A: " + string.Join(",", a));
    Console.WriteLine("Quantidade de quinzes : " + qtdQuinze);
    Console.WriteLine("Soma : " + soma);

  }
}