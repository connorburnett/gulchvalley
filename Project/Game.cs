using System;
using System.Collections.Generic;

namespace gulchvalley.Project
{
    public class Game : IGame
    {

        public Room CurrentRoom { get; set; }
        
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
            Room town = new Room("Town Square", "The small, central square of Gulch Valley, where folks congregate... and where duels are oft fought.");
            Room saloon = new Room("The Saloon", "A place where a feller can socialize, have a drink, and start a rowdy bar fight.");
            Room hotel = new Room("The Hotel", "The type of place where an out-of-towner can get a good night's sleep, for a small price.");
            Room jail = new Room("The Jail", "Where all of Gulch Valley's worst criminals are held - well, except ol' Slim Pete, who no one can seem to lock up.");
            
            Rooms.Add(town);
            Rooms.Add(saloon);
            Rooms.Add(hotel);
            Rooms.Add(jail);
            
            // Establish relationships
            town.Exits.Add("To Saloon", saloon);
            town.Exits.Add("To Hotel", hotel);
            town.Exits.Add("To Jail", jail);
            saloon.Exits.Add("To Town Square", town);
            hotel.Exits.Add("To Town Square", town);
            jail.Exits.Add("To Town Square", town);
        
            // Items



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

    internal class Rooms
    {
        internal static void Add(Room town)
        {
            throw new NotImplementedException();
        }
    }
}