using System;
using System.Collections.Generic;

namespace gulchvalley.Project
{
    public class Player : IPlayer
    {
        //public string CharName;
        public int Health { get; set; }
        public List<Item> Inventory { get; set; }

        public Player()
        {
            //CharName = NameCreate();
            Health = 100;
            Inventory = new List<Item>();
        }

        public void UserItems(Player player)
        {
            System.Console.WriteLine("Your items:");
            for (int i = 0; i < player.Inventory.Count; i++)
            {
                System.Console.WriteLine($"{player.Inventory[i].Name}");
                System.Console.WriteLine($"{player.Inventory[i].Description}");
            }
        }
    }
}