using System;
namespace Nivel5
{
    class Exercicio55
    {
        static void Main11(string[] args)
        {
            int counter = 0;
            string userPhrase;
            string newUserPhrase;
            int contadorLetras = 0;
            Console.WriteLine("Digite uma frase de até 50 caracteres: ");
            userPhrase = Console.ReadLine();
            foreach (var letra in userPhrase)
            {
                contadorLetras = userPhrase.IndexOf(' ');

                if (letra.Equals(' '))
                {
                    counter++;
                }
            }
            Console.WriteLine($"Quantidade de espaços em branco encontrado na frase => {counter}");
            newUserPhrase = String.Concat(userPhrase.Where(c => !Char.IsWhiteSpace(c)));
            Console.WriteLine($"Frase sem espaços em branco:\n{newUserPhrase}");
        }
    }
}