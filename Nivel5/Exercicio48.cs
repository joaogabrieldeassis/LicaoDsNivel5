using System;
namespace Nivel5
{
    class Exercicio48
    {
        static void Main4(string[] args)
        {
            uint[] age = new uint[20];
            string[] name = new string[20];
            List<string> candidatasAptas = new List<string>();

            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine("Digite o nome da candita:");
                name[i] = Console.ReadLine();
                Console.WriteLine($"Digite a idade da candita {name[i]}:");
                age[i] = Convert.ToUInt32(Console.ReadLine());
                if (age[i] >= 18 && age[i] <= 20)
                {
                    candidatasAptas.Add(name[i]);
                }
            }

            foreach (var x in candidatasAptas)
            {
                Console.WriteLine($"Candidata Aptas: {x}");
            }

        }
    }
}