using System;
using System.Collections.Generic;

namespace gulchvalley.Project
{
    public class Game : IGame
    {
        public Boolean Playing { get; set; }
        public Room CurrentRoom { get; set; }
        public List<Room> Rooms { get; set; }
        public Player CurrentPlayer { get; set; }
        // public bool saloonBool = true;
        // public bool squareBool = true;
        // public bool hotelBool = true;
        // public bool jailBool = true;

        public void Intro()
        {
            Console.Clear();
            System.Console.WriteLine("The year is 1899. You are a wanderer - a champion of the old west.");
            Console.ReadLine();
            System.Console.WriteLine("You have faced many foes and conquered many challenges.");
            Console.ReadLine();
            Console.Beep();

            System.Console.WriteLine("You have wandered into a small settlement in the middle of the desert with a population of barely 100.");
            System.Console.WriteLine("The sign on the outskirts of the town reads Gulch Valley. An authoritative figure approaches.");
            Console.ReadLine();

            System.Console.WriteLine("Carmichael: Hello. What is your name?");
            string CharName = Console.ReadLine();
            System.Console.WriteLine($"Carmichael: Well, {CharName}, I'm Joe Carmichael, Sheriff of this town.");

            //CurrentPlayer = new Player();
            System.Console.WriteLine("Listen, we have a problem. A robber, looter, and all around thug named Slim Pete came into town 'bout a week ago,");
            System.Console.WriteLine("and has brought nothin' but trouble ever since.");
            Console.ReadLine();

            System.Console.WriteLine("You look like the valiant-but-tough type. I'm gonna need you to get rid of him for me.");
            System.Console.WriteLine("If you can do that, you'll be a town hero forever. Do you accept?");
            System.Console.WriteLine("A: Ok // B: No");
            string choice = Console.ReadLine().ToUpper();
            Console.Beep();

            if (choice == "B")
            {
                System.Console.WriteLine("Carmichael: Well, that's a darn shame, stranger, I'd- wha!?...");
                System.Console.WriteLine("Just as you state your intentions to reject heroism, you hear a sound - a gunshot. You then see blood on your chest.");
                System.Console.WriteLine("You have been shot by Slim Pete! Your death is slow and painful.");
                System.Console.WriteLine("GAME OVER");
                string Continue = Console.ReadLine();
                Console.Beep();
                Reset();
            }

            else if (choice == "A")
            {
                System.Console.WriteLine("Carmichael: Fine choice. I, along with the whole town, appreciate your willingness.");
                System.Console.WriteLine("Feel free to wander about the town. Find yourself a weapon. Take any measures you can to protect yourself...");
                Console.ReadLine();
                System.Console.WriteLine("...Then take ol' Slim Pete down.");
                System.Console.WriteLine("DISCLAIMER: THIS STORY TECHNICALLY DOESN'T EXIST IN DEPTH IN THE GAME RIGHT NOW - SORRY!");
                Console.ReadLine();
                Console.Clear();
                Help();
                System.Console.WriteLine("Continue...");
                Console.ReadLine();
                Console.Beep();
            }

            Rooms = new List<Room>();
        }

        public string UserChoice()
        {
            System.Console.WriteLine("Choose what you would like to do.");
            string input = Console.ReadLine();
            return input;
        }

        public void changeRoom(string room)
        {
            if (CurrentRoom.Exits.ContainsKey(room))
            {
                EachRoom(CurrentRoom.Exits[room]);
                CurrentRoom = CurrentRoom.Exits[room];
            }
            else
            {
                System.Console.Write("Not a valid request.");
            }
        }

        // public void Square1()
        // {
        //     Console.Clear();
        //     System.Console.WriteLine("So, you've found yourself in the town square of Gulch Valley, on a mission to take a criminal down.");
        //     System.Console.WriteLine("Choose where you'd like to go. To see your options, press 0 for Help.");
        //     //System.Console.WriteLine("A: Saloon // B: Hotel // C: Jail");
        //     //UserChoice();
        //     string choice2 = Console.ReadLine().ToUpper();
        //     if (choice2 == "S")
        //     {
        //         Saloon();
        //     }
        //     else if (choice2 == "H")
        //     {
        //         HotelEncounter();
        //     }
        //     else if (choice2 == "J")
        //     {
        //         JailEncounter();
        //     }
        //CurrentRoom = CurrentRoom.Exits[choice2];
        // }
        // public void Square2()
        // {
        //     Console.Clear();
        //     System.Console.WriteLine("You find yourself back in the town square of Gulch Valley.");
        //     System.Console.WriteLine("Choose where you'd like to go. To see your options, press M for Menu.");
        //     System.Console.WriteLine("A: Saloon // B: Hotel // C: Jail");
        //     string choice2 = Console.ReadLine().ToUpper();
        //     if (choice2 == "S")
        //     {
        //         Saloon();
        //     }
        //     else if (choice2 == "H")
        //     {
        //         Hotel();
        //     }
        //     else if (choice2 == "J")
        //     {
        //         Jail();
        //     }
        //     CurrentRoom = CurrentRoom.Exits[choice2];
        // }

        // public void Saloon()
        // {
        //     if (saloonBool)
        //     {
        //         SaloonEncounter();
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("You again arrive at the saloon - you take in your surroundings but are feeling unparticipatory.");
        //         System.Console.WriteLine("A: Leave");
        //         string choice = Console.ReadLine().ToUpper();
        //         if (choice == "A")
        //         {
        //             Square2();
        //         }
        //     }
        // }
        // public void SaloonEncounter()
        // {
        //     System.Console.WriteLine("You swing open the doors to the saloon and find yourself in a rowdy, but fun, environment.");
        //     System.Console.WriteLine("You go over to the bar to order a drink.");
        //     Console.ReadLine();
        //     System.Console.WriteLine("Bartender: What'll ya have, stranger?");
        //     System.Console.WriteLine("A. Whiskey // B. Moonshine // C. Black Tar Liquor");
        //     string choice3 = Console.ReadLine().ToUpper();
        //     if (choice3 == "A")
        //     {
        //         System.Console.WriteLine("Bartender: Here y'ar, friend, don't drink it down too fast, ya hear?");
        //         System.Console.WriteLine("You drink it down, unfazed by its alcoholic content.");
        //         Console.ReadLine();
        //     }
        //     else if (choice3 == "B")
        //     {
        //         System.Console.WriteLine("Bartender: There y'ar friend, impor-ta-ted outta the forests 'a southern Tennessee....");
        //         System.Console.WriteLine("You drink it down, unfazed by its alcoholic content.");
        //         Console.ReadLine();
        //     }
        //     else if (choice3 == "C")
        //     {
        //         System.Console.WriteLine("Bartender: Now, this is a bit of an experimental drink, sir. Drink with prejudice.");
        //         Console.ReadLine();
        //         System.Console.WriteLine("All of the sudden you feel an ache in your stomach. Your head is swirling. What was in that drink?... *THUMP*");
        //         System.Console.WriteLine("You fall to the ground - dead.");
        //         System.Console.WriteLine("GAME OVER");
        //         string Continue = Console.ReadLine();
        //         Reset();
        //     }
        //     System.Console.WriteLine("All the sudden, you see a familiar figure...");
        //     System.Console.WriteLine("Hey, that guy looks a lot like... wait -");
        //     Console.ReadLine();
        //     System.Console.WriteLine("...It's Slim Pete!");
        //     Console.ReadLine();
        //     System.Console.WriteLine("You approach him.");
        //     Console.ReadLine();
        //     Console.Clear();
        //     System.Console.WriteLine("Slim Pete: Hey there pardner, back on up, this is my saloon.");
        //     Console.ReadLine();
        //     System.Console.WriteLine("You respond with fearlessness.");
        //     System.Console.WriteLine("Slim Pete: What the what?! You think you can best me, ya wranglin' varmit? Not a chance.");
        //     System.Console.WriteLine("Listen - I would pop a cap in your little face right now - but I don't need folks makin' a rucus.");
        //     Console.ReadLine();
        //     System.Console.WriteLine("Slim Pete: How'sa 'bout we take this out to the square. You and me, a duel to the death, 12 noon tomorra. How's that sound, little man?");
        //     System.Console.WriteLine("A. You're on. // B. Not a chance. You're under arrest.");
        //     string choice4 = Console.ReadLine().ToUpper();
        //     if (choice4 == "A")
        //     {
        //         System.Console.WriteLine("Slim Pete: Glad to hear ya got yerself a spine. Too bad I'm gonna send ya back to the hole where ya came from.");
        //         Console.ReadLine();
        //     }
        //     else if (choice4 == "B")
        //     {
        //         System.Console.WriteLine("Before you can even make a move, Slim Pete whips out his six shooter and you hear a loud noise. *BANG*");
        //         System.Console.WriteLine("Slim Pete has shot you dead.");
        //         System.Console.WriteLine("GAME OVER");
        //         string Continue = Console.ReadLine();
        //         Reset();
        //     }
        //     System.Console.WriteLine("Slim Pete flees the scene. You remain in the saloon, processing the events that have just occured.");
        //     System.Console.WriteLine("A. Leave the saloon");
        //     string choice5 = Console.ReadLine().ToUpper();
        //     if (choice5 == "A")
        //     {
        //         Square2();
        //     }
        // }
        // public void Hotel()
        // {
        //     if (hotelBool)
        //     {
        //         HotelEncounter();
        //     }
        //     else
        //     {
        //         Console.WriteLine("You have");
        //     }
        // }
        // public void HotelEncounter()
        // {

        // }
        // public void Jail()
        // {
        //     if (jailBool)
        //     {
        //         JailEncounter();
        //     }
        //     else
        //     {
        //         Console.WriteLine("Ya already dag-gum dun digery doo did this!!");
        //     }
        // }
        // public void JailEncounter()
        // {

        // }

        public void Reset()
        {
            Playing = true;
            Intro();
            BuildGame();
        }

        public void EachRoom(Room room)
        {
            System.Console.WriteLine($"{room.Name}");
            System.Console.WriteLine($"{room.Description}");
        }

        public void Help()
        {
            System.Console.WriteLine("Press r to view your current room.");
            System.Console.WriteLine("Press 0 for help. (Even though you're already here...)");
            System.Console.WriteLine("Press i for inventory.");
            System.Console.WriteLine("Press t to go to the Town Square.");
            System.Console.WriteLine("Press s to go to the Saloon.");
            System.Console.WriteLine("Press h to go to the Hotel.");
            System.Console.WriteLine("Press j to go to the Jail.");
            System.Console.WriteLine("Use ti (item name) to take item.");
            System.Console.WriteLine("Use ui (item name) to use item.");
        }

        public Boolean Quit(Boolean playing)
        {
            System.Console.WriteLine("Would you like to quit the game?");
            string choice2 = Console.ReadLine().ToUpper();
            if (choice2 == "y")
            {
                return playing = false;
            }
            else
            {
                return playing = true;
            }
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

            town.Doors("s", saloon);
            town.Doors("h", hotel);
            town.Doors("j", jail);
            saloon.Doors("t", town);
            hotel.Doors("t", town);
            jail.Doors("t", town);

            CurrentRoom = town;

            // Items

            Item sixShooter = new Item("Six Shooter", "A weapon fit for a duel..");
            saloon.Items.Add(sixShooter);
            Item bulletproofVest = new Item("Body Armor", "A metal shielding item, for your protection.");
            jail.Items.Add(bulletproofVest);

            Player player = new Player();
            CurrentPlayer = player;

        }

        // public void Go(string direction)
        // {
        //     CurrentRoom = CurrentRoom.Exits[direction];
        // }

        public void TakeItem(string itemName)
        {
            // Item item = CurrentRoom.Items.Find(Item => Item.Name.ToLower() == itemName);
            // if (item != null)
            // {
            //     CurrentRoom.Items.Remove(item);
            //     CurrentPlayer.Inventory.Add(item);
            //     CurrentPlayer.UserItems(CurrentPlayer);
            // }   
            for (int i = 0; i < CurrentRoom.Items.Count; i++)
            {
                Item item = CurrentRoom.Items[i];
                Console.WriteLine(item.Name);
                if (item.Name.ToLower() == itemName.ToLower())
                {
                    CurrentRoom.Items.Remove(item);
                    CurrentPlayer.Inventory.Add(item);
                }
            }
        }

        public void UseItem(string itemName)
        {
            string sixShooter = "six shooter";
            string bodyArmor = "body armor";

            Item item = CurrentPlayer.Inventory.Find(Item => Item.Name.ToLower() == itemName);

            if (item != null && item.Name.ToLower() == sixShooter)
            {
                System.Console.WriteLine("Hey, there's Slim Pete right there! *BANG* He is dead. You win!");
                Console.ReadLine();
                Reset();
            }
            if (item != null && item.Name.ToLower() == bodyArmor)
            {
                System.Console.WriteLine("You have the power of protection! +10 points to you!");
            }
            if (item == null)
            {
                System.Console.WriteLine("You have no item to use!");
            }
        }

    }
}