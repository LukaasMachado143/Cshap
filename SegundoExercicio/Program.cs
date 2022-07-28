namespace SegundoExercicio
{
  class Program
  {
    static void Main(string[] args)
    {
      string nameProduct;
      float finalPrice, radius, baseValue, height;

      // Console.WriteLine("*************************************************");
      // Console.WriteLine("Exercício 1: Retornar 25% de lucro em cima do preço inicial.");
      // Console.ReadLine();
      // Console.WriteLine("Informe o nome do PRODUTO -> ");
      // nameProduct = Console.ReadLine();
      // Console.WriteLine("Informe o valor do PRODUTO -> R$");
      // finalPrice = float.Parse(Console.ReadLine());
      // Console.WriteLine("O produto {0} deverá ser vendido a R${1}.", nameProduct,CalculatePrice(finalPrice));

      // Console.WriteLine("*************************************************");
      // Console.WriteLine("Exercício 2: Retornar a área do circulo em mm².");
      // Console.ReadLine();
      // Console.WriteLine("Informe o valor do raio em mm-> ");
      // radius = float.Parse(Console.ReadLine());
      // Console.WriteLine("A área do círculo é igual a {0} mm².",CalculateCircleArea(radius));

      Console.WriteLine("*************************************************");
      Console.WriteLine("Exercício 3: Retornar a área do tringulo em mm².");
      Console.ReadLine();
      Console.WriteLine("Informe a medida da base em mm-> ");
      baseValue = float.Parse(Console.ReadLine());
      Console.WriteLine("Informe a medida da altura em mm-> ");
      height = float.Parse(Console.ReadLine());
      Console.WriteLine("A área do triangulo é igual a {0} mm².",CalculateTriangleArea(baseValue,height));


    }

    static float CalculatePrice(float initialPrice)
    {
      return initialPrice + (initialPrice*0.25f);
    }

    static float CalculateCircleArea(float auxRadius)
    {
      return 3.14f * (auxRadius*auxRadius);
    }

    static float CalculateTriangleArea(float auxBaseValue, float auxHeight)
    {
      return (auxBaseValue*auxHeight)/2;
    }
  }
}

