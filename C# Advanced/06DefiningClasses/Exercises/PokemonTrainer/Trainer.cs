using System.Collections.Generic;

namespace PokemonTrainer
{
    class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.NumBadges = 0;
            this.Pokemons = new List<Pokemon>();
        }
        public string Name { get; set; }
        public int NumBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.NumBadges} {this.Pokemons.Count}";
        }
    }
}
