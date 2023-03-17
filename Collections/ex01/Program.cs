class Program
{
  static void Main(string[] args)
  {
    Random rdn = new Random();

    //--------------------------------------------Array---------------------------------------------
    int[] array = new int[10];

    for (int i = 0; i < array.Length; i++)
    {
      array[i] = rdn.Next(20);
    }

    System.Console.WriteLine("Valor total do array: " + string.Join(",", array));

    //--------------------------------------------Lista---------------------------------------------
    List<int> lista = new List<int> { };

    for (int i = 0; i < 10; i++)
    {
      int numAleatorio = rdn.Next(1, 20);
      lista.Add(numAleatorio);
    }

    double media = lista.Average();

    System.Console.WriteLine("Valor total da lista: " + string.Join(",", lista));

    //--------------------------------------------Dicionary-----------------------------------------

    Dictionary<string, int> dicionary = new Dictionary<string, int>();

    for (int i = 0; i < 10; i++)
    {
      int numAleatorio = rdn.Next(1, 10);
    }

    dicionary.Add("Joao", 20);
    dicionary.Add("Maria", 30);
    dicionary.Add("Pedro", 50);

    int dicionaryJoao = dicionary["Joao"];

    System.Console.WriteLine(dicionary);
    System.Console.WriteLine("Valor total do dicionary: " + string.Join(",", dicionary));
  }
}