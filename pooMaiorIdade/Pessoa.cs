using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMaiorIdade
{
    class Pessoa
    {
        public Pessoa()
        {
            this.Nome = "";
            this.Idade = 0;

        }

        public Pessoa(String nomePessoa, int idadePessoa)
        {
            this.Nome = nomePessoa;
            this.Idade = idadePessoa;
        }

        private String nome;

        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        private int idade;

        public int Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }

        public void ExibirIdade()
        {
            Console.WriteLine("Seu nome é: "+ this.Nome);
            Console.WriteLine("Sua idade é: "+ this.Idade);
            
        }


    }
}
