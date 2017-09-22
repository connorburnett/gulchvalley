using System;

namespace gulchvalley
{
    class Program
    {
        static void Main(string[] args)
        {

            Project.Game game = new Project.Game();

            game.Setup();
            game.BuildRooms();
            game.Square1();
            
            // Game Loop Stuff

            while (game.Playing)
            {

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