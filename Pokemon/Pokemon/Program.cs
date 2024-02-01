using System.Windows.Input;

namespace Pokemon;
class Program
{
    static void Main(string[] args)
    {
        string? command = Console.ReadLine();

        List<Trainer> trainers = new List<Trainer>();


        while (command != "Tournament")
        {
            string[] tokens = command.Split(" ").ToArray();
            string trainerName = tokens[0];
            string pokemonName = tokens[1];
            string pokemonElement = tokens[2];
            int pokemonHealth = int.Parse(tokens[3]);

            Pokemon pokemon = new Pokemon(pokemonName,pokemonElement, pokemonHealth );

            Trainer trainer = trainers.FirstOrDefault(t => t.Name == trainerName);

            if (trainer == null)
            {
                trainer = new Trainer(trainerName);
                trainers.Add(trainer);
            }

            trainer.PokemonCollection.Add(pokemon);

            command = Console.ReadLine();
        }
        
        while (command != "End")
        {
            if (command !="Tournament")
            {
                ProcessTournamentCommand(trainers, command);
                
            }

            command = Console.ReadLine();
        }

        PrintTrainers(trainers);
    
    }

    static void PrintTrainers(List<Trainer> trainers)
    {
        foreach (Trainer trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.PokemonCollection.Count}");
        }
    }

    static void ProcessTournamentCommand(List<Trainer> trainers,string element)
    {
        foreach (Trainer trainer in trainers)
        {
            if (trainer.PokemonCollection.Any(p => p.Element == element))
            {
                trainer.NumberOfBadges++;
            }

            else
            {
                foreach(Pokemon pokemon in trainer.PokemonCollection)
                {
                    pokemon.Health -= 10;
                }

                trainer.PokemonCollection.RemoveAll(p => p.Health < 0);

            }
        }

    }

    public class Trainer
    {
        public string Name { get; set; }

        public int NumberOfBadges { get; set; }

        public List<Pokemon> PokemonCollection { get; set; }

        public Trainer(string name)
        {
            this.Name= name;
            this.NumberOfBadges = 0;
            this.PokemonCollection = new List<Pokemon>();
        }
    }

    public class Pokemon
    {
        public string Name { get; set; }

        public string Element { get; set; }

        public int Health { get; set; }

        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }

    }

}

