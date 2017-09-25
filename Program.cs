using System;
using System.Collections.Generic;
using gulchvalley.Project;

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

                string options = game.UserChoice().ToLower();
                string[] key = options.Split(' ');
                Room nextRoom;
                game.CurrentRoom.Exits.TryGetValue(key[0], out nextRoom);

                if(key[0] == "R")
                {
                    System.Console.WriteLine("\n");
                    game.EachRoom(game.CurrentRoom);
                }
                else if(key[0] == "0")
                {
                    game.Help();
                }
                else if(key[0] == "U")
                {
                    game.TakeItem(key[1]);
                }



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