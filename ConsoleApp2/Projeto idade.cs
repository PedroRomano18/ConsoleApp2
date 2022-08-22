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
            Console.WriteLine("- Informe seu nome:");

            var nome = Console.ReadLine();

            Console.WriteLine("- Infome sua idade:");

            var idade = Console.ReadLine();

            int idade2 = Convert.ToInt32(idade);
            
         
            if (idade2 < 18)
            {
                Console.WriteLine("");
                Console.WriteLine("- " + idade2 + " anos não bate com os parametros legais! :[");
                Console.WriteLine("");
                Console.WriteLine("- " + nome + " chame um responsavel legal para entrar no sistema.");
                
            }

            if (idade2 >= 18)
            {
                Console.WriteLine("");
                Console.WriteLine("- " + idade2 + " anos é aceito mos parametros legais");
                Console.WriteLine("");
                Console.WriteLine("- " + nome + " seja muito bem vindo ao sistema");
               
            }

    
            Console.ReadLine();

            Console.WriteLine("- Obrigado professor Samuel! =]");













            Console.ReadKey();

        











        }
    }
}
