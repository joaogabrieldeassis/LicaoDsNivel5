using System;

namespace Nivel5
{
    class Exercicio51
    {
        static void Main7(string[] args)
        {
            uint NumberOfStudents;
            Console.WriteLine("Digite a quantidade de alunos da sala: ");
            NumberOfStudents = Convert.ToUInt32(Console.ReadLine());

            double[] grades = new double[NumberOfStudents];
            double somaNota = 0;
            double media;
            int contNotaBaixa = 0;
            int contNotaAlta = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Digite a nota do " + (i + 1) + "º aluno:");
                grades[i] = Convert.ToDouble(Console.ReadLine());
            }

            foreach (var x in grades)
            {
                somaNota += x;

                if (x < 5.0)
                {
                    contNotaBaixa++;
                }
                else if (x > 7.0)
                {
                    contNotaAlta++;
                }

                if (contNotaBaixa == NumberOfStudents)
                {
                    Console.WriteLine("\nNão há nenhum aluno com nota acima de 5.");
                }
            }
            media = somaNota / NumberOfStudents;
            media = Math.Round(media, 2);

            Console.WriteLine($"\nA média aritimética da sala é {media}\nQuantidade de alunos com a nota acima de 7.0: {contNotaAlta}");
        }
    }
}