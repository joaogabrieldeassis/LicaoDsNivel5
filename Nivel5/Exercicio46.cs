using System;
namespace Nivel5
{
    class Exercicio46
    {
        //Teste
        static void Main2(string[] args)
        {
            int vectorSize
;
            int resultado = 0;

            Console.WriteLine("Digite a quantidade de números que você deseja adicionar no vetor: ");
            vectorSize = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[vectorSize];
            int[] y = new int[vectorSize];

            for (int i = 0; i < vectorSize; i++)
            {
                Console.WriteLine("Digite um número para o primeiro vetor: ");
                x[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite um número para o segundo vetor: ");
                y[i] = Convert.ToInt32(Console.ReadLine());

                resultado += x[i] * y[i];
            }

            Console.WriteLine($"\nProduto escalar = {resultado}");
        }
    }
}