using System;
using FarmOOPHierarchy;
using FarmOOPHierarchy.Animal;
namespace FarmOOPHierarchy.Animal.Mammal;

public abstract class Mammal : Animal
{ 
    public string LivingRegion { get; set; }

    public Mammal(string name, string weight, string livingRegion) : base(name, weight)
    {
        this.LivingRegion = livingRegion;
    }
    public override string ToString()
    {
        return $"{this.GetType().Name}[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }

}


