using System.Collections.Generic;

namespace gulchvalley.Project
{
    public interface IPlayer
    {
        int Health { get; set; }
        List<Item> Inventory { get; set; }

    }
}