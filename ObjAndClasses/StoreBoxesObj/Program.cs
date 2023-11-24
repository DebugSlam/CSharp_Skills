using System.Collections.Generic;

namespace ObjAndClasses
{


    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Item> origItem = new ();
            List<Box> origBox = new();

            while (command != "end")
            {
                string[] stringArray = command.Split(" ");
                int boxSerialNumber = int.Parse(stringArray[0]);
                string  boxItemName = stringArray[1];
                int boxItemQuantity = int.Parse(stringArray[2]);

                decimal itemPrice = decimal.Parse(stringArray[3]);



                Item currentItem = new Item
                    (
                    boxItemName,
                    itemPrice
                    );

                Box currentBox = new Box
                    (
                    boxSerialNumber,
                    currentItem,
                    boxItemQuantity
                    );

                origBox.Add(currentBox);


            

                command = Console.ReadLine();

            }

            //List<Box> filteredStudents = origStudents
            //        .Where(x => x.Town == typeCommand)
            //        .ToList();

            origBox = origBox
                .OrderByDescending(box => box.PriceBox)
                .ToList();

            foreach (Box boxes in origBox)
            {
                Console.WriteLine($"{boxes.SerialNumber} ");

                Console.WriteLine($"-- {boxes.Item.Name} - ${boxes.Item.Price:F2}: {boxes.ItemQuantity}");

                Console.WriteLine($"-- ${boxes.PriceBox:F2}");

              
            }

        }

    }

    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;

        }
        public string Name { get; set; }

        public decimal Price { get; set; }

    }

    public class Box
    {
        public Box(int serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;

            Item = item;

            ItemQuantity = itemQuantity;

            PriceBox = item.Price * itemQuantity;
        }

        public int SerialNumber{ get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceBox { get; set; }

    }
}



