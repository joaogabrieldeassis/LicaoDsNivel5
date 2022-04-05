using System;
namespace Nivel5
{
    class Exercicio45
    {
        static void Main1(string[] args)
        {
            int toReceive= 0;
            int[] numbers = new int[5]{1,2,3,4,5,};
            for (int i = 0; i > numbers.Length; i++)
            {
                toReceive=numbers[i];
            }
            Console.WriteLine(toReceive);
        }
    }
}