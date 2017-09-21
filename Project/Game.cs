using System.Collections.Generic;

namespace gulchvalley.Project
{
    public class Game : IGame
    {

        public Room CurrentRoom { get; private set; }
        Room IGame.CurrentRoom { get; set; }
        Player IGame.CurrentPlayer { get; set; }

        public Game()
        {
        }

        void IGame.Reset()
        {
        }

        void IGame.Setup()
        {
            // Build rooms
            Room town = new Room("Town Square", "The center of the action");
            Room saloon = new Room("The Saloon", "Hey pardner, ya want some whiskey?");
            Room hotel = new Room("The Hotel", "Get some rest.");
            Room jail = new Room("The Jail", "Lock em up!");
            // Establish relationships
            town.Exits.Add("To Saloon", saloon);
            town.Exits.Add("To Hotel", hotel);
            town.Exits.Add("To Jail", jail);
            saloon.Exits.Add("To Town Square", town);
            hotel.Exits.Add("To Town Square", town);
            jail.Exits.Add("To Town Square", town);
        
            CurrentRoom = town;
        
        }

        public void Go(string direction)
        {
            CurrentRoom = CurrentRoom.Exits[direction];
        }

        void IGame.UseItem(string itemName)
        {
        }
    }
}