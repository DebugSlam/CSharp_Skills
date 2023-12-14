using System;
namespace FarmOOPHierarchy.Animal.Mammal.Feline
{
    public class Tiger : Feline
    {
        public Tiger(string name, string weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override string Talk()
        {
            return "ROAR!!!";
        }
    }
}

