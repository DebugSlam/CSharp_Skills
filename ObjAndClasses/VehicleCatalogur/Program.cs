using System.Collections.Generic;

namespace ObjAndClasses
{


    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            Catalog catalog = new Catalog();

            while (command != "end")
            {
                string[] stringArray = command.Split("/");
                string typeVehicle= stringArray[0];
                string brand = stringArray[1];
                string model = stringArray[2];

                int weightOrHorsepower = int.Parse(stringArray[3]);


                if (typeVehicle == "Truck")
                {
                    

                    Trucks currentTruck = new Trucks
                    {
                    Brand = brand,
                    Model = model,
                    Weight = weightOrHorsepower
                    };


                    catalog.Trucks.Add(currentTruck);

                    
                }

                else if (typeVehicle == "Car")
                {


                    Cars currentCar = new Cars
                    { 
                        Brand = brand,
                        Model = model,
                        HorsePower = weightOrHorsepower

                     };
                

                    catalog.Cars.Add(currentCar);
                }



                command = Console.ReadLine();

            }

            
            if (catalog.Cars.Count >0)
            {
                List<Cars> orderedCars = catalog
                    .Cars.OrderBy(car => car.Brand)
                    .ToList();
                Console.WriteLine("Cars:");

                foreach (Cars car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }

            }

            if (catalog.Trucks.Count > 0)
            {
                List<Trucks> orderedTrucks = catalog
                    .Trucks.OrderBy(truck => truck.Brand)
                    .ToList();
                Console.WriteLine("Trucks:");

                foreach (Trucks truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
                

            }
        }

    }

    public class Trucks
    {
       
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }

    }

    public class Cars
    {
        

        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

    }
    public class Catalog
    {
        public Catalog()
        {
            Cars = new List<Cars>();
       
            Trucks = new List<Trucks>();
            
        }

        public List<Trucks> Trucks{ get; set; }

        public List<Cars> Cars{ get; set; }

        
    }
}



