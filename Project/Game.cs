using System;
using System.Collections.Generic;

namespace gulchvalley.Project
{
    public class Game : IGame
    {
        public bool Playing { get; set; }
        public Room CurrentRoom { get; set; }
        public List<Room> Rooms { get; set; }
        public Player CurrentPlayer { get; set; }
        public bool saloonBool = false;
        public bool squareBool = false;
        public bool hotelBool = false;
        public bool jailBool = false;

        public void Setup()
        {
            Playing = true;
            Console.Clear();
            System.Console.WriteLine("The year is 1899. You are a wanderer, as well as a champion of the old west who has conquered many challenges.");
            Console.ReadLine();

            System.Console.WriteLine("You have wandered into a small settlement in the middle of the desert with a population of barely 100.");
            System.Console.WriteLine("The sign on the outskirts of the town reads Gulch Valley. An authoritative figure approaches.");
            Console.ReadLine();
            CurrentPlayer = new Player();
            System.Console.WriteLine("Listen, we have a problem. A robber, looter, and all around thug named Slim Pete came into town 'bout a week ago,");
            System.Console.WriteLine("and has brought nothin' but trouble ever since.");
            Console.ReadLine();

            System.Console.WriteLine("You look like the valiant-but-tough type. I'm gonna need you to get rid of him for me.");
            System.Console.WriteLine("If you can do that, you'll be a town hero forever. Do you accept?");
            System.Console.WriteLine("A: Ok // B: No");
            string choice = Console.ReadLine().ToUpper();

            if (choice == "B")
            {
                System.Console.WriteLine("Carmichael: Well, that's a darn shame, stranger, I'd- wha!?...");
                System.Console.WriteLine("Just as you state your intentions to reject heroism, you hear a sound - a gunshot. You then see blood on your chest.");
                System.Console.WriteLine("You have been shot by Slim Pete! Your death is slow and painful.");
                System.Console.WriteLine("GAME OVER");
                string Continue = Console.ReadLine();
                Reset();
            }

            else if (choice == "A")
            {
                System.Console.WriteLine("Carmichael: Fine choice. I, along with the whole town, appreciate your willingness.");
                System.Console.WriteLine("Feel free to wander about the town. Find yourself a weapon. Take any measures you can to protect yourself...");
                Console.ReadLine();
                System.Console.WriteLine("...Then take ol' Slim Pete down.");
                Console.ReadLine();
            }

            Rooms = new List<Room>();
        }

        public void Square1()
        {
            Console.Clear();
            System.Console.WriteLine("So, you've found yourself in the town square of Gulch Valley, on a mission to take a criminal down.");
            System.Console.WriteLine("Choose where you'd like to go. To see your options, press M for Menu.");
            System.Console.WriteLine("Press A for the Saloon, B for the Hotel, or C for the jail.");
            string choice2 = Console.ReadLine().ToUpper();
            if (choice2 == "A")
            {
                Saloon();
            }
            else if (choice2 == "B")
            {

            }
            else if (choice2 == "C")
            {

            }
            //CurrentRoom = CurrentRoom.Exits[choice2];
        }

        public void Saloon()
        {
            if(saloonBool)
            {
                SaloonEncounter();
            } else {
                Console.WriteLine("You already did this");
            }
        }
        public void SaloonEncounter()
        {

        }

        public void Reset()
        {
            Playing = true;
            Setup();
            BuildGame();
        }

        public void BuildGame()
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

            town.Doors("A", saloon);
            town.Doors("B", hotel);
            town.Doors("C", jail);
            saloon.Doors("Square", town);
            hotel.Doors("Square", town);
            jail.Doors("Square", town);

            CurrentRoom = town;

            // Items

            Item sixShooter = new Item("Six Shooter", "A weapon fit for a duel. Hope you know how to use it.");
            hotel.Items.Add(sixShooter);
            Item bulletproofVest = new Item("Bulletproof Vest", "A metal shielding item, for your protection.");
            jail.Items.Add(bulletproofVest);
            

        }

        public void Go(string direction)
        {
            CurrentRoom = CurrentRoom.Exits[direction];
        }

        public void UseItem(string itemName)
        {

        }


    }

}