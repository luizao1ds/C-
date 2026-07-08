using System;

namespace projeto_4_lacos_de_repeticao
{
    public class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite o comando desejado: for, while, do while ou Calculadora.");
          string comando = Console.ReadLine();

            if (comando == "for")
            {
                PrimeiroFor();

                  Thread.Sleep(5000);

            Console.Clear();
            }
            else if (comando == "while")
            {
                PrimeiroWhile();
                  Thread.Sleep(5000);

            Console.Clear();
            }
            else if (comando == "do while")
            {
                PrimeiroDoWhile();
                Thread.Sleep(5000);
                Console.Clear();
            }
            else if (comando == "Calculadora")
            {
                calculadora();
            }     
            else
            {
                Console.WriteLine("Comando inválido");
                  Thread.Sleep(5000);

            Console.Clear();
            }
             
        }

        static void PrimeiroFor()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Número: {i}");
            }
        }

        static void PrimeiroWhile()
        {
            int j = 1;

            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }
        }

        static void PrimeiroDoWhile()
        {
            int j = 1;

            do
            {
                Console.WriteLine("oi");
                j++;
            }
            while (j < 5);
        }

         static void calculadora()
         {
               Console.WriteLine("Digite o primeiro número: ");
               int num1 = Convert.ToInt32(Console.ReadLine());
   
               Console.WriteLine("Digite o segundo número: ");
               int num2 = Convert.ToInt32(Console.ReadLine());
   
               Console.WriteLine("Escolha a operação desejada: +, -, *, /, %");
               string operacao = Console.ReadLine();
   
               switch (operacao)
               {
                  case "+":
                     Console.WriteLine($"Resultado: {num1 + num2}");
                     break;
                  case "-":
                     Console.WriteLine($"Resultado: {num1 - num2}");
                     break;
                  case "*":
                     Console.WriteLine($"Resultado: {num1 * num2}");
                     break;
                  case "/":
                     if (num2 != 0)
                     {
                           Console.WriteLine($"Resultado: {num1 / num2}");
                     }
                     else
                     {
                           Console.WriteLine("Erro: Divisão por zero não é permitida.");
                     }
                     break;
                  case "%":
                     if (num2 != 0)
                     {
                           Console.WriteLine($"Resultado: {num1 % num2}");
                     }
                     else
                     {
                           Console.WriteLine("Erro: Divisão por zero não é permitida.");
                     }
                      break;
                  default:
                     Console.WriteLine("Operação inválida.");
                     break;
               }
    }
  }


}

