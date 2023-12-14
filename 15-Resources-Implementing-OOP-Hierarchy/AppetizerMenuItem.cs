using System;
using ExerciseOopHierarchy;

public class AppetizerMenuItem : MenuItem
{
    public AppetizerMenuItem(string name, string descriprion, decimal price) : base(name, descriprion, price)
    {
    }

    public override string ToString()
    {
        return $"Appetizer: {base.ToString()}";
    }
}

