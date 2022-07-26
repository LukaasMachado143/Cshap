using System;

namespace PrimeiroExercicio
{
  class Program
  {
    static void Main(string[] args)
    {
      
      double num1, num2, num3;

      String requestName, typeUrgency, description;



      Console.WriteLine("EXERCÍCIO 1: Encontre o maior e o menor número digitado.");
      Console.WriteLine("");
      Console.WriteLine("Escreva o primeiro número:");
      num1 = double.Parse(Console.ReadLine());
      Console.WriteLine("");
      Console.WriteLine("Escreva o segundo número:");
      num2 = double.Parse(Console.ReadLine());
      Console.WriteLine("");
      Console.WriteLine("Escreva o terceiro número:");
      num3 = double.Parse(Console.ReadLine());
      Console.WriteLine("");
      Console.WriteLine("Os números digitados foram: n1-> {0}, n2-> {1}, n3-> {2}", num1, num2, num3);

      Console.WriteLine("Para verificar o * MAIOR * número digite 1.");
      Console.WriteLine("Para verificar o * MENOR * número digite 2.");

      if (int.Parse(Console.ReadLine()) == 1)
      {
        Console.WriteLine("");
        if ((num1 > num2) & (num1 > num3)) 
        {
            Console.WriteLine("O primeiro número digitado é o maior, "+ num1 +".");
        } else if ((num2 > num1) & (num2 > num3)) 
        {
            Console.WriteLine("O segundo número digitado é o maior, "+ num2 +".");
        } else if ((num3 > num2) & (num3 > num1)) 
        {
            Console.WriteLine("O terceiro número digitado é o maior, "+ num3 +".");
        }
      } else if (int.Parse(Console.ReadLine()) == 2)
      {
        Console.WriteLine("");
        if ((num1 < num2) & (num1 < num3)) 
        {
            Console.WriteLine("O primeiro número digitado é o menor, "+ num1 +".");
        } else if ((num2 < num1) & (num2 < num3)) 
        {
            Console.WriteLine("O segundo número digitado é o menor, "+ num2 +".");
        } else if ((num3 < num2) & (num3 < num1)) 
        {
            Console.WriteLine("O terceiro número digitado é o menor, "+ num3 +".");
        }
      }else
      {
        Console.WriteLine("");
        Console.WriteLine("Opção inválida, favor reiniciar o programa ! ");
      }
      
      Console.WriteLine("******************************************************************************");
      Console.WriteLine("EXERCÍCIO 2: Controle de chamado com níveis de urgência");
      Console.WriteLine("");

      Console.WriteLine("Escreva o seu nome: ");
      requestName = Console.ReadLine();
      Console.WriteLine("");

      Console.WriteLine("Descreva seu problema:");
      description = Console.ReadLine();
      Console.WriteLine("");

      Console.WriteLine("Informe o nível de urgência o chamado: ");
      Console.WriteLine("-> 0 ATÉ 3 : Urgência BAIXA; ");
      Console.WriteLine("-> 4 ATÉ 6 : Urgência MÉDIA; ");
      Console.WriteLine("-> 7 ATÉ 9 : Urgência ALTA; ");
      Console.WriteLine("-> 9 A DIANTE: Urgência GRAVE; ");
      Console.WriteLine("");

      num1 = int.Parse(Console.ReadLine());

      typeUrgency = "";
      if(( num1 >= 0) & (num1 <= 3))
      {
        typeUrgency = "BAIXA";
      }else if((num1 >= 4) & (num1 <= 6))
      {
        typeUrgency = "MÉDIA";
      }else if((num1 >= 7) & (num1 <= 9))
      {
        typeUrgency = "ALTA";
      }else if(num1 > 9)
      {
        typeUrgency = "GRAVE";
      }
      
      Console.WriteLine("Caro Guilherme, sou o {0}, ''{1}', cujo nível de urgência é: {2}. ", requestName, description, typeUrgency);
 
    }
  }
}