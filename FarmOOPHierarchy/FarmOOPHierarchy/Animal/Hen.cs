using System;
namespace FarmOOPHierarchy.Animal
{
    public  class Hen : Bird
    {
        public Hen(string name, string weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override string Talk()
        {
            return "Cluck";
        }
    }
}

