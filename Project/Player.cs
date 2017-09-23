using System;
using System.Collections.Generic;

namespace gulchvalley.Project
{
    public class Player : IPlayer
    {
        public string CharName;
        public int Health { get; set; }
        public List<Item> Inventory { get; set; }

        public Player()
        {
            CharName = CharCreate();
            Health = 100;
            Inventory = new List<Item>();
        }

        public string CharCreate()
        {
                System.Console.WriteLine("Carmichael: Hello. What is your name?");
                string CharName = Console.ReadLine();
                System.Console.WriteLine($"Carmichael: Well, {CharName}, I'm Joe Carmichael, Sheriff of this town.");
                return CharName;
        }

        public void UserItems(Player player)
        {
            for (int i = 0; i < player.Inventory.Count; i++)
            {
                System.Console.WriteLine($"{player.Inventory[i].Name}");
            }
        }
    }
}