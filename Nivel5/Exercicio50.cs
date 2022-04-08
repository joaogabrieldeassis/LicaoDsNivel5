using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel5
{
    class Exercicio50
    {
        static void Main6(string[] args)
        {
            Random number = new Random();
            int numberDrawn = number.Next(0, 101);
            int chute;
            int contChute = 0;
            while (true)
            {
                Console.WriteLine("Chute um número de 0 a 100");
                chute = Convert.ToInt32(Console.ReadLine());
                if (chute == numberDrawn)
                {
                    Console.WriteLine($"\nVocê acertou o número sorteado.\n\tNúmero de tentativas = {contChute}\n\tNúmero sorteado: {numberDrawn}");
                    break;
                }
                else if (chute > numberDrawn)
                {
                    Console.WriteLine("\nVocê errou...\nO número chutado é maior que o número sorteado.\nTente novamente.\n");
                    contChute++;
                }
                else if (chute < numberDrawn)
                {
                    Console.WriteLine("\nVocê errou...\nO número chutado é menor que o número sorteado.\nTente novamente.\n");
                    contChute++;
                }
            }
        }
    }
}