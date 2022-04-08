using System;
namespace Nivel5
{
    class Exercicio47
    {
        static void Main3(string[] args)
        {
            uint[] numbers = new uint[10];
            uint numberOne;
            int larger = 0;
            int menor = 0;
            int equal = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Digite um número inteiro positivo para a posição {i} do vetor: ");
                numbers[i] = Convert.ToUInt32(Console.ReadLine());
            }
            Console.WriteLine("\nDigite um número inteiro positivo: ");
            numberOne = Convert.ToUInt32(Console.ReadLine());

            foreach (var x in numbers)
            {
                if (x > numberOne)
                {
                    larger++;

                }
                else if (x < numberOne)
                {
                    menor++;
                }
                else
                {
                    equal++;
                }
            }
            Console.WriteLine($"{larger} números são maiores que o número {numberOne}");
            Console.WriteLine($"{menor} números são menores que o número {numberOne}");
            Console.WriteLine($"{equal} números são iguais ao número {numberOne}");
        }
    }
}