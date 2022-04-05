using System;
namespace Nivel5
{
    class Exercicio46
    {
        static void Main(string[] args)
        {
            int toReceive= 0;
            int[] numbers = new int[5];
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Digite {0}º valor",i);
                Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(numbers);
        }
    }
}