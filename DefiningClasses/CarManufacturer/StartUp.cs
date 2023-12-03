using System;
using System.Collections.Generic;

namespace CarManufacturer
{
	public class StartUp
	{
		static void Main()
		{
			var tires = new Tire[]
			{
				new Tire(1, 2.5),
				new Tire(1, 2.1),

				new Tire(1, 0.5),
				new Tire(1, 2.3),
			};

			var engine = new Engine(560, 6300);

			var lambo = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

			Console.WriteLine(lambo.WhoAmI());
		}

			//string make = Console.ReadLine();

   //         string model = Console.ReadLine();

			//int year = int.Parse(Console.ReadLine());

			//double fuelQuantity = double.Parse(Console.ReadLine());


   //         double fuelConsumption = double.Parse(Console.ReadLine());

			//Car firstCar = new Car(); //golf
			//Car secondCar = new Car(make, model, year); //def fuel
			//Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
	}
}
 



