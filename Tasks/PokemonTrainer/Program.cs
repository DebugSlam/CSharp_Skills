using static Articles.Program;

namespace Articles;


class Program
{
    static void Main(string[] args)
    {
        //1. СЪЗДАВАНЕ И СЪХРАНЕНИЕ НА ОТБОРИТЕ

        string information = Console.ReadLine();

        Dictionary<string, Pokemon> origTeams = new Dictionary<string, Pokemon>();


        //2. ПРИЧИСЛИ ЧЛЕНОВЕ КЪМ ОТБОР
        while (information != "Tournament")
        {
            string[] informationArray = information.Split(" ");
            string trainerName = informationArray[0];
            string pokemonName = informationArray[1];
            string pokemonElement = informationArray[2];
            int pokemonHealth = int.Parse(informationArray[3]);


            Pokemon currentPokemon = new Pokemon(pokemonElement, pokemonName, pokemonHealth);
            Trainer currentTrainer = new Trainer(trainerName);
            


            origTeams.Add(trainerName, currentPokemon);

            information = Console.ReadLine();
        }


        //2.  ТУРНИР ПОКЕМОН

        while (information != "End")
        {
            string command = information;

            if (origTeams.Any(team => team.Value.Element == command))
               {
                origTeams.Add()
                }


        }

            //3.ПРИНТИРАНЕ /ФИНАЛ

            //1. отбори с членове
            foreach (var team in origTeams.Where(team => team.Value.CollectionPokemon.Count > 0)
            .OrderByDescending(team => team.Value.CollectionPokemon.Count) //sort the team by members count
            .ThenBy(team => team.Key)) //sort alphabetically Teamname
        {

            Console.WriteLine($"{team.Key}\n- {team.Value.NumberBadges}");
            foreach (string member in team.Value.CollectionPokemon.OrderBy(m => m))
            {
                Console.WriteLine("-- " + member);
            }
        }

        Console.WriteLine("Teams to disband:");
        //2. отбори без членове
        foreach (var team in origTeams.Where(team => team.Value.CollectionPokemon.Count == 0)
            .OrderBy(team => team.Key))
        {
            Console.WriteLine(team.Key);
        }
    }

    public class Trainer
    {
        public string Name { get; set; }

        public int NumberBadges { get; set; }

        public List<Pokemon> CollectionPokemon { get; set; }

        public Trainer(string name)
        {
            NumberBadges = 0;
            Name = name;
            CollectionPokemon = new List<Pokemon>();
        }




    }


    public class Pokemon
    {
        public string Name { get; set; }

        public string Element { get; set; }

        public int  Health { get; set; }

        public Pokemon(string element, string name, int health)
        {
            Element = element;
            Name = name;
            Health = health;
        }




    }
}
