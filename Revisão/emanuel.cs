using System;
using System.Collections.Generic;

namespace Revisão
{
    internal class emanuel
    {
        public string Nome { get; set; }
        public List<string> Habilidades { get; set; }
        public int Idade { get; set; }
        public emanuel(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Habilidades = new List<string> { "Jogar Bola", "Trabalhar", "Estudar" };
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine("Habilidades: " + string.Join(", ", Habilidades));
        }
    }
}
