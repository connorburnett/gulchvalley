using System.Collections.Generic;

namespace gulchvalley.Project
{
    public class Player : IPlayer
    {
        public int Score { get; set; }
        public List<Item> Inventory { get; set; }

        public Player(int score, Item item)
        {
            Score = score;
            Item.Add(item);
            Item.Remove(item);
        }
    }
}