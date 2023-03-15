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
      a[i] = rdn.Next(30);
    }

    int igualQuinze = 0;
    int somaMenorQuinze = 0;
    int somaMaiorQuinze = 0;
    int qtnMaiorQuinze = 0;

    for (int i = 0; i < a.Length; i++)
    {
      if (a[i] == 15)
      {
        igualQuinze++;
      }
      else if (a[i] < 15)
      {
        somaMenorQuinze += a[i];
      }
      else if (a[i] > 15)
      {
        qtnMaiorQuinze++;
        somaMaiorQuinze += qtnMaiorQuinze;
      }
    }

    System.Console.WriteLine("Vetor a: " + string.Join(",", a));
    System.Console.WriteLine("Igual quinze: " + igualQuinze);
    System.Console.WriteLine("Soma menor que quinze: " + somaMenorQuinze);
    System.Console.WriteLine("Soma maior que quinze: " + somaMaiorQuinze);
    System.Console.WriteLine("Quantidade maior que quinze: " + qtnMaiorQuinze);
  }
}