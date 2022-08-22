using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("- Digite a nota das 3 atividades:\n");

            decimal nota1, nota2, nota3;

            nota1 = Convert.ToDecimal(Console.ReadLine());

            nota2 = Convert.ToDecimal(Console.ReadLine());

            nota3 = Convert.ToDecimal(Console.ReadLine());

            decimal soma, media;

            soma = (nota1 + nota2 + nota3);
            media = soma / 3;

            Math.Round(media, 2);

            if (media >= 6)
            {
                Console.WriteLine("\n- " + Math.Round(media, 2).ToString() + " APROVADO");
            }
            else
            {
                Console.WriteLine("\n- " + Math.Round(media, 2).ToString() + " REPROVADO faça a prova de recuperação!");

                decimal nota4;

                nota4 = Convert.ToDecimal(Console.ReadLine());

                soma = (nota1 + nota2 + nota3 + nota4);

                media = soma / 4;

                Math.Round(media, 2);

                if (media >= 6)
                {
                    Console.WriteLine("\n- " + Math.Round(media, 2).ToString() + " Parabéns APROVADO!");
                }
                else
                {
                    Console.WriteLine("\n- " + Math.Round(media, 2).ToString() + " não tem jeito REPROVADO O BURRÃO!");
                }
                Math.Round(media, 2);
            }








            Console.ReadKey();






























        }
    }
}
