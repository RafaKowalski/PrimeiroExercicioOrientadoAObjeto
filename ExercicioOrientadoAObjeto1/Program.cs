using System;

namespace Curso
{
    class PrincipalProgram
    {
        static void Main(string[]args)
        {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();


            Console.WriteLine("digite os dados da primeira pessoa: ");
            a.Nome = string.Format(Console.ReadLine());
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("digite os dados da segunda pessoa: ");
            b.Nome = string.Format(Console.ReadLine());
            b.Idade = int.Parse(Console.ReadLine());

            if (a.Idade > b.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + a.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + b.Nome);
            }

        }
    }
}