using System;

namespace Nivel5
{
    class Exercicio54
    {

        static void Main10(string[] args)
        {
            bool existe;
            int[] vectorA = new int[5];
            int[] vectorB = new int[8];
            int[] vectorC = new int[8];
            int counter = 0;
            for (int i = 0; i < vectorA.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro para a " + (i + 1) + "º posição do vetor A");
                vectorA[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");

            for (int i = 0; i < vectorB.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro para a " + (i + 1) + "º posição do vetor B");
                vectorB[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var a in vectorA)
            {
                foreach (var b in vectorB)
                {

                    existe = false;
                    foreach (var c in vectorC)
                    {
                        if (c == b)
                        {
                            existe = true;
                        }

                    }

                    if (b == a && !existe)
                    {
                        vectorC[counter] = b;
                        counter++;
                    }
                }
            }
            foreach (var c in vectorC)
            {
                if (c > 0)
                {
                    Console.WriteLine($"Os valores indênticos entre os vetores A e B são: {c}");
                }
            }
        }
    }

}