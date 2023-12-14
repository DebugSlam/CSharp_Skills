using System;
namespace ExerciseOopHierarchy;


public class DessertMenuItem : MenuItem
{
    public DessertMenuItem(string name, string descriprion, decimal price) : base(name, descriprion, price)
    {
    }

    public override string ToString()
    {
        return $"Dessert: {base.ToString()}";
    }
}

