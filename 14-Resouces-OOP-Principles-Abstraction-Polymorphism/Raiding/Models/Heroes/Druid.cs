namespace Raiding.Models.Heroes;


public class Druid : Healer

{
    private string name;

    public Druid(string name) : base(name)
    {
        this.name = name;
    }

    public override int Power => 80 ;

  
}