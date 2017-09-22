using System.Collections.Generic;

namespace gulchvalley.Project
{
    public class Room : IRoom
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; }
        public Dictionary<string, Room> Exits = new Dictionary<string, Room>();

        public Room(string name, string description)
        {
            Name = name;
            Description = description;
            Items = new List<Item>();
            Exits = new Dictionary<string, Room>();
        }

        public void Doors(string doors, Room room)
        {
            Exits.Add(doors, room);
        }

        public void UseItem(Item item)
        {
        }
    }
}