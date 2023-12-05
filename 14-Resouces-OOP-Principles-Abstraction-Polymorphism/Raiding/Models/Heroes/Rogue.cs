namespace Raiding.Models.Heroes;

internal class Rogue : Fighter
{
    public Rogue(string name) : base(name)
    {
    }

    public override int Power => 80;
}