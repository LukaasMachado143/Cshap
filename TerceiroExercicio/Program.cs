namespace TerceiroExercicio
{
  class Program
  {
    static void Main(string[] args)
    { 
      // Criação de variáveis
      int counter, numberStudent;
      int speedLimit, currentSpeed;
      int openHour, closeHour;
      int numberFlavors;
      int secondsTakeOff;


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

      // Console.WriteLine("**************************************************************************");
      // Console.WriteLine("Exercicio 2: Usar estruturas de repetição para demonstrar o limite de um carro de fórmula 1, esse limite é determinado pelo usuário");
      // Console.ReadLine();
      // Console.WriteLine("->Informe o limite de velocidade do carro:");
      // speedLimit = int.Parse(Console.ReadLine());

      // do
      // {
      //   Console.WriteLine("Velocidade Atual: {0} KM/H",currentSpeed);
      //   currentSpeed ++;
      // }while(currentSpeed <= speedLimit);

      // Console.WriteLine("Velocidade máxima atingida !");

      // Console.WriteLine("**************************************************************************");

      // Console.WriteLine("**************************************************************************");
      // Console.WriteLine("Exercicio 3: Definir horário de funcionamento de uma pizzaria, após demonstar para o usuário o horário que a mesma está fechada ou aberta ");
      // Console.ReadLine();
      // Console.WriteLine("->Informe o horário de ABERTURA da pizzaria:");
      // openHour = int.Parse(Console.ReadLine());
      // Console.WriteLine("->Informe o horário de FECHAMENTO da pizzaria:");
      // closeHour= int.Parse(Console.ReadLine());

      
      // while(counter <= 23){
      //   if ((counter >= openHour) && (counter <= closeHour))
      //   {
      //     Console.WriteLine("A pizzaria está aberta. Horário atual {0}:00H .",counter);
      //   }
      //   else
      //   {
      //     Console.WriteLine("A pizzaria está fechada. O horário de funcionamento é das {0}:00H até as {1}:00H.", openHour, closeHour);
      //   }
      //   counter ++;
      // }
      // Console.WriteLine("**************************************************************************");

      // Console.WriteLine("**************************************************************************");
      // Console.WriteLine("Exercicio 4: criar um cardápio com X sabores de pizza, após demonstar ao usuário os sabores existentes. ");
      // Console.ReadLine();

      // Console.WriteLine("->Informe a quantidade de sabores a ser cadastrado:");
      // numberFlavors = int.Parse(Console.ReadLine());
      // string[] flavors = new string[numberFlavors];

      // while(counter < numberFlavors)
      // {
      //   Console.WriteLine("{0} -> Sabor: ",(counter + 1));
      //   flavors[counter] = Console.ReadLine();
      //   counter ++;
      // }

      // counter = 0;
      // Console.WriteLine("Olá, seja bem vindo a pizzaria C# e CIA !");
      // Console.WriteLine("Em nosso cardápio temos os seguintes sabores:");
      // while(counter < numberFlavors){
      //   Console.WriteLine("{0} -> Sabor {1}.",(counter + 1), flavors[counter]);
      //   counter ++;
      // }
      // Console.WriteLine("**************************************************************************");

      Console.WriteLine("**************************************************************************");
      Console.WriteLine("Exercicio 5: contagem regressiva para decolagem de um foguete.");
      Console.ReadLine();

      Console.WriteLine("->Informe o tempo, em segundos, para a decolagem do Foguete C#2022:");
      counter = int.Parse(Console.ReadLine());
      

      while(counter >= 0)
      {
        Console.WriteLine("Faltam {0} segundos para a decolagem! ",counter);
        
        counter --;
      }
      Console.WriteLine("Decolagem realizada com sucesso!");   
    
      Console.WriteLine("**************************************************************************");
    }
  }

}