using System;
namespace FarmOOPHierarchy.Animal
{
    public abstract class Bird : Animal
    {
        public double Wingsize { get; set; }
        public Bird(string name, string weight, double wingSize) : base(name, weight)
        {
            this.Wingsize = wingSize;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.Name}, {this.Wingsize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}

