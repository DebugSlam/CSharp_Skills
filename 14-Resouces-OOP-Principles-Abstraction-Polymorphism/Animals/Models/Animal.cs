using System.Diagnostics.Metrics;

namespace Animals.Models;

public abstract class Animal
{
    public string _name;
    public string _favouriteFood;

    public Animal(string name, string favoriteFood)
    {
        this._name = name;
        this._favouriteFood = favoriteFood;
    }


    public virtual string ExplainSelf()
    {
        return $"I am {this._name} and my fovourite food is {this._favouriteFood}";

    }
}
