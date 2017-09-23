using System.Collections.Generic;

namespace gulchvalley.Project
{
    public interface IGame
    {
        Room CurrentRoom { get; set; }
        Player CurrentPlayer { get; set; }

        void Intro();
        
        void Reset();

        // void UseItem(string itemName);

    }
}