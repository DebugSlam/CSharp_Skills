using System;
namespace FarmOOPHierarchy.Animal.Mammal
{
    public class Dog : Mammal
    {
        public Dog(string name, string weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string Talk()
        {
            return "Woof";
        }
    }
}

