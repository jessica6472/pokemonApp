using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon p = new Pokemon();
            p.Nome = "Bulbasauro";
            p.Descricao = "Bulbasauro ee um pokemon tipo planta";
            p.ExibirDados();
            Console.ReadKey();
        }
    }
}
