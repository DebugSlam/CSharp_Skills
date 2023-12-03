using System;
namespace CarManufacturer
{
    public class Engine
    {
        public Engine(int hp, double cc)

        {
            this.HorsePower = hp;
            this.CubicCapacity = cc;
        }

        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }
    }


}