using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Pessoa p1 = new Pessoa(nome, idade);
           
            Pessoa p2 = new Pessoa();
            Console.WriteLine("Qual seu nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            Pessoa p3 = new Pessoa();
            Console.WriteLine("Qual seu nome: ");
            p3.Nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade: ");
            p3.Idade = Convert.ToInt32(Console.ReadLine());
            
            if((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
            {
                Console.WriteLine("A maior idade é da Pessoa 3" );
                p3.ExibirIdade();
            }
            else
            {
                if ((p2.Idade > p3.Idade) && (p2.Idade > p1.Idade))
                {
                    Console.WriteLine("A maior idade é da Pessoa 2 ");
                    p2.ExibirIdade();
                }
                else
                {
                    Console.WriteLine("A maior idade é da pessoa 1 ");
                    p1.ExibirIdade();
                }

            }

            Console.ReadKey();

        }
    }
}
