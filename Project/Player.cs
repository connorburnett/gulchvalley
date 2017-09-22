using System;
using System.Collections.Generic;

namespace gulchvalley.Project
{
    public class Player : IPlayer
    {
        public string CharName;
        public int Health { get; set; }
        public List<Item> Inventory { get; set; }


        public Player(Item item)
        {
            Health = 100;
            Inventory = new List<Item>();
        }
    }
}