class Program
{
  static void Main(string[] args)
  {
    Random rdn = new Random();
    int[] a = new int[20];

    for (int i = 0; i < a.Length; i++)
    {
      a[i] = rdn.Next(20);

    }

    Console.Write("Valor dado:" + string.Join(",", a));
  }
}