using System.Collections.Generic;

namespace gulchvalley.Project
{
    public interface IPlayer
    {
        int Score { get; set; }
        List<Item> Inventory { get; set; }

    }
}