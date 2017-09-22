using System;

namespace gulchvalley
{
    class Program
    {
        static void Main(string[] args)
        {

            Project.Game game = new Project.Game();
            //MyGame.Setup();
            //MyGame.Play();

            // Game Loop Stuff

            bool Running = true;
            while (Running)
            {
                System.Console.WriteLine("The year is 1899. You are a wanderer, as well as a champion of the old west who has conquered many challenges.");
                Console.ReadLine();

                System.Console.WriteLine("You have wandered into a small settlement in the middle of the desert with a population of barely 100.");
                System.Console.WriteLine("The sign on the outskirts of the town reads Gulch Valley. An authoritative figure approaches.");
                Console.ReadLine();

                System.Console.WriteLine("Carmichael: Hello. What is your name?");
                string Name = Console.ReadLine();

                System.Console.WriteLine($"Carmichael: Well, {Name}, I'm Joe Carmichael, Sherriff of this town.");
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
                    Running = false;
                }

                else if (choice == "A")
                {
                    System.Console.WriteLine("Carmichael: Fine choice. I, along with the whole town, appreciate your willingness.");
                    System.Console.WriteLine("Feel free to wander about the town. Find yourself a weapon. Take any measures you can to protect yourself...");
                    Console.ReadLine();
                    System.Console.WriteLine("...Then take ol' Slim Pete down.");
                    Console.ReadLine();

                    Console.Clear();
                    System.Console.WriteLine("So, you've found yourself in the town square of Gulch Valley, on a mission to take a criminal down. Where would you like to go now?");
                    System.Console.WriteLine("A: The Saloon // B: The Hotel // C: The Jail");
                    string choice2 = Console.ReadLine().ToUpper();
                }


                System.Console.WriteLine("Would you like to begin another game?...");
                string Continue = Console.ReadLine();
                if (Continue.ToUpper() == "N")
                {
                    Running = false;
                }
            }

        }
    }
}