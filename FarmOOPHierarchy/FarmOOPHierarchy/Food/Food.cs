using System;
namespace FarmOOPHierarchy.Food
{
	public abstract class Food
	{
		public int Quantity { get; set; }

		public Food(int quantity)

		{
			this.Quantity = quantity;
		}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

