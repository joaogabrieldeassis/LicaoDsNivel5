using System;

namespace Nivel5
{
    class Exercicio53
    {
        static void Main9(string[] args)
        {
            int volta = 0;
            uint vectorSize;
            double tempo = 0.0;
            double mediaVoltas;
            double sumOfTurns = 0.0;
            Console.WriteLine("Digite a quantidade de voltas da corrida: ");
            vectorSize = Convert.ToUInt32(Console.ReadLine());
            double[] tempoVoltas = new double[vectorSize];
            for (int i = 0; i < vectorSize; i++)
            {
                Console.WriteLine("Digite o tempo da " + (i + 1) + "º volta");
                tempoVoltas[i] = Convert.ToDouble(Console.ReadLine());
                sumOfTurns += tempoVoltas[i];
                if (i == 0)
                {
                    tempo = tempoVoltas[i];
                }
                if (tempoVoltas[i] < tempo)
                {
                    tempo = tempoVoltas[i];
                    volta = i;
                }
            }
            mediaVoltas = sumOfTurns / vectorSize;
            mediaVoltas = Math.Round(mediaVoltas, 2);
            Console.WriteLine($"O melhor de tempo foi {tempo} na volta " + (volta + 1) + $".\nO tempo médio das voltas é: {mediaVoltas}");
        }
    }
}