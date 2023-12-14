namespace ExerciseOopHierarchy;


public abstract class MenuItem
{
   public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public MenuItem(string name, string descriprion, decimal price)
    {
        this.Name = name;
        this.Description = descriprion;
        this.Price = price;
    }

    public override string ToString()
    { return $"{this.Name} - {this.Description} - ${this.Price}"; }
}
