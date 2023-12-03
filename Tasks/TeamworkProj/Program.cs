using static Articles.Program;

namespace Articles;


class Program
{
    static void Main(string[] args)
    {
        //1. СЪЗДАВАНЕ И СЪХРАНЕНИЕ НА ОТБОРИТЕ
        int count = int.Parse(Console.ReadLine());

        string information = Console.ReadLine();

        Dictionary<string, Teams> origTeams = new Dictionary<string,Teams>();

        for (int i = 0; i < count; i++)
        {
           
            string[] informationArray = information.Split("-");
            string creator = informationArray[0];
            string teamName = informationArray[1];


           
            if (origTeams.ContainsKey(teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
            }

            else if (origTeams.Any(team => team.Value.Creator == creator))
            {
                Console.WriteLine($"{creator} cannot create another team!");
            }

            else
            {
                Teams currentTeam = new Teams(creator, teamName);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");

                origTeams.Add(teamName, currentTeam);

            }

                information = Console.ReadLine();
        }

        //2. ПРИЧИСЛИ ЧЛЕНОВЕ КЪМ ОТБОР
        while(information != "end of assignment")
        {
            string[] informationArray = information.Split("->");
            string memberName = informationArray[0];
            string teamName = informationArray[1];


           

            Teams currentTeam = new Teams(memberName,teamName);

            if (!origTeams.ContainsKey(teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist!");
            }

            else if (origTeams.Any(team => team.Value.Members.Contains(memberName))
                || origTeams.Any(team => team.Value.Creator.Contains(memberName)))
            {
                Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
            }
            else
            {
                origTeams[teamName].Members.Add(memberName);
              
            }

            information = Console.ReadLine();
        }

        //3.ПРИНТИРАНЕ /ФИНАЛ

        //1. отбори с членове
        foreach (var team in origTeams.Where(team => team.Value.Members.Count > 0)
            .OrderByDescending(team => team.Value.Members.Count) //sort the team by members count
            .ThenBy(team => team.Key)) //sort alphabetically Teamname
        {

            Console.WriteLine($"{team.Key}\n- {team.Value.Creator}");
            foreach (string member in team.Value.Members.OrderBy(m => m))
            {
                Console.WriteLine("-- " + member);
            }
        }

        Console.WriteLine("Teams to disband:");
        //2. отбори без членове
        foreach (var team in origTeams.Where(team => team.Value.Members.Count == 0)
            .OrderBy(team => team.Key))
            {
            Console.WriteLine(team.Key);
            }
    }

    public class Teams
    {
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public Teams(string creator, string name)
        {
            Creator = creator;
            Name = name;
            Members = new List<string> ();
        }

        
        

    }
}
