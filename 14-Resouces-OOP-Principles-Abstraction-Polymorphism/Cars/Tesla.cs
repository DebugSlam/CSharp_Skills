using Cars;

internal class Tesla : ICar,IElectricCar
{
    public string Model { get ; set ; }
    public string Color { get ; set ; }
    public int Battery { get ; set ; }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
       return "Break!";
    }

    public Tesla(string model, string color, int batteries)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = batteries;
    }
    public override string ToString()
    {
        return $"{this.Color} {this.Model} with {this.Battery} Batteries\n"+
            $"{this.Start()}\n" +
            $"{this.Stop()}"; ;
    }
}