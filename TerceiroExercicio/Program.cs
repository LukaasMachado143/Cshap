namespace TerceiroExercicio
{
  class Program
  {
    static void Main(string[] args)
    { 
      // Criação de variáveis
      int counter, numberStudent;
      int speedLimit, currentSpeed;

      // Atribuição de valores as variáveis declaradas acima
      counter = 0;
      currentSpeed = 0;

      // Console.WriteLine("**************************************************************************");
      // Console.WriteLine("Exercicio 1: Foreach para dar boas vindas a X Alunos novos");
      // Console.ReadLine();
      // Console.WriteLine("Informe a quantiadade de alunos novos a serem cumprimentados: ");
      // numberStudent = int.Parse(Console.ReadLine());
      // string[] studentName = new string[numberStudent];
      
      // while(counter < numberStudent)
      // {
      //   Console.WriteLine("-> Informe o nome do aluno {0}:", (counter + 1));
      //   studentName[counter] = Console.ReadLine();
      //   counter++;
      // }

      // Console.WriteLine("Alunos cadastrados com sucesso");

      // for(counter=0; counter<numberStudent; counter++)
      // {
      //   Console.WriteLine("Olá {0} , seja bem vindo !", studentName[counter]);
      //   Console.ReadLine();
      // }

      Console.WriteLine("**************************************************************************");
      Console.WriteLine("Exercicio 2: Usar estruturas de repetição para demonstrar o limite de um carro de fórmula 1, esse limite é determinado pelo usuário");
      Console.ReadLine();
      Console.WriteLine("->Informe o limite de velocidade do carro:");
      speedLimit = int.Parse(Console.ReadLine());

      do
      {
        Console.WriteLine("Velocidade Atual: {0} KM/H",currentSpeed);
        currentSpeed ++;
      }while(currentSpeed <= speedLimit);

      Console.WriteLine("Velocidade máxima atingida !");

      Console.WriteLine("**************************************************************************");
    }
  }

}