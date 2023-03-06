using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftProject
{
    internal class Player
    {
        public string Name = "Anonymous Person";
        public List<Item> Inventory = new List<Item>()
        {
            new Item(){Name = "Coffee", Description = "A warm drink.", Value = 5, Quantity = 10 },
            new Item(){Name = "Vegtable Juice", Description = "A healthy cold drink.", Value = 4, Quantity = 10 },
            new Item(){Name = "Fruit Juice", Description = "A sweet cold drink.", Value = 2, Quantity = 10 },
        };

        public string GetInventoryInformation()
        {
            string output = "";
            foreach (Item i in Inventory)
            {
                output += $"{i.Name}: {i.Description}\n Costs: {i.Value}.00\n Available:{i.Quantity} \n\n";
            }

            return output;
        }
    }
}
