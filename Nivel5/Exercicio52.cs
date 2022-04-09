using System;

namespace Nivel5
{
    class Exercicio52
    {
        static void Main8(string[] args)
        {
            int vectorSize = 100;
            int[] numeros = new int[vectorSize];
            int numberOne;
            int counter = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Digite -1 para encerrar o programa.\nDigite um número inteiro e positivo para a " + (i + 1) + "º posição do vetor");
                numberOne = Convert.ToInt32(Console.ReadLine());

                if (numberOne == -1)
                {
                    i = 100;
                    vectorSize = i;
                }
                else
                {
                    numeros[i] = numberOne;
                }
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 1 && numeros[i + 1] == 3 && numeros[i + 2] == 4)
                {
                    counter++;
                }
            }

            Console.WriteLine($"A sequência 1, 3, 4 aconteceu {counter} vezes");


        }
    }
}