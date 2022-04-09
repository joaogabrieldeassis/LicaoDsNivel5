using System;


namespace Nivel5
{
    class Exercicio56
    {
        static void Main12(string[] args)
        {
            int counterPares = 0;
            uint[] numbers = new uint[50];
            int contadorMultiplo5 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Digite um número inteiro e positivo para a " + (i + 1) + "º posição do vetor");
                numbers[i] = Convert.ToUInt32(Console.ReadLine());

                if (numbers[i] % 2 == 0)
                {
                    counterPares++;
                }
                if (numbers[i] % 5 == 0)
                {
                    contadorMultiplo5++;
                }
            }

            Console.WriteLine($"Quantidade de números pares: {counterPares}\nQuantidade de números múltiplos de 5: {contadorMultiplo5}");
        }
    }
}