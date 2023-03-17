class Program
{
  static void Main(string[] args)
  {
    List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

    // Usando o método de extensão Sum para somar todos os números da lista
    int soma = numeros.Sum();
    Console.WriteLine("A soma dos números é: " + soma);

    // Usando o método de extensão Where para filtrar os números pares
    IEnumerable<int> pares = numeros.Where(numero => numero % 2 == 0);
    Console.WriteLine("Os números pares são: " + string.Join(", ", pares));
  }
}