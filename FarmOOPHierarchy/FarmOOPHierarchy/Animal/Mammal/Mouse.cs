using System;
namespace FarmOOPHierarchy.Animal.Mammal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, string weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string Talk()
        {
            return "Squeak";
        }
    }
}

