using System;
namespace FarmOOPHierarchy.Animal
{
	public abstract class Animal : ITalk
	{
		public string Name { get; set; }
		public string Weight { get; set; }
		public int FoodEaten { get; set; }


		public Animal(string name, string weight)
		{
			this.Name = name;
			this.Weight = weight;
			this.FoodEaten = 0;

		}

		public abstract string Talk();
    }
} 

