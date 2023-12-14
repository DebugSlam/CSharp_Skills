using System;
namespace FarmOOPHierarchy.Animal
{
    public class Owl : Bird
    {
        public Owl(string name, string weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override string Talk()
        {
            return "Hoot Hoot";
        }
    }
}

