using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemonApp
{
    public class Pokemon
    {
		//Construtor
		public Pokemon()
		{ 
			this.nome = "";
			this.descricao = "";
        }
        //Propriedades(ee uma caracteristica do objeto)
        private String  nome;

		public String  Nome
		{
			get { return nome; }
			set {
				String texto = value.ToUpper();
				nome = texto; 
			}
		}
		private String descricao;

		public String Descricao
		{
			get { return this.descricao; }
			set { 
				this.descricao = value.ToUpper();
			}
		}
		//Metodo( ee uma acao que o objeto pode fazer)
		public void ExibirDados()
		{
			Console.WriteLine("Nome do Pokemon: " + this.nome);
			Console.WriteLine("Descricao do Pokemon: " + this.descricao);
        }

    }
}
