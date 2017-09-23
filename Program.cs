using System;

namespace gulchvalley
{
    class Program
    {
        static void Main(string[] args)
        {

            Project.Game game = new Project.Game();
            game.Playing = true;

            game.Intro();
            game.BuildGame();
            game.Square1();
            
            // Game Loop Stuff

            while (game.Playing)
            {
                

                //string choiceMech = game.

                System.Console.WriteLine("Would you like to begin another game?...");
                string Continue = Console.ReadLine();
                if (Continue.ToUpper() == "NO")
                {
                    game.Playing = false;
                }
            }

        }
    }
}