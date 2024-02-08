using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09PokemonTrainer
{
    public class Trainer
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int badges;

		public int Badges
		{
			get { return badges; }
			set { badges = value; }
		}
		private List<Pokemon> pokemon;

		public List<Pokemon> Pokemon
		{
			get { return pokemon; }
			set { pokemon = value; }
		}

		public Trainer(string name, List<Pokemon> pokemon)
		{
			Name = name;
			Badges = 0;
			Pokemon = pokemon;
		}

	}
}
