using System;
namespace ExerciseOopHierarchy;


public class MainCourseMenuItem : MenuItem
{
    public MainCourseMenuItem(string name, string descriprion, decimal price) : base(name, descriprion, price)
    {
    }

    public override string ToString()
    {
        return $"Main Course: {base.ToString()}";
    }
}

