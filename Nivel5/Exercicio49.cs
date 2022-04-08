using System;

namespace Nivel5
{
    class Exercicio49
    {
        static void Main5(string[] args)
        {
            uint vectorSize;
            Console.WriteLine("Digite o tamanho do vetor.\n\tTamanho MÁXIMO: 50");
            vectorSize = Convert.ToUInt32(Console.ReadLine());
            if (vectorSize >= 0 && vectorSize <= 50)
            {
                int[] v1 = new int[vectorSize];
                int[] v2 = new int[vectorSize];

                for (int i = 0; i < vectorSize; i++)
                {
                    Console.WriteLine($"Digite um número inteiro para a posição " + (i + 1) + " do vetor V1: ");
                    v1[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Digite um número inteiro para a posição " + (i + 1) + " do vetor V2: ");
                    v2[i] = Convert.ToInt32(Console.ReadLine());
                    if (v1[i] == v2[i])
                    {
                        Console.WriteLine($"\nO valor {v1[i]} da posição " + (i + 1) + $" do vetor V1 é indêntico ao valor {v2[i]} da posição " + (i + 1) + " do vetor V2\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("Tamanho do vetor inválido...");
            }


        }
    }
}