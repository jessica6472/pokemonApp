using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonApp
{  
    public class Pokedex
    {
        public Pokedex() 
        {
            this.InicializarLista();
        }
        private List<Pokemon>  pokemons;

        public List<Pokemon> Pokemons
		{
			get { return pokemons; }
		}

        private void InicializarLista()
        {
            //Instancia a lista
            pokemons = new List<Pokemon>();
            Pokemon p = new Pokemon("Bulbasauro", "pokemon tipo planta");
            this.pokemons.Add(p);
            p = new Pokemon("Charmander", "pokemon tipo fogo");
            this.pokemons.Add(p);
            p = new Pokemon("Squirtle", "pokemon tipo agua");       
            this.pokemons.Add(p);
            p = new Pokemon("Pikachu", "pokemon tipo eletrico");
            this.pokemons.Add(p);
            p = new Pokemon("Eevee", "pokemon tipo normal");
            this.pokemons.Add(p);
            p = new Pokemon("Jigglypuff", "pokemon tipo fada");
            this.pokemons.Add(p);
            p = new Pokemon("Meowth", "pokemon tipo normal");
            this.pokemons.Add(p);
            p = new Pokemon("Snorlax", "pokemon tipo normal");
            this.pokemons.Add(p);
            p = new Pokemon("Mewtwo", "pokemon tipo psiquico");
            this.pokemons.Add(p);
            p = new Pokemon("Magikarp", "pokemon tipo agua");
            this.pokemons.Add(p);
        }
        public void ListarPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                this.Pokemons[i].ExibirDados();
                //Pokemon p = this.Pokemons[i];
                //p.ExibirDados();
            }
        }

    }
}
