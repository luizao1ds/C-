using System;

namespace projeto_5_triangulo_de_estrelas
{
    public class Program
    {
        static void Main(string[] args)
        {
       

       

               

                Console.WriteLine("Digite o comando desejado: estrelas.");
            string comando = Console.ReadLine();

            if (comando == "estrelas")
            {
                Estrelas();
            }
            else
            {
                Console.WriteLine("Comando não encontrado");
               

                executando = false;
                }

        }
 }

        static void Estrelas()
        {
            Console.Write("Quantas estrelas você quer na base? ");
            int baseTriangulo = Convert.ToInt32(Console.ReadLine());

            int j = 1;

            do
            {
                Console.WriteLine(new string('*', j));
                j++;
            }
            while (j <= baseTriangulo);
        }
    }
}