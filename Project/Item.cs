using System;
using System.Collections.Generic;

namespace gulchvalley.Project
{
    public class Item : IItem
    {
        public Item()
        {
        }

        string IItem.Name { get; set; }
        string IItem.Description { get; set; }

        internal static void Add(Item item)
        {
        }

        internal static void Remove(Item item)
        {
        }
    }
}