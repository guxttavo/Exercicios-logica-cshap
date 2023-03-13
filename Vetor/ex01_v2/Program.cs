class Program
{
  static void Main(string[] args)
  {
    int n;
    int[] a;

    Console.Write("Escreva a quantidade: ");
    n = int.Parse(Console.ReadLine());
    a = new int[n];

    Console.Write("Escreva os numeros: ");
    string[] s = Console.ReadLine().Split('o');

    for (int i = 0; i < a.Length; i++)
    {
      a[i] = int.Parse(s[i]);
    }

    //OBS: O valor do vetor se mantém como int
    foreach (int x in a)
    {
      Console.Write(x + " ");
    }
  }
}
