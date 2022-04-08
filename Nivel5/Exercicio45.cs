using System;
namespace Nivel5
{
    class Exercicio45
    {
        static void Main1(string[] args)
        {
            int numberOfElements;
            Console.WriteLine("Digite quantos numeros irá por no vetor: ");
            numberOfElements = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Digite o {0}º número: ", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var j in numbers)
            {
                Console.WriteLine("Lista original: {0}", j);
            }
            Array.Reverse(numbers);
            foreach (var k in numbers)
            {
                Console.WriteLine("Lista invertida: {0}", k);
            }
        }




    }
}